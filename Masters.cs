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
    public partial class Masters : Form
    {
        public Masters()
        {
            InitializeComponent();
        }

        private void мастераBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.мастераBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Телеателье__Спектр_DataSet);

        }

        private void Masters_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Телеателье__Спектр_DataSet.Мастера". При необходимости она может быть перемещена или удалена.
            this.мастераTableAdapter.Fill(this._Телеателье__Спектр_DataSet.Мастера);

        }

        private void experienceLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            мастераBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            мастераBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            мастераBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            мастераBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            мастераBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            мастераBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.мастераBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this._Телеателье__Спектр_DataSet);
        }
    }
}
