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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Телеателье__Спектр_DataSet);

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Телеателье__Спектр_DataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this._Телеателье__Спектр_DataSet.Заказы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            заказыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            заказыBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            заказыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            заказыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            заказыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.заказыBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this._Телеателье__Спектр_DataSet);
        }
    }
}
