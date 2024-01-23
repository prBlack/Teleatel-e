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

        private SqlConnection sqlConnection = null;

        private SqlCommandBuilder sqlBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;
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

        private void BuhArmForm_Load(object sender, EventArgs e)
        {
            MgrArmForm MgrArmFrm = new MgrArmForm();
            MgrArmFrm.PerentForm = this;
            MgrArmFrm.Show();
            if (this.IsGranted == false)
            {
                this.PerentForm.Enabled = true;
                this.Close();
            }
        }
    }
}
