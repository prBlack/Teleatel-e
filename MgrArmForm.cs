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
    public partial class MgrArmForm : Form
    {
        public MgrArmForm()
        {
            InitializeComponent();
        }

        public bool IsGranted = false;

        public Form PerentForm;
        private void MgrArmForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            this.PerentForm.Enabled = true;
        }

        private SqlConnection sqlConnection = null;

        private SqlCommandBuilder sqlBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;
        private void ShowLogin()
        {
            MgrLoginForm MgrLoginFrm = new MgrLoginForm();
            MgrLoginFrm.PerentForm = this;
            MgrLoginFrm.Show();
            this.Enabled = false;
        }

        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Уволить' AS [SetQuit] FROM Masters", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Masters");

                dataGridView1.DataSource = dataSet.Tables["Masters"];

                for (int i =0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[6, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            try
            {

                dataSet.Tables["Masters"].Clear();

                sqlDataAdapter.Fill(dataSet, "Masters");

                dataGridView1.DataSource = dataSet.Tables["Masters"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[5, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MgrArmForm_Load(object sender, EventArgs e)
        {
            this.ShowLogin();
            sqlConnection = new SqlConnection(@"Data Source=FUJI\SQLSERVER;Initial Catalog=Teleatel_e;Persist Security Info=True;User ID=sa;Password=1234");
            sqlConnection.Open();
            LoadData();
        }

    }
}
