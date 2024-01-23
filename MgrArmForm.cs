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

        public String authCode = "11111";

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

        private void LoadMastersData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Delete] FROM Masters ORDER BY Masters.MasterFio", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Masters");

                dataGridView2.DataSource = dataSet.Tables["Masters"];

                for (int i =0; i < dataGridView2.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView2[6, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMastersChart()
        {
            if (IsGranted)
            {

                try
                {
                    SqlDataAdapter sqlChartAdapter = new SqlDataAdapter("SELECT * FROM TotalCostByMastersView", sqlConnection);

                    SqlCommandBuilder sqlChartBuilder = new SqlCommandBuilder(sqlChartAdapter);

                    DataSet dataChartSet = new DataSet();
                    BindingSource bindingSoure = new BindingSource();

                    sqlChartAdapter.Fill(dataChartSet);

                    TotalCostMasterChart.DataSource = dataChartSet.Tables[0];

                    //bindingSoure.DataMember = "TotalCostByMastersView";

                    TotalCostMasterChart.Series[0].XValueMember = (dataChartSet.Tables[0].Columns[0]).ToString();
                    TotalCostMasterChart.Series[0].YValueMembers = (dataChartSet.Tables[0].Columns[1]).ToString();
                    TotalCostMasterChart.Series[0]["PieLabelStyle"] = "Disabled";
                    TotalCostMasterChart.ChartAreas[0].AxisX.Interval = 1;
                    TotalCostMasterChart.ChartAreas[0].AxisX.LabelStyle.Angle = -60;
                    TotalCostMasterChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                    TotalCostMasterChart.DataBind();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReloadMastersData()
        {
            try
            {

                dataSet.Tables["Masters"].Clear();

                sqlDataAdapter.Fill(dataSet, "Masters");

                dataGridView2.DataSource = dataSet.Tables["Masters"];

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView2[6, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadMastersChart()
        {
            try
            {
                             
                SqlDataAdapter sqlChartAdapter = new SqlDataAdapter("SELECT * FROM TotalCostByMastersView", sqlConnection);

                SqlCommandBuilder sqlChartBuilder = new SqlCommandBuilder(sqlChartAdapter);

                DataSet dataChartSet = new DataSet();
                BindingSource bindingSoure = new BindingSource();

                sqlChartAdapter.Fill(dataChartSet);

                TotalCostMasterChart.DataSource = dataChartSet.Tables[0];

                //bindingSoure.DataMember = "TotalCostByMastersView";

                TotalCostMasterChart.Series[0].XValueMember = (dataChartSet.Tables[0].Columns[0]).ToString();
                TotalCostMasterChart.Series[0].YValueMembers = (dataChartSet.Tables[0].Columns[1]).ToString();
                TotalCostMasterChart.Series[0]["PieLabelStyle"] = "Disabled";
                TotalCostMasterChart.ChartAreas[0].AxisX.Interval = 1;
                TotalCostMasterChart.ChartAreas[0].AxisX.LabelStyle.Angle = -60;
                TotalCostMasterChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                TotalCostMasterChart.DataBind();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LoadOrdersData()
        {
            try
            {
                String TotalCompleteOrders = "SELECT * FROM TotalCompleteOrdersView";
                LoadToGrid(TotalCompleteOrders, sqlConnection, orderComplateGridView);
                TotalCompleteOrders = "SELECT * FROM TotalGuarateeCompleteOrdersView";
                LoadToGrid(TotalCompleteOrders, sqlConnection, GarantieOrderGridView);
                TotalCompleteOrders = "SELECT * FROM IncompleteOrdersView";
                LoadToGrid(TotalCompleteOrders, sqlConnection, IncomplateOrderGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomerData()
        {
            String TotalCostByCustomers = "SELECT * FROM TotalCostByCustomersView";
            LoadToGrid(TotalCostByCustomers, sqlConnection, TotalCostByCustomerGridView);
        }
        private void MgrArmForm_Load(object sender, EventArgs e)
        {
            this.ShowLogin();
            if (this.IsGranted == false)
            {
                this.PerentForm.Enabled = true;
                this.Close();
            }
            sqlConnection = new SqlConnection(@"Data Source=FUJI\SQLSERVER;Initial Catalog=Teleatel_e;Persist Security Info=True;User ID=sa;Password=1234");
            sqlConnection.Open();
            LoadMastersData();
            LoadMastersChart();
            LoadOrdersData();
            LoadCustomerData();
        }

        private void ReloadDataBtn_Click(object sender, EventArgs e)
        {
            ReloadMastersData();
            ReloadMastersChart();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 6)
                {
                    string task = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes) {
                            int rowIndex = e.RowIndex;

                            dataGridView2.Rows.RemoveAt(rowIndex);

                            dataSet.Tables["Masters"].Rows[rowIndex].Delete();

                            sqlDataAdapter.Update(dataSet, "Masters");
                        }
                    } 
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView2.Rows.Count - 2;

                        DataRow row = dataSet.Tables["Masters"].NewRow();

                        row["MasterFio"] = dataGridView2.Rows[rowIndex].Cells["MasterFio"].Value;
                        row["Experience"] = dataGridView2.Rows[rowIndex].Cells["Experience"].Value;
                        row["Defect"] = dataGridView2.Rows[rowIndex].Cells["Defect"].Value;
                        row["RepairAll"] = dataGridView2.Rows[rowIndex].Cells["RepairAll"].Value;
                        row["Quited"] = dataGridView2.Rows[rowIndex].Cells["Quited"].Value;

                        dataSet.Tables["Masters"].Rows.Add(row);

                        dataSet.Tables["Masters"].Rows.RemoveAt(dataSet.Tables["Masters"].Rows.Count - 1);

                        dataGridView2.Rows.RemoveAt(dataGridView2.Rows.Count - 2);

                        dataGridView2.Rows[e.RowIndex].Cells[6].Value = "Delete";

                        sqlDataAdapter.Update(dataSet, "Masters");

                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {

                    }
                    ReloadMastersData();
                    ReloadMastersChart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridView2.Rows.Count - 2;

                    DataGridViewRow row = dataGridView2.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    row.Cells["Delete"].Value = "Insert";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerUpdateBtn_Click(object sender, EventArgs e)
        {
            String TotalCostByCustomers = "SELECT * FROM TotalCostByCustomersView";
            LoadToGrid(TotalCostByCustomers, sqlConnection, TotalCostByCustomerGridView);
        }
    }
}
