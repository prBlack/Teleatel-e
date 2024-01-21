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

        public bool IsGranted = false;

        public Form PerentForm;
        private void MgrLoginBtn_Click(object sender, EventArgs e)
        {
            if (MgrPwdBox.Text == "11111")
            {
                this.PerentForm.Enabled = true;
                this.IsGranted = true;
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

        private void MgrLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ;
        }
    }
}
