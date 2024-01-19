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
        private  Orders orders;
        private Masters masters;
        private Customers customers;
        private Products products;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orders = new Orders(); orders.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            masters = new Masters(); masters.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customers = new Customers(); customers.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            products = new Products(); products.Visible = true;
        }
    }
}
