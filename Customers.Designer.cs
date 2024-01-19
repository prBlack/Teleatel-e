
namespace Teleatel_e
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerTypeLabel;
            System.Windows.Forms.Label customerFioLabel;
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label customerInnLabel;
            System.Windows.Forms.Label chiefLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label bankLabel;
            System.Windows.Forms.Label distinctLabel;
            System.Windows.Forms.Label discontLabel;
            this.label1 = new System.Windows.Forms.Label();
            this._Телеателье__Спектр_DataSet = new Teleatel_e._Телеателье__Спектр_DataSet();
            this.заказчикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказчикиTableAdapter = new Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.ЗаказчикиTableAdapter();
            this.tableAdapterManager = new Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.TableAdapterManager();
            this.customerTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.bankTextBox = new System.Windows.Forms.TextBox();
            this.discontTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fKЗаказыЗаказчикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.ЗаказыTableAdapter();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            customerTypeLabel = new System.Windows.Forms.Label();
            customerFioLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            customerInnLabel = new System.Windows.Forms.Label();
            chiefLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            bankLabel = new System.Windows.Forms.Label();
            distinctLabel = new System.Windows.Forms.Label();
            discontLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Телеателье__Спектр_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKЗаказыЗаказчикиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerTypeLabel
            // 
            customerTypeLabel.AutoSize = true;
            customerTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            customerTypeLabel.Location = new System.Drawing.Point(33, 182);
            customerTypeLabel.Name = "customerTypeLabel";
            customerTypeLabel.Size = new System.Drawing.Size(183, 29);
            customerTypeLabel.TabIndex = 2;
            customerTypeLabel.Text = "Тип заказчика";
            customerTypeLabel.Click += new System.EventHandler(this.customerTypeLabel_Click);
            // 
            // customerFioLabel
            // 
            customerFioLabel.AutoSize = true;
            customerFioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            customerFioLabel.Location = new System.Drawing.Point(238, 117);
            customerFioLabel.Name = "customerFioLabel";
            customerFioLabel.Size = new System.Drawing.Size(194, 29);
            customerFioLabel.TabIndex = 4;
            customerFioLabel.Text = "ФИО заказчика";
            customerFioLabel.Click += new System.EventHandler(this.customerFioLabel_Click);
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            customerNameLabel.Location = new System.Drawing.Point(21, 325);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(285, 29);
            customerNameLabel.TabIndex = 6;
            customerNameLabel.Text = "Название организации";
            customerNameLabel.Click += new System.EventHandler(this.customerNameLabel_Click);
            // 
            // customerInnLabel
            // 
            customerInnLabel.AutoSize = true;
            customerInnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            customerInnLabel.Location = new System.Drawing.Point(678, 325);
            customerInnLabel.Name = "customerInnLabel";
            customerInnLabel.Size = new System.Drawing.Size(65, 29);
            customerInnLabel.TabIndex = 8;
            customerInnLabel.Text = "ИНН";
            // 
            // chiefLabel
            // 
            chiefLabel.AutoSize = true;
            chiefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            chiefLabel.Location = new System.Drawing.Point(21, 381);
            chiefLabel.Name = "chiefLabel";
            chiefLabel.Size = new System.Drawing.Size(335, 29);
            chiefLabel.TabIndex = 10;
            chiefLabel.Text = "Руководитель организации";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            phoneLabel.Location = new System.Drawing.Point(313, 162);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(119, 29);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Телефон";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            addressLabel.Location = new System.Drawing.Point(350, 205);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(82, 29);
            addressLabel.TabIndex = 14;
            addressLabel.Text = "Адрес";
            // 
            // bankLabel
            // 
            bankLabel.AutoSize = true;
            bankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            bankLabel.Location = new System.Drawing.Point(662, 377);
            bankLabel.Name = "bankLabel";
            bankLabel.Size = new System.Drawing.Size(68, 29);
            bankLabel.TabIndex = 16;
            bankLabel.Text = "Банк";
            // 
            // distinctLabel
            // 
            distinctLabel.AutoSize = true;
            distinctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            distinctLabel.Location = new System.Drawing.Point(346, 247);
            distinctLabel.Name = "distinctLabel";
            distinctLabel.Size = new System.Drawing.Size(86, 29);
            distinctLabel.TabIndex = 18;
            distinctLabel.Text = "Район";
            // 
            // discontLabel
            // 
            discontLabel.AutoSize = true;
            discontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            discontLabel.Location = new System.Drawing.Point(455, 497);
            discontLabel.Name = "discontLabel";
            discontLabel.Size = new System.Drawing.Size(308, 29);
            discontLabel.TabIndex = 20;
            discontLabel.Text = "Номер дисконтной карты";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(361, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказчики";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _Телеателье__Спектр_DataSet
            // 
            this._Телеателье__Спектр_DataSet.DataSetName = "_Телеателье__Спектр_DataSet";
            this._Телеателье__Спектр_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказчикиBindingSource
            // 
            this.заказчикиBindingSource.DataMember = "Заказчики";
            this.заказчикиBindingSource.DataSource = this._Телеателье__Спектр_DataSet;
            // 
            // заказчикиTableAdapter
            // 
            this.заказчикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказчикиTableAdapter = this.заказчикиTableAdapter;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.МастераTableAdapter = null;
            this.tableAdapterManager.Ремонтируемые_изделияTableAdapter = null;
            // 
            // customerTypeCheckBox
            // 
            this.customerTypeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.заказчикиBindingSource, "CustomerType", true));
            this.customerTypeCheckBox.Location = new System.Drawing.Point(63, 235);
            this.customerTypeCheckBox.Name = "customerTypeCheckBox";
            this.customerTypeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.customerTypeCheckBox.TabIndex = 3;
            this.customerTypeCheckBox.Text = "checkBox1";
            this.customerTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // bankTextBox
            // 
            this.bankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказчикиBindingSource, "Bank", true));
            this.bankTextBox.Location = new System.Drawing.Point(745, 384);
            this.bankTextBox.Name = "bankTextBox";
            this.bankTextBox.Size = new System.Drawing.Size(187, 22);
            this.bankTextBox.TabIndex = 17;
            // 
            // discontTextBox
            // 
            this.discontTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказчикиBindingSource, "Discont", true));
            this.discontTextBox.Location = new System.Drawing.Point(769, 504);
            this.discontTextBox.Name = "discontTextBox";
            this.discontTextBox.Size = new System.Drawing.Size(174, 22);
            this.discontTextBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(1, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Первый";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Location = new System.Drawing.Point(1, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 32);
            this.button2.TabIndex = 23;
            this.button2.Text = "Предыдущий";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button3.Location = new System.Drawing.Point(1, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 32);
            this.button3.TabIndex = 24;
            this.button3.Text = "Следующий";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button4.Location = new System.Drawing.Point(1, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 32);
            this.button4.TabIndex = 25;
            this.button4.Text = "Последний";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button5.Location = new System.Drawing.Point(396, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 32);
            this.button5.TabIndex = 26;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button6.Location = new System.Drawing.Point(521, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 32);
            this.button6.TabIndex = 27;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button7.Location = new System.Drawing.Point(271, 50);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 32);
            this.button7.TabIndex = 28;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.заказчикиBindingSource;
            this.comboBox1.DisplayMember = "CustomerFio";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(509, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 24);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "CustomerID";
            // 
            // fKЗаказыЗаказчикиBindingSource
            // 
            this.fKЗаказыЗаказчикиBindingSource.DataMember = "FK_Заказы_Заказчики";
            this.fKЗаказыЗаказчикиBindingSource.DataSource = this.заказчикиBindingSource;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(509, 169);
            this.maskedTextBox1.Mask = "000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(268, 22);
            this.maskedTextBox1.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.заказчикиBindingSource;
            this.comboBox2.DisplayMember = "Address";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(509, 208);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(344, 24);
            this.comboBox2.TabIndex = 31;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.заказчикиBindingSource;
            this.comboBox3.DisplayMember = "Distinct";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(509, 250);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(268, 24);
            this.comboBox3.TabIndex = 32;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.заказчикиBindingSource;
            this.comboBox4.DisplayMember = "CustomerName";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(380, 325);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(260, 24);
            this.comboBox4.TabIndex = 33;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.заказчикиBindingSource;
            this.comboBox5.DisplayMember = "Chief";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(380, 384);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(260, 24);
            this.comboBox5.TabIndex = 34;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(761, 331);
            this.maskedTextBox2.Mask = "000000000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox2.TabIndex = 35;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 546);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(discontLabel);
            this.Controls.Add(this.discontTextBox);
            this.Controls.Add(distinctLabel);
            this.Controls.Add(bankLabel);
            this.Controls.Add(this.bankTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(chiefLabel);
            this.Controls.Add(customerInnLabel);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(customerFioLabel);
            this.Controls.Add(customerTypeLabel);
            this.Controls.Add(this.customerTypeCheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customers";
            this.Text = "Заказчики";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Телеателье__Спектр_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKЗаказыЗаказчикиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _Телеателье__Спектр_DataSet _Телеателье__Спектр_DataSet;
        private System.Windows.Forms.BindingSource заказчикиBindingSource;
        private _Телеателье__Спектр_DataSetTableAdapters.ЗаказчикиTableAdapter заказчикиTableAdapter;
        private _Телеателье__Спектр_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox customerTypeCheckBox;
        private System.Windows.Forms.TextBox bankTextBox;
        private System.Windows.Forms.TextBox discontTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource fKЗаказыЗаказчикиBindingSource;
        private _Телеателье__Спектр_DataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}