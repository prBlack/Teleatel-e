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
    public partial class BuhArmForm : Form
    {
        public BuhArmForm()
        {
            InitializeComponent();
        }

        public bool IsGranted = false;

        public Form PerentForm;

        public String authCode = "22222";

        public String sqlConnectionString = "";

        private SqlConnection sqlConnection = null;

        private SqlCommandBuilder sqlBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        private bool newRowAdding = false;
        private void ShowLogin()
        {
            MgrLoginForm MgrLoginFrm = new MgrLoginForm();
            MgrLoginFrm.PerentForm = this;
            MgrLoginFrm.authCode = this.authCode;
            if (MgrLoginFrm.ShowDialog(this) == DialogResult.OK)
            {
                this.Enabled = true;
                this.IsGranted = true;
            }
            else
            {
                this.IsGranted = false;
            }
        }

        private void LoadToGrid(string sqlString, SqlConnection sqlConn, DataGridView frmDg)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sqlString, sqlConn);

                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                DataSet ds = new DataSet();

                da.Fill(ds);

                frmDg.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Delete] FROM Customers", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Customers");

                CustomersGridView.DataSource = dataSet.Tables["Customers"];

                for (int i = 0; i < CustomersGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    CustomersGridView[11, i] = linkCell;
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
                dataSet.Tables["Customers"].Clear();

                sqlDataAdapter.Fill(dataSet, "Customers");

                CustomersGridView.DataSource = dataSet.Tables["Customers"];

                for (int i = 0; i < CustomersGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    CustomersGridView[11, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BuhArmForm_Load(object sender, EventArgs e)
        {
            this.ShowLogin();
            if (this.IsGranted == false)
            {
                this.PerentForm.Enabled = true;
                this.Close();
            }
            sqlConnection = new SqlConnection(this.sqlConnectionString);
            sqlConnection.Open();
            LoadData();
        }

        private void CustomersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 11)
                {
                    string task = CustomersGridView.Rows[e.RowIndex].Cells[11].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            CustomersGridView.Rows.RemoveAt(rowIndex);

                            dataSet.Tables["Customers"].Rows[rowIndex].Delete();

                            sqlDataAdapter.Update(dataSet, "Customers");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = CustomersGridView.Rows.Count - 2;

                        DataRow row = dataSet.Tables["Customers"].NewRow();

                        row["CustomerType"] = CustomersGridView.Rows[rowIndex].Cells["CustomerType"].Value;
                        row["CustomerFio"] = CustomersGridView.Rows[rowIndex].Cells["CustomerFio"].Value;
                        row["CustomerName"] = CustomersGridView.Rows[rowIndex].Cells["CustomerName"].Value;
                        row["CustomerInn"] = CustomersGridView.Rows[rowIndex].Cells["CustomerInn"].Value;
                        row["Chief"] = CustomersGridView.Rows[rowIndex].Cells["Chief"].Value;
                        row["Phone"] = CustomersGridView.Rows[rowIndex].Cells["Phone"].Value;
                        row["Address"] = CustomersGridView.Rows[rowIndex].Cells["Address"].Value;
                        row["Bank"] = CustomersGridView.Rows[rowIndex].Cells["Bank"].Value;
                        row["Distinct"] = CustomersGridView.Rows[rowIndex].Cells["Distinct"].Value;
                        row["Discont"] = CustomersGridView.Rows[rowIndex].Cells["Discont"].Value;

                        dataSet.Tables["Customers"].Rows.Add(row);

                        dataSet.Tables["Customers"].Rows.RemoveAt(dataSet.Tables["Customers"].Rows.Count - 1);

                        CustomersGridView.Rows.RemoveAt(CustomersGridView.Rows.Count - 2);

                        CustomersGridView.Rows[e.RowIndex].Cells[11].Value = "Delete";

                        sqlDataAdapter.Update(dataSet, "Customers");

                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        dataSet.Tables["Customers"].Rows[r]["CustomerType"] = CustomersGridView.Rows[r].Cells["CustomerType"].Value;
                        dataSet.Tables["Customers"].Rows[r]["CustomerFio"] = CustomersGridView.Rows[r].Cells["CustomerFio"].Value;
                        dataSet.Tables["Customers"].Rows[r]["CustomerName"] = CustomersGridView.Rows[r].Cells["CustomerName"].Value;
                        dataSet.Tables["Customers"].Rows[r]["CustomerInn"] = CustomersGridView.Rows[r].Cells["CustomerInn"].Value;
                        dataSet.Tables["Customers"].Rows[r]["Chief"] = CustomersGridView.Rows[r].Cells["Chief"].Value;
                        dataSet.Tables["Customers"].Rows[r]["Phone"] = CustomersGridView.Rows[r].Cells["Phone"].Value;
                        dataSet.Tables["Customers"].Rows[r]["Address"] = CustomersGridView.Rows[r].Cells["Address"].Value;
                        dataSet.Tables["Customers"].Rows[r]["Bank"] = CustomersGridView.Rows[r].Cells["Bank"].Value;
                        dataSet.Tables["Customers"].Rows[r]["Distinct"] = CustomersGridView.Rows[r].Cells["Distinct"].Value;
                        dataSet.Tables["Customers"].Rows[r]["Discont"] = CustomersGridView.Rows[r].Cells["Discont"].Value;

                        sqlDataAdapter.Update(dataSet, "Customers");

                        CustomersGridView.Rows[e.RowIndex].Cells[11].Value = "Delete";

                    }
                    ReloadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomersGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = CustomersGridView.Rows.Count - 2;

                    DataGridViewRow row = CustomersGridView.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    CustomersGridView[11, lastRow] = linkCell;

                    row.Cells["Delete"].Value = "Insert";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomersGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = CustomersGridView.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = CustomersGridView.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    CustomersGridView[11, rowIndex] = linkCell;

                    editingRow.Cells["Delete"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
