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
    public partial class InOutArmForm : Form
    {
        public InOutArmForm()
        {
            InitializeComponent();
        }

        public bool IsGranted = false;

        public Form PerentForm;

        public String authCode = "33333";

        public String sqlConnectionString = "";

        private SqlConnection sqlConnection = null;

        private SqlCommandBuilder sqlBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        private int takeoutOrderId;
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
            String sqlStr = @"SELECT *, 'Выдать' AS [Action] FROM IncompleteOrdersView";
            LoadToGrid(sqlStr, sqlConnection, gvIncompOrder);
            try
            {
                for (int i = 0; i < gvIncompOrder.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    DataGridViewRow row = gvIncompOrder.Rows[i];
                    if (row.Cells[7].Value is true) { row.DefaultCellStyle.BackColor = Color.GreenYellow; }
                    gvIncompOrder[8, i] = linkCell;
                }
                gvIncompOrder.Columns[0].Width = 30;
                gvIncompOrder.Columns[3].Width = 100;
            }
            catch
            {
                MessageBox.Show(null, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InOutArmForm_Load(object sender, EventArgs e)
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

        private void gvIncompOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8)
                {
                    string task = gvIncompOrder.Rows[e.RowIndex].Cells[8].Value.ToString();

                    if (task == "Выдать")
                    {
                        if (MessageBox.Show("Выдать?", "Выдача", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            takeoutOrderId = System.Convert.ToInt32(gvIncompOrder.Rows[e.RowIndex].Cells[0].Value.ToString());

                            String sqlString = String.Format(@"
SELECT 
    O.TypeID AS OrderId,
    E.Company AS Vendor,
    ET.EqTypeName AS TypeName,
    O.DateStart,
    O.Summa,
    O.Comment,
    C.CustomerFio,
    C.CustomerName,
    M.MasterFio  
FROM Orders AS O LEFT JOIN
    Equipments AS E ON O.IzdelieID = E.IzdelieID LEFT JOIN
    EquipmentType AS ET ON E.EqTypeID = ET.EqTypeID LEFT JOIN
    Masters AS M ON O.MasterID = M.MasterID LEFT JOIN
    Customers AS C ON O.CustomerID = C.CustomerID
WHERE O.TypeID = {0}", takeoutOrderId);

                            MessageBox.Show(sqlString, "", MessageBoxButtons.OK);

                            SqlDataAdapter da = new SqlDataAdapter(sqlString, sqlConnection);

                            SqlCommandBuilder cb = new SqlCommandBuilder(da);

                            DataSet ds = new DataSet();

                            da.Fill(ds);
                            tbOutDateStart.Text = ds.Tables[0].Rows[0].Field<DateTime>("DateStart").ToString();
                            //tbOutSumma.Text = ds.Tables[0].Rows[0].Field<String>("Summa");
                            //tbOutAge.Text = ds.Tables[0].Rows[0].Field<string>("Age");
                            tbOutVendor.Text = ds.Tables[0].Rows[0].Field<String>("Vendor");
                            //tbOrderId.Text = ds.Tables[0].Rows[0].Field<String>("OrderID");
                            tbOrderId.Text = takeoutOrderId.ToString();
                            rtbOutComment.Text = ds.Tables[0].Rows[0].Field<String>("Comment");
                            //tbOutGuarantee.Text = ds.Tables[0].Rows[0].Field<String>("Guaratee");
                            //tbOutDateStop.Text = ds.Tables[0].Rows[0].Field<DateTime>();
                            tbOutCstmrName.Text = ds.Tables[0].Rows[0].Field<String>("CustomerName");
                            tnOutCstmrFio.Text = ds.Tables[0].Rows[0].Field<String>("CustomerFio");
                            tbOutEqType.Text = ds.Tables[0].Rows[0].Field<String>("TypeName");
                            tbOutMasterFio.Text = ds.Tables[0].Rows[0].Field<String>("MasterFio");

                            InOutTabCtrl.SelectedIndex = 2;

                        }
                    }
                    //ReloadMastersData();
                    //ReloadMastersChart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InTab_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
