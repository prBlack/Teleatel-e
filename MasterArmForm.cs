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

        private new SqlCommandBuilder sqlBuilder = null;

        private new SqlDataAdapter sqlDataAdapter = null;
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
            DataSet ds = new DataSet();
            SqlCommand sqlCmd = new SqlCommand("GetIncompleteOrders", sqlConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@MasterFio", SqlDbType.VarChar).Value = this.userRole;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlCmd;
            da.Fill(ds);
            dgvOrders.DataSource = ds.Tables[0];
        }
    }
}
