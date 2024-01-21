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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        public bool IsGranted;
        private void button1_Click(object sender, EventArgs e)
        {
            ;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MgrArmForm MgrArmFrm = new MgrArmForm();
            MgrArmFrm.PerentForm = this;
            MgrArmFrm.Show();
            //this.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
