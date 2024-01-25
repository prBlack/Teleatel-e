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
using System.IO;



namespace Teleatel_e
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private string sqlConnectionString = "";
        public string sqlConnectionStringTmpl = @"Data Source=[SERVER];Initial Catalog=master;Integrated Security=True";
        public bool IsGranted;
        private void button1_Click(object sender, EventArgs e)
        {
            ;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MgrArmForm MgrArmFrm = new MgrArmForm();
            MgrArmFrm.PerentForm = this;
            MgrArmFrm.sqlConnectionString = textBox1.Text;
            MgrArmFrm.Show();
            //this.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuhArmForm BuhArmFrm = new BuhArmForm();
            BuhArmFrm.PerentForm = this;
            BuhArmFrm.sqlConnectionString = textBox1.Text;
            BuhArmFrm.Show();
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

            string[] theAvailableSqlServers = SqlLocator.GetServers();
            if (theAvailableSqlServers != null)
            {
                comboBox1.DataSource = theAvailableSqlServers;
            }
            else
            {
                MessageBox.Show("SQL сервера не найдены!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String sn = comboBox1.SelectedItem.ToString();
            try
            {
                SqlConnection con = new SqlConnection(this.textBox1.Text);
                con.Open();
                DataSet ds = new DataSet();
                string[] DataBases;
                SqlDataAdapter da = new SqlDataAdapter("SELECT [name] FROM master.dbo.sysdatabases WHERE dbid > 4", con);
                da.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                DataBases = Array.ConvertAll<DataRow, string>(dt.Rows.Cast<DataRow>().ToArray(), r => r[0].ToString());
                //foreach (DataRow dr in dt.Rows)
                //{
                //    DataBases. dr[0].ToString());
                //}
                comboBox2.DataSource = DataBases;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(@"[SERVER]", comboBox1.SelectedItem.ToString());
        }

        private String file;
        private void MainForm_Load(object sender, EventArgs e)
        {
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            file = dir + @"\conf.cfg";
            if (File.Exists(file))
            {
                sqlConnectionString = File.ReadAllText(file);
                this.textBox1.Text = this.sqlConnectionString;
            }
            else {
                this.textBox1.Text = this.sqlConnectionStringTmpl;
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(@"master", comboBox2.SelectedItem.ToString());
        }

        private void saveSqlStrBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(file, textBox1.Text);
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