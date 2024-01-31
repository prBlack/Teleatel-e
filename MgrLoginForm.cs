using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleatel_e
{
    public partial class MgrLoginForm : Form
    {
        public MgrLoginForm()
        {
            InitializeComponent();
        }

        public String authCode = "";
        public bool IsGranted = false;
        public String userRole;
        public TAForm PerentForm;
        private void MgrLoginBtn_Click(object sender, EventArgs e)
        {
            if (MgrPwdBox.Text == this.authCode)
            {
                this.PerentForm.Enabled = true;
                this.IsGranted = true;
                this.userRole = cbUserRole.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Проль введен не верно");
                this.DialogResult = DialogResult.Cancel;
                //this.Close();
            }
        }
         public new void SetUserRole(String UserRole)
        {
            this.cbUserRole.SelectedIndex = this.cbUserRole.Items.Add(UserRole);
        }

        public void AddRole(string UserRole)
        {
            this.cbUserRole.SelectedIndex = this.cbUserRole.Items.Add(UserRole);
        }
        private void MgrLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ;
        }
    }
}
