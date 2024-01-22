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

        private void LoadChart()
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

        private void ReloadData()
        {
            try
            {

                dataSet.Tables["Masters"].Clear();

                sqlDataAdapter.Fill(dataSet, "Masters");

                dataGridView2.DataSource = dataSet.Tables["Masters"];

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView2[5, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadChart()
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
            LoadData();
            LoadChart();
        }

        private void ReloadDataBtn_Click(object sender, EventArgs e)
        {
            ReloadData();
            ReloadChart();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 6)
                {
                    string task = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();

                    if (task == "Уволить")
                    {
                        if (MessageBox.Show("Уволить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes) {
                            int rowIndex = e.RowIndex;

                            dataGridView2.Rows.RemoveAt(rowIndex);

                            dataSet.Tables["Masters"].Rows[rowIndex].Delete();

                            sqlDataAdapter.Update(dataSet, "Masters");
                        }
                    } 
                    else if (task == "Добавить")
                    {

                    }
                    else if (task == "Изменить")
                    {

                    }
                    ReloadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }
    }
}
