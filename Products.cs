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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void ремонтируемые_изделияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ремонтируемые_изделияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Телеателье__Спектр_DataSet);

        }
        private void PictureUpdate()
        {
            try
            {
                Bitmap CurImg = new Bitmap(Convert.ToString(((DataRowView)ремонтируемые_изделияBindingSource.Current).Row["PictureID"]));
                this.pictureBox1.Image = CurImg;
                this.pictureBox1.Invalidate();
            }
            catch {; }
        }
        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Телеателье__Спектр_DataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this._Телеателье__Спектр_DataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Телеателье__Спектр_DataSet.Ремонтируемые_изделия". При необходимости она может быть перемещена или удалена.
            this.ремонтируемые_изделияTableAdapter.Fill(this._Телеателье__Спектр_DataSet.Ремонтируемые_изделия);
            this.PictureUpdate();

        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            ремонтируемые_изделияBindingSource.MoveFirst();
            this.PictureUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ремонтируемые_изделияBindingSource.MovePrevious();
            this.PictureUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ремонтируемые_изделияBindingSource.MoveNext();
            this.PictureUpdate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ремонтируемые_изделияBindingSource.MoveLast();
            this.PictureUpdate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ремонтируемые_изделияBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ремонтируемые_изделияBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.ремонтируемые_изделияBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this._Телеателье__Спектр_DataSet);
        }
    }
}
