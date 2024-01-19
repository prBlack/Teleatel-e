﻿using System;
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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void заказчикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказчикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Телеателье__Спектр_DataSet);

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Телеателье__Спектр_DataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this._Телеателье__Спектр_DataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Телеателье__Спектр_DataSet.Заказчики". При необходимости она может быть перемещена или удалена.
            this.заказчикиTableAdapter.Fill(this._Телеателье__Спектр_DataSet.Заказчики);

        }

        private void customerTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerFioLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказчикиBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            заказчикиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            заказчикиBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            заказчикиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            заказчикиBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            заказчикиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.заказчикиBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this._Телеателье__Спектр_DataSet);
        }
    }
}
