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
using System.Globalization;

namespace Teleatel_e
{
    public partial class MasterArmForm : TAForm
    {
        public MasterArmForm()
        {
            InitializeComponent();
        }

        private new CultureInfo CultTA;

        public new bool IsGranted = false;

        public new Form PerentForm;

        public new String userRole = "Мастер";

        public new String authCode = "44444";

        public new String sqlConnectionString = "";

        private new SqlConnection sqlConnection = null;

        private new SqlCommandBuilder sb = null;

        private SqlCommand sqlCmd;

        private new SqlDataAdapter da;

        private new DataSet ds;
        private new void ShowLogin()
        {
            MgrLoginForm MgrLoginFrm = new MgrLoginForm();
            MgrLoginFrm.PerentForm = this;
            String sqlString = "SELECT MasterFio FROM Masters";
            SqlDataAdapter da = new SqlDataAdapter(sqlString, sqlConnection);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                MgrLoginFrm.AddRole(row[0].ToString());
            }

            
            MgrLoginFrm.authCode = this.authCode;
            MgrLoginFrm.FormClosing += (sender1, e1) =>
            {
                //Обновляем текстбокс основной формы
                this.userRole = MgrLoginFrm.userRole == null ? this.userRole : MgrLoginFrm.userRole;
            };
            if (MgrLoginFrm.ShowDialog(this) == DialogResult.OK)
            {
                this.Enabled = true;
                this.IsGranted = true;
                this.Text = String.Format(@"АРМ Мастера || {0} || Телеателье 'СПЕКТР'", this.userRole); 
            }
            else
            {
                this.IsGranted = false;
            }
        }

        public new void SetUserRole(String ur)
        {
            this.userRole = ur;
        }

        
        private void MasterArmForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(this.sqlConnectionString);
            sqlConnection.Open();
            ShowLogin();
            if (IsGranted == true)
            {
                LoadData();
            }
            else
            {
                this.Close();
            }
        }

        private void LoadData()
        {
            ds = new DataSet();
            sqlCmd = new SqlCommand("GetIncompleteOrders", sqlConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@MasterFio", SqlDbType.VarChar).Value = this.userRole;
            da = new SqlDataAdapter();
            da.SelectCommand = sqlCmd;
            da.Fill(ds);
            dgvOrders.DataSource = ds.Tables[0];
            dgvOrders.Columns[0].Width = 20;
            //DataGridViewRow dgvRow = new DataGridViewRow();
            /*for (int i = 0; i < dgvOrders.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                dgvOrders[6, i] = linkCell;
            }*/
            foreach (int i in new List<int>() { 0, 1, 2, 3 })
            {
                dgvOrders.Columns[i].ReadOnly = true;
                dgvOrders.Columns[i].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void ReloadData()
        {
            ds.Tables[0].Clear();
            da.SelectCommand = sqlCmd;
            da.Fill(ds);
            dgvOrders.DataSource = ds.Tables[0];
            dgvOrders.Columns[0].Width = 20;

            foreach (int i in new List<int>() { 0, 1, 2, 3 })
            {
                dgvOrders.Columns[i].ReadOnly = true;
                dgvOrders.Columns[i].DefaultCellStyle.BackColor = Color.LightGray;
            }

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = e.RowIndex;
                //DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                //dgvOrders[6, r] = linkCell;
                if (e.ColumnIndex == 6)
                {
                    string task = dgvOrders.Rows[e.RowIndex].Cells[6].Value.ToString();

                    if (task == "Обновить")
                    {
                        
                        //int OrderID = int.Parse(dgvOrders.Rows[r].Cells[0].Value.ToString());
                        //String Comment = dgvOrders.Rows[r].Cells[4].Value.ToString();
                        //int Repaired = int.Parse(dgvOrders.Rows[r].Cells[5].Value.ToString());
                        String sqlUpdateStr = @"
UPDATE Orders
SET 
    Comment = @Comment,
    Repaired = @Repaired
FROM Orders
WHERE TypeID = @OrderID";

                        SqlCommand sqlCmd = new SqlCommand(sqlUpdateStr, sqlConnection);
                        //sqlCmd.Connection.Open();
                        sqlCmd.Parameters.AddWithValue("@OrderID", dgvOrders.Rows[r].Cells[0].Value);
                        sqlCmd.Parameters.AddWithValue("@Comment", dgvOrders.Rows[r].Cells[4].Value);
                        sqlCmd.Parameters.AddWithValue("@Repaired", dgvOrders.Rows[r].Cells[5].Value);
                        sqlCmd.ExecuteNonQuery();
                    }
                    ReloadData();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = dgvOrders.SelectedCells[0].RowIndex;

            DataGridViewRow editingRow = dgvOrders.Rows[rowIndex];

            DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

            dgvOrders[6, rowIndex] = linkCell;
            dgvOrders[6, rowIndex].ReadOnly = false;

        }
    }
}
