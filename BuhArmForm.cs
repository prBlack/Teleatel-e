﻿using System;
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
    public partial class BuhArmForm : TAForm
    {
        public BuhArmForm()
        {
            InitializeComponent();
        }

        public bool IsGranted = false;

        public Form PerentForm;

        public string userRole = "Бухгалтер";
        
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
            MgrLoginFrm.SetUserRole(this.userRole);
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

        public void SetUserRole(String ur)
        {
            this.userRole = ur;
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

                    CustomersGridView[12, i] = linkCell;
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

                    CustomersGridView[12, i] = linkCell;
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
            if (this.IsGranted == true)
            {
                sqlConnection = new SqlConnection(this.sqlConnectionString);
                sqlConnection.Open();
                LoadData();
                LoadCumDate();
                LoadCumCostChart();
            }
            else
            {
                this.PerentForm.Enabled = true;
                this.Close();
            }
        }

        private void CustomersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 12)
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

                        CustomersGridView.Rows[e.RowIndex].Cells[12].Value = "Delete";

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

                    CustomersGridView[12, lastRow] = linkCell;

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

                    CustomersGridView[12, rowIndex] = linkCell;

                    editingRow.Cells["Delete"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String cumTotalCostString = @"
SELECT O.*,
       coalesce(sum(O.Summa) over (order by O.DateStop 
                rows between unbounded preceding and current row), 
                0) AS total
FROM (SELECT
	C.CustomerFio,
	T.CustomerID,
	T.DateStop,
	T.Summa
FROM Orders AS T 
	LEFT JOIN Customers AS C
		ON T.CustomerID = C.CustomerID
		WHERE T.DateStop IS NOT NULL) AS O
ORDER BY O.DateStop";

        private void LoadCumDate()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter(cumTotalCostString, sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Orders");

                CumTotalCostGridView.DataSource = dataSet.Tables[0];

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

        private void LoadCumCostChart()
        {
            try
            {
                SqlDataAdapter sqlChartAdapter = new SqlDataAdapter(cumTotalCostString, sqlConnection);

                SqlCommandBuilder sqlChartBuilder = new SqlCommandBuilder(sqlChartAdapter);

                DataSet dsCumCostChart = new DataSet();
                BindingSource bindingSoure = new BindingSource();

                sqlChartAdapter.Fill(dsCumCostChart);

                if (dsCumCostChart != null)
                {
                    cumCostChart.DataSource = dsCumCostChart.Tables[0];

                    //bindingSoure.DataMember = "TotalCostByMastersView";

                    cumCostChart.Series[0].XValueMember = (dsCumCostChart.Tables[0].Columns[2]).ToString();
                    cumCostChart.Series[0].YValueMembers = (dsCumCostChart.Tables[0].Columns[4]).ToString();
                    cumCostChart.Series[0]["PieLabelStyle"] = "Disabled";
                    cumCostChart.ChartAreas[0].AxisX.Interval = 1;
                    cumCostChart.ChartAreas[0].AxisX.LabelStyle.Angle = -60;
                    cumCostChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                    cumCostChart.DataBind();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
