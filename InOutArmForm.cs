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
using System.Windows;
using System.IO;

namespace Teleatel_e
{
    public partial class InOutArmForm : TAForm
    {
        public InOutArmForm()
        {
            InitializeComponent();
        }

        private CultureInfo CultTA;

        public byte[] CurPicture;

        public int LastOrder;

        public int LastEquipment;

        public bool IsGranted = false;

        public Form PerentForm;

        public string userRole = "Диспетчер";
        
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
            MgrLoginFrm.SetUserRole(this.userRole);
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
            if (this.IsGranted == true)
            {

                CultTA = (CultureInfo)CultureInfo.InvariantCulture.Clone();

                CultTA.DateTimeFormat.ShortDatePattern = @"yyyy-MM-dd";
                CultTA.NumberFormat.CurrencyDecimalSeparator = @".";
                CultTA.NumberFormat.CurrencyGroupSeparator = @"";
                CultTA.NumberFormat.NumberDecimalSeparator = @".";
                CultTA.NumberFormat.CurrencyPositivePattern = 0;


                sqlConnection = new SqlConnection(this.sqlConnectionString);
                sqlConnection.Open();
                LoadData();
                //LoadDict();
            }
            else
            {
                this.PerentForm.Enabled = true;
                this.Close();
            }

        }

        private decimal Summa = 0.0M;
        private int DiscontPercent = 0;
        private decimal SummaWithDiscont = 0.0M;
        private void Recalculate()
        {
            Summa = Decimal.Parse(tbOutSumma.Text, NumberStyles.Currency, CultTA);
            SummaWithDiscont = ((decimal)Summa * ((decimal)1.00 - (decimal)DiscontPercent / (decimal)100.00));
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
            //LoadDict();
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

        private void LoadDict()
        {
            var dictMasters = new Dictionary<string, string>();


            String sqlStrDictM = @"SELECT S.MasterFio + ' - заказов в работе: ' + CAST(S.InProc AS VARCHAR(10)) AS Description, S.MasterFio AS MasterFio 
FROM
(SELECT M.MasterFio, count(O.TypeID) AS 'InProc'
FROM (SELECT O.TypeID, O.MasterID FROM Orders AS O WHERE O.Repaired = 0) AS O
RIGHT JOIN Masters AS M ON O.MasterID = M.MasterID
GROUP BY M.MasterFio) AS S
ORDER BY InProc";
            String sqlStrDictC = @"SELECT CustomerFio FROM CUstomers";
            String sqlStrDictET = @"SELECT EqTypeName FROM EquipmentType";

            DataSet dsMasters = new DataSet();
            DataSet dsCustomers = new DataSet();
            DataSet dsEqType = new DataSet();


            //SqlDataAdapter daM = new SqlDataAdapter(sqlStrDictM, sqlConnection);

            //SqlCommandBuilder cbM = new SqlCommandBuilder(daM);

            //daM.Fill(dsMasters);
            FillDs(sqlStrDictM, sqlConnection, dsMasters);

            /*foreach (DataRow row in dsMasters.Tables[0].Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = row["MasterFio"].ToString() + " - заказов в работе:  " + row["In proc"].ToString();
                item.Value = row["MasterFio"].ToString();
                cbInMasterFio.Items.Add(item);
                //cbInMasterFio.SelectedIndex = -1;
            }*/
            try
            {
                cbInMasterFio.DataBindings.Add(new Binding("SelectedValue", dsMasters.Tables[0], "MasterFio"));
                cbInMasterFio.DataSource = dsMasters.Tables[0];
                cbInMasterFio.DisplayMember = "Description";
                cbInMasterFio.ValueMember = "MasterFio";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FillDs(sqlStrDictC, sqlConnection, dsCustomers);

            /*foreach (DataRow row in dsCustomers.Tables[0].Rows)
            {
                cbInCustomerFio.Items.Add(row[0].ToString());
            }*/

            try
            {
                cbInCustomerFio.DataBindings.Add(new Binding("SelectedItem", dsCustomers.Tables[0], "CustomerFio"));
                cbInCustomerFio.DataSource = dsCustomers.Tables[0];
                cbInCustomerFio.DisplayMember = "CustomerFio";
                //cbInCustomerFio.ValueMember = "CustomerFio";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            FillDs(sqlStrDictET, sqlConnection, dsEqType);
            /*foreach (DataRow row in dsEqType.Tables[0].Rows)
            {
                cbInEqType.Items.Add(row[0].ToString());
            } */

            try
            {
                cbInEqType.DataBindings.Add(new Binding("SelectedItem", dsEqType.Tables[0], "EqTypeName"));
                cbInEqType.DataSource = dsEqType.Tables[0];
                cbInEqType.DisplayMember = "EqTypeName";
                //cbInCustomerFio.ValueMember = "CustomerFio";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FillDs (String sqlString, SqlConnection sqlConn, DataSet ds)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlString, sqlConn);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            da.Fill(ds);
        }
        private void InTab_MouseClick(object sender, MouseEventArgs e)
        {
            //LoadDict();
        }

        private void InOutTabCtrl_Selected(object sender, TabControlEventArgs e)
        {
            if (InOutTabCtrl.SelectedIndex == 1)
            {
                LoadDict();
                tbInDateStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
        }

        private void btnTakeIn_Click(object sender, EventArgs e)
        {
            /*
             *   @EqTypeName VARCHAR(50),
             *   @MasterFio VARCHAR(50),
             *   @CustomerFio VARCHAR(50),
             *   @Country VARCHAR(50),
             *   @Company VARCHAR(50),
             *   @Age int,
             *   @Comment VARCHAR(MAX)
             */



            string EqTypeName = cbInEqType.Text;
            //ComboboxItem cbI = cbInMasterFio.SelectedValue;
            string MasterFio = cbInMasterFio.SelectedValue.ToString();
            string CustomerFio = cbInCustomerFio.Text;
            string Country = tbInCountry.Text;
            string Company = tbInVendor.Text;
            int Age = int.Parse(tbInAge.Text);
            string Comment = tbInComment.Text;

            SqlCommand sqlCmd = new SqlCommand("UsP_AddNewOrder", sqlConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@EqTypeName", SqlDbType.VarChar).Value = EqTypeName;
            sqlCmd.Parameters.AddWithValue("@MasterFio", SqlDbType.VarChar).Value = MasterFio;
            sqlCmd.Parameters.AddWithValue("@CustomerFio", SqlDbType.VarChar).Value = CustomerFio;
            sqlCmd.Parameters.AddWithValue("@Country", SqlDbType.VarChar).Value = Country;
            sqlCmd.Parameters.AddWithValue("@Company", SqlDbType.VarChar).Value = Company;
            sqlCmd.Parameters.AddWithValue("@Age", SqlDbType.Int).Value = Age;
            sqlCmd.Parameters.AddWithValue("@Comment", SqlDbType.VarChar).Value = Comment;
            //sqlCmd.Parameters.Add("@OrderID", SqlDbType.Int);
            //sqlCmd.Parameters.Add("@IzdelieID", SqlDbType.Int);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read() && CurPicture != null)
            {
                LastOrder = reader.GetInt32(0); // ["OrderID"];
                tbInId.Text = LastOrder.ToString();
                LastEquipment = reader.GetInt32(1); //["IzdelieID"];
                PicToDb(LastEquipment, CurPicture);
            }

            cbInMasterFio.DataBindings.Clear();
            cbInCustomerFio.DataBindings.Clear();
            cbInEqType.DataBindings.Clear();
            reader.Close();
            LastEquipment = -1;
            CurPicture = null;
            LastOrder = -1;
            LoadData();
            InOutTabCtrl.SelectedIndex = 0;

        }

        private void InTab_Leave(object sender, EventArgs e)
        {
            cbInMasterFio.DataBindings.Clear();
            cbInCustomerFio.DataBindings.Clear();
            cbInEqType.DataBindings.Clear();
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
                OpenFileDialog openFileDialog = new OpenFileDialog(); // создаем диалоговое окно
                openFileDialog.ShowDialog(); // показываем
                this.CurPicture = File.ReadAllBytes(openFileDialog.FileName); // получаем байты выбранного файла

                this.pbInPicture.Load(openFileDialog.FileName) ;

                /*if (this.tbInId.Text != null)
                {
                    PicToDb(int.Parse(this.tbInId.Text), CurPicture);
                }*/

        }

        private void PicToDb(int IzdelieID, byte[] Picture)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConnection;
            sqlCmd.CommandText = @"INSERT INTO Pictures (IzdelieID, Picture) VALUES (@IzdelieID, @ImageData)";
            sqlCmd.Parameters.Add("@ImageData", SqlDbType.Image, 1000000);
            sqlCmd.Parameters["@ImageData"].Value = Picture;
            sqlCmd.Parameters.AddWithValue("@IzdelieID", SqlDbType.Int).Value = IzdelieID;
            sqlCmd.ExecuteNonQuery();
        }
    }

    /*public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString()
        {
            return Text;
        }

        public string GetValue()
        {
            return Value.ToString();
        }
    } */

}
