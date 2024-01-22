using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Teleatel_e
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        public string Conn = @"Data Source=";
        public bool IsGranted;
        private void button1_Click(object sender, EventArgs e)
        {
            ;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MgrArmForm MgrArmFrm = new MgrArmForm();
            MgrArmFrm.PerentForm = this;
            MgrArmFrm.Show();
            //this.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ;
        }

        private void ScanSqlBtn_Click(object sender, EventArgs e)
        {
            //Предварительно очищаем все элементы управления
            //в которые будут выводиться данные
            comboBox1.Items.Clear();
            richTextBox1.Text = string.Empty;

            string[] theAvailableSqlServers = SqlLocator.GetServers();
            if (theAvailableSqlServers != null)
            {
                comboBox1.DataSource = theAvailableSqlServers;
                foreach (string NameServer in theAvailableSqlServers)
                {
                    richTextBox1.Text += NameServer + Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show("SQL сервера не найдены!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sn = comboBox1.SelectedItem.ToString();
            try
            {
                Conn += sn;
                Conn += ";Integrated Security=True;";
                SqlConnection con = new SqlConnection(Conn);
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM sys.database", con);
                comboBox2.Items.Add(da);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = Conn;
        }
    }

    public class SqlLocator
    {
        [System.Runtime.InteropServices.DllImport("odbc32.dll")]
        private static extern short SQLAllocHandle(short hType, IntPtr inputHandle, out IntPtr outputHandle);
        [System.Runtime.InteropServices.DllImport("odbc32.dll")]
        private static extern short SQLSetEnvAttr(IntPtr henv, int attribute, IntPtr valuePtr, int strLength);
        [System.Runtime.InteropServices.DllImport("odbc32.dll")]
        private static extern short SQLFreeHandle(short hType, IntPtr handle);
        [System.Runtime.InteropServices.DllImport("odbc32.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        private static extern short SQLBrowseConnect(IntPtr hconn, StringBuilder inString,
         short inStringLength, StringBuilder outString, short outStringLength,
         out short outLengthNeeded);

        private const short SQL_HANDLE_ENV = 1;
        private const short SQL_HANDLE_DBC = 2;
        private const int SQL_ATTR_ODBC_VERSION = 200;
        private const int SQL_OV_ODBC3 = 3;
        private const short SQL_SUCCESS = 0;

        private const short SQL_NEED_DATA = 99;
        private const short DEFAULT_RESULT_SIZE = 1024;
        private const string SQL_DRIVER_STR = "DRIVER=SQL SERVER";

        private SqlLocator() { }

        public static string[] GetServers()
        {
            string[] retval = null;
            string txt = string.Empty;
            IntPtr henv = IntPtr.Zero;
            IntPtr hconn = IntPtr.Zero;
            StringBuilder inString = new StringBuilder(SQL_DRIVER_STR);
            StringBuilder outString = new StringBuilder(DEFAULT_RESULT_SIZE);
            short inStringLength = (short)inString.Length;
            short lenNeeded = 0;

            try
            {
                if (SQL_SUCCESS == SQLAllocHandle(SQL_HANDLE_ENV, henv, out henv))
                {
                    if (SQL_SUCCESS == SQLSetEnvAttr(henv, SQL_ATTR_ODBC_VERSION, (IntPtr)SQL_OV_ODBC3, 0))
                    {
                        if (SQL_SUCCESS == SQLAllocHandle(SQL_HANDLE_DBC, henv, out hconn))
                        {
                            if (SQL_NEED_DATA == SQLBrowseConnect(hconn, inString, inStringLength, outString,
                             DEFAULT_RESULT_SIZE, out lenNeeded))
                            {
                                if (DEFAULT_RESULT_SIZE < lenNeeded)
                                {
                                    outString.Capacity = lenNeeded;
                                    if (SQL_NEED_DATA != SQLBrowseConnect(hconn, inString, inStringLength, outString,
                                     lenNeeded, out lenNeeded))
                                    {
                                        throw new ApplicationException("Unabled to aquire SQL Servers from ODBC driver.");
                                    }
                                }
                                txt = outString.ToString();
                                int start = txt.IndexOf("{") + 1;
                                int len = txt.IndexOf("}") - start;
                                if ((start > 0) && (len > 0))
                                {
                                    txt = txt.Substring(start, len);
                                }
                                else
                                {
                                    txt = string.Empty;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
#if (DEBUG)
                MessageBox.Show(ex.Message, "Acquire SQL Servier List Error");
#endif
                txt = string.Empty;
            }
            finally
            {
                if (hconn != IntPtr.Zero)
                {
                    SQLFreeHandle(SQL_HANDLE_DBC, hconn);
                }
                if (henv != IntPtr.Zero)
                {
                    SQLFreeHandle(SQL_HANDLE_ENV, hconn);
                }
            }

            if (txt.Length > 0)
            {
                retval = txt.Split(",".ToCharArray());
            }

            return retval;
        }

    }
}