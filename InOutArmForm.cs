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
using System.Threading;

namespace Teleatel_e
{
    public partial class InOutArmForm : Form
    {
        public InOutArmForm()
        {
            InitializeComponent();
        }

        CultureInfo CultTA;

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
                    if (row.Cells[7].Value is true) { row.DefaultCellStyle.BackColor = Color.PaleGreen; }
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

        private void ReloadData()
        {
            String sqlStr = @"SELECT *, 'Выдать' AS [Action] FROM IncompleteOrdersView";
            LoadToGrid(sqlStr, sqlConnection, gvIncompOrder);
            try
            {
                for (int i = 0; i < gvIncompOrder.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    DataGridViewRow row = gvIncompOrder.Rows[i];
                    if (row.Cells[7].Value is true) { row.DefaultCellStyle.BackColor = Color.PaleGreen; }
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

            CultTA = (CultureInfo)CultureInfo.InvariantCulture.Clone();

            CultTA.DateTimeFormat.ShortDatePattern = @"yyyy-MM-dd";
            CultTA.NumberFormat.CurrencyDecimalSeparator = @".";
            CultTA.NumberFormat.CurrencyGroupSeparator = @"";
            CultTA.NumberFormat.NumberDecimalSeparator = @".";
            CultTA.NumberFormat.CurrencyPositivePattern = 0;
            

                sqlConnection = new SqlConnection(this.sqlConnectionString);
            sqlConnection.Open();
            LoadData();


        }

        private decimal Summa = 0.0M;
        private int DiscontPercent = 0;
        private decimal SummaWithDiscont = 0.0M;
        private void Recalculate()
        {
            Summa = Decimal.Parse(tbOutSumma.Text, NumberStyles.Currency, CultTA);
            SummaWithDiscont = ((decimal) Summa * ((decimal)1.00 - (decimal)DiscontPercent / (decimal)100.00));
            tbOutSummWithDiscont.Text = SummaWithDiscont.ToString();
            tbOutDateStop.Text = DateTime.Now.ToString("yyyy-MM-dd");
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
    coalesce(round(O.Summa, 2), round(0.00, 2)) AS Summa,
    O.Comment, 
    coalesce(E.Age, 0) AS Age,
    C.CustomerFio,
    C.CustomerName,
    coalesce(O.Guarantee, 0) AS Guarantee,
    M.MasterFio,
    C.DiscontPercent
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
                            tbOutDateStart.Text = ds.Tables[0].Rows[0].Field<DateTime>("DateStart").ToString(CultTA.DateTimeFormat.ShortDatePattern); 
                            Summa = ds.Tables[0].Rows[0].Field<decimal>("Summa");
                            tbOutSumma.Text = Summa.ToString(CultTA); 
                            tbOutAge.Text = ds.Tables[0].Rows[0].Field<int>("Age").ToString();
                            tbOutVendor.Text = ds.Tables[0].Rows[0].Field<String>("Vendor");
                            //tbOrderId.Text = ds.ld<String>("OrderID");
                            tbOrderId.Text = takeoutOrderId.ToString();
                            rtbOutComment.Text = ds.Tables[0].Rows[0].Field<String>("Comment");
                            tbOutGuarantee.Text = ds.Tables[0].Rows[0].Field<int>("Guarantee").ToString();
                            DiscontPercent = ds.Tables[0].Rows[0].Field<int>("DiscontPercent");
                            tbOutDiscontPercent.Text = DiscontPercent.ToString("0");
                            SummaWithDiscont = (Summa * (1 - DiscontPercent / 100));
                            tbOutSummWithDiscont.Text = SummaWithDiscont.ToString(CultTA);
                            //tbOutDateStop.Text =ds.Tables[0].Rows[0].Field<DateTime>();
                            tbOutCstmrName.Text = ds.Tables[0].Rows[0].Field<String>("CustomerName");
                            tnOutCstmrFio.Text = ds.Tables[0].Rows[0].Field<String>("CustomerFio");
                            tbOutEqType.Text = ds.Tables[0].Rows[0].Field<String>("TypeName");
                            tbOutMasterFio.Text = ds.Tables[0].Rows[0].Field<String>("MasterFio");


                            

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
            InOutTabCtrl.SelectedIndex = 2;
        }

        private void InTab_Click(object sender, EventArgs e)
        {
            ;
        }

        private void tbOutSumma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return)) { SendKeys.Send("{TAB}"); return; } 
            char ch = e.KeyChar;
            char decimalSeparatorChar = Convert.ToChar(CultTA.NumberFormat.CurrencyDecimalSeparator);
            if (ch == decimalSeparatorChar && tbOutSumma.Text.IndexOf(decimalSeparatorChar) != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != decimalSeparatorChar)
            {
                e.Handled = true;
            };
            
        }

        private void tbOutSumma_Enter(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void tbOutSumma_Leave(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            try
            {
                String UpdateString = @"
UPDATE Orders SET
    Summa = @Summa,
    DateStop = @DateStop,
    Guarantee = @Guarantee, 
    Comment = @Comment,
    Completed = 1
FROM Orders
WHERE TypeID = @OrderID";

                SqlCommand sqlCmd = new SqlCommand(UpdateString, sqlConnection);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@OrderID", this.takeoutOrderId);
                sqlCmd.Parameters.AddWithValue("@Summa", this.SummaWithDiscont);
                sqlCmd.Parameters.AddWithValue("@DateStop", Convert.ToDateTime(this.tbOutDateStop.Text, CultTA));
                sqlCmd.Parameters.AddWithValue("@Guarantee", Convert.ToInt16(this.tbOutGuarantee.Text));
                sqlCmd.Parameters.AddWithValue("@Comment", this.rtbOutComment.Text);
                int i = sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Результат", i.ToString(), MessageBoxButtons.OK);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ReloadData();

            InOutTabCtrl.SelectedIndex = 0;
        }
    }
}
