
namespace Teleatel_e
{
    partial class Products
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
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label pictureIDLabel;
            System.Windows.Forms.Label pictureIDLabel1;
            this.label1 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureIDTextBox = new System.Windows.Forms.TextBox();
            this.ремонтируемые_изделияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Телеателье__Спектр_DataSet = new Teleatel_e._Телеателье__Спектр_DataSet();
            this.ремонтируемые_изделияTableAdapter = new Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.Ремонтируемые_изделияTableAdapter();
            this.tableAdapterManager = new Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fKЗаказыРемонтируемыеИзделияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.ЗаказыTableAdapter();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guaranteeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            typeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            pictureIDLabel = new System.Windows.Forms.Label();
            pictureIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтируемые_изделияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Телеателье__Спектр_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKЗаказыРемонтируемыеИзделияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            typeLabel.Location = new System.Drawing.Point(308, 132);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(59, 29);
            typeLabel.TabIndex = 12;
            typeLabel.Text = "Тип";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            countryLabel.Location = new System.Drawing.Point(89, 192);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(278, 29);
            countryLabel.TabIndex = 4;
            countryLabel.Text = "Страна - изготовитель";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            companyLabel.Location = new System.Drawing.Point(282, 246);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(85, 29);
            companyLabel.TabIndex = 10;
            companyLabel.Text = "Бренд";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            ageLabel.Location = new System.Drawing.Point(130, 293);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(237, 29);
            ageLabel.TabIndex = 8;
            ageLabel.Text = "Срок эксплуатации";
            // 
            // pictureIDLabel
            // 
            pictureIDLabel.AutoSize = true;
            pictureIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            pictureIDLabel.Location = new System.Drawing.Point(648, 60);
            pictureIDLabel.Name = "pictureIDLabel";
            pictureIDLabel.Size = new System.Drawing.Size(94, 29);
            pictureIDLabel.TabIndex = 12;
            pictureIDLabel.Text = "Picture:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(297, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Техника";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтируемые_изделияBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(393, 139);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(217, 22);
            this.typeTextBox.TabIndex = 3;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтируемые_изделияBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(393, 192);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(218, 22);
            this.countryTextBox.TabIndex = 5;
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтируемые_изделияBindingSource, "Company", true));
            this.companyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.companyTextBox.Location = new System.Drawing.Point(393, 243);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(218, 22);
            this.companyTextBox.TabIndex = 11;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтируемые_изделияBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(393, 300);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(75, 22);
            this.ageTextBox.TabIndex = 9;
            this.ageTextBox.TextChanged += new System.EventHandler(this.ageTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(2, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Location = new System.Drawing.Point(2, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button3.Location = new System.Drawing.Point(2, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 37);
            this.button3.TabIndex = 16;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button4.Location = new System.Drawing.Point(2, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 37);
            this.button4.TabIndex = 17;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button5.Location = new System.Drawing.Point(323, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 37);
            this.button5.TabIndex = 18;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button6.Location = new System.Drawing.Point(440, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 36);
            this.button6.TabIndex = 19;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button7.Location = new System.Drawing.Point(206, 50);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 36);
            this.button7.TabIndex = 20;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(629, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 198);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureIDLabel1
            // 
            pictureIDLabel1.AutoSize = true;
            pictureIDLabel1.Location = new System.Drawing.Point(600, 89);
            pictureIDLabel1.Name = "pictureIDLabel1";
            pictureIDLabel1.Size = new System.Drawing.Size(73, 17);
            pictureIDLabel1.TabIndex = 21;
            pictureIDLabel1.Text = "Picture ID:";
            pictureIDLabel1.Visible = false;
            // 
            // pictureIDTextBox
            // 
            this.pictureIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ремонтируемые_изделияBindingSource, "PictureID", true));
            this.pictureIDTextBox.Location = new System.Drawing.Point(679, 86);
            this.pictureIDTextBox.Name = "pictureIDTextBox";
            this.pictureIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.pictureIDTextBox.TabIndex = 22;
            this.pictureIDTextBox.Visible = false;
            // 
            // ремонтируемые_изделияBindingSource
            // 
            this.ремонтируемые_изделияBindingSource.DataMember = "Ремонтируемые изделия";
            this.ремонтируемые_изделияBindingSource.DataSource = this._Телеателье__Спектр_DataSet;
            // 
            // _Телеателье__Спектр_DataSet
            // 
            this._Телеателье__Спектр_DataSet.DataSetName = "_Телеателье__Спектр_DataSet";
            this._Телеателье__Спектр_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ремонтируемые_изделияTableAdapter
            // 
            this.ремонтируемые_изделияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.МастераTableAdapter = null;
            this.tableAdapterManager.Ремонтируемые_изделияTableAdapter = this.ремонтируемые_изделияTableAdapter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateStartDataGridViewTextBoxColumn,
            this.CustomerID,
            this.dateStopDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.guaranteeDataGridViewCheckBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKЗаказыРемонтируемыеИзделияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 191);
            this.dataGridView1.TabIndex = 23;
            // 
            // fKЗаказыРемонтируемыеИзделияBindingSource
            // 
            this.fKЗаказыРемонтируемыеИзделияBindingSource.DataMember = "FK_Заказы_Ремонтируемые изделия";
            this.fKЗаказыРемонтируемыеИзделияBindingSource.DataSource = this.ремонтируемые_изделияBindingSource;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            this.dateStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 125;
            // 
            // dateStopDataGridViewTextBoxColumn
            // 
            this.dateStopDataGridViewTextBoxColumn.DataPropertyName = "DateStop";
            this.dateStopDataGridViewTextBoxColumn.HeaderText = "DateStop";
            this.dateStopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateStopDataGridViewTextBoxColumn.Name = "dateStopDataGridViewTextBoxColumn";
            this.dateStopDataGridViewTextBoxColumn.Width = 125;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Summa";
            this.summaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.Width = 125;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.Width = 125;
            // 
            // guaranteeDataGridViewCheckBoxColumn
            // 
            this.guaranteeDataGridViewCheckBoxColumn.DataPropertyName = "Guarantee";
            this.guaranteeDataGridViewCheckBoxColumn.HeaderText = "Guarantee";
            this.guaranteeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.guaranteeDataGridViewCheckBoxColumn.Name = "guaranteeDataGridViewCheckBoxColumn";
            this.guaranteeDataGridViewCheckBoxColumn.Width = 50;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 350;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 558);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(pictureIDLabel1);
            this.Controls.Add(this.pictureIDTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(pictureIDLabel);
            this.Controls.Add(typeLabel);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Products";
            this.Text = "Изделия";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтируемые_изделияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Телеателье__Спектр_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKЗаказыРемонтируемыеИзделияBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _Телеателье__Спектр_DataSet _Телеателье__Спектр_DataSet;
        private System.Windows.Forms.BindingSource ремонтируемые_изделияBindingSource;
        private _Телеателье__Спектр_DataSetTableAdapters.Ремонтируемые_изделияTableAdapter ремонтируемые_изделияTableAdapter;
        private _Телеателье__Спектр_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox pictureIDTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKЗаказыРемонтируемыеИзделияBindingSource;
        private _Телеателье__Спектр_DataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn guaranteeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}