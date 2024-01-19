
namespace Teleatel_e
{
    partial class Orders
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
            System.Windows.Forms.Label izdelieIDLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label masterIDLabel;
            System.Windows.Forms.Label dateStartLabel;
            System.Windows.Forms.Label dateStopLabel;
            System.Windows.Forms.Label summaLabel;
            System.Windows.Forms.Label periodLabel;
            System.Windows.Forms.Label guaranteeLabel;
            System.Windows.Forms.Label commentLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Телеателье__Спектр_DataSet = new Teleatel_e._Телеателье__Спектр_DataSet();
            this.izdelieIDTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.masterIDTextBox = new System.Windows.Forms.TextBox();
            this.dateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateStopDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.summaTextBox = new System.Windows.Forms.TextBox();
            this.guaranteeCheckBox = new System.Windows.Forms.CheckBox();
            this.заказыTableAdapter = new Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.ЗаказыTableAdapter();
            this.tableAdapterManager = new Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.TableAdapterManager();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            izdelieIDLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            masterIDLabel = new System.Windows.Forms.Label();
            dateStartLabel = new System.Windows.Forms.Label();
            dateStopLabel = new System.Windows.Forms.Label();
            summaLabel = new System.Windows.Forms.Label();
            periodLabel = new System.Windows.Forms.Label();
            guaranteeLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Телеателье__Спектр_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // izdelieIDLabel
            // 
            izdelieIDLabel.AutoSize = true;
            izdelieIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            izdelieIDLabel.Location = new System.Drawing.Point(180, 163);
            izdelieIDLabel.Name = "izdelieIDLabel";
            izdelieIDLabel.Size = new System.Drawing.Size(163, 29);
            izdelieIDLabel.TabIndex = 2;
            izdelieIDLabel.Text = "Код изделия";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            customerIDLabel.Location = new System.Drawing.Point(377, 163);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(181, 29);
            customerIDLabel.TabIndex = 4;
            customerIDLabel.Text = "Код заказчика";
            // 
            // masterIDLabel
            // 
            masterIDLabel.AutoSize = true;
            masterIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            masterIDLabel.Location = new System.Drawing.Point(584, 163);
            masterIDLabel.Name = "masterIDLabel";
            masterIDLabel.Size = new System.Drawing.Size(159, 29);
            masterIDLabel.TabIndex = 6;
            masterIDLabel.Text = "Код мастера";
            // 
            // dateStartLabel
            // 
            dateStartLabel.AutoSize = true;
            dateStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dateStartLabel.Location = new System.Drawing.Point(12, 260);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new System.Drawing.Size(280, 29);
            dateStartLabel.TabIndex = 8;
            dateStartLabel.Text = "Дата приема в ремонт:";
            // 
            // dateStopLabel
            // 
            dateStopLabel.AutoSize = true;
            dateStopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dateStopLabel.Location = new System.Drawing.Point(14, 315);
            dateStopLabel.Name = "dateStopLabel";
            dateStopLabel.Size = new System.Drawing.Size(305, 29);
            dateStopLabel.TabIndex = 10;
            dateStopLabel.Text = "Дата выдачи из ремонта:";
            // 
            // summaLabel
            // 
            summaLabel.AutoSize = true;
            summaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            summaLabel.Location = new System.Drawing.Point(435, 369);
            summaLabel.Name = "summaLabel";
            summaLabel.Size = new System.Drawing.Size(246, 29);
            summaLabel.TabIndex = 12;
            summaLabel.Text = "Стоимость ремонта";
            // 
            // periodLabel
            // 
            periodLabel.AutoSize = true;
            periodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            periodLabel.Location = new System.Drawing.Point(209, 369);
            periodLabel.Name = "periodLabel";
            periodLabel.Size = new System.Drawing.Size(184, 29);
            periodLabel.TabIndex = 14;
            periodLabel.Text = "Срок гарантии";
            // 
            // guaranteeLabel
            // 
            guaranteeLabel.AutoSize = true;
            guaranteeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            guaranteeLabel.Location = new System.Drawing.Point(765, 57);
            guaranteeLabel.Name = "guaranteeLabel";
            guaranteeLabel.Size = new System.Drawing.Size(171, 58);
            guaranteeLabel.TabIndex = 16;
            guaranteeLabel.Text = "Гарантийный\r\nремонт";
            guaranteeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            commentLabel.Location = new System.Drawing.Point(739, 260);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(177, 29);
            commentLabel.TabIndex = 19;
            commentLabel.Text = "Комментарии";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(375, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this._Телеателье__Спектр_DataSet;
            // 
            // _Телеателье__Спектр_DataSet
            // 
            this._Телеателье__Спектр_DataSet.DataSetName = "_Телеателье__Спектр_DataSet";
            this._Телеателье__Спектр_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izdelieIDTextBox
            // 
            this.izdelieIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "IzdelieID", true));
            this.izdelieIDTextBox.Location = new System.Drawing.Point(222, 199);
            this.izdelieIDTextBox.Name = "izdelieIDTextBox";
            this.izdelieIDTextBox.Size = new System.Drawing.Size(70, 22);
            this.izdelieIDTextBox.TabIndex = 3;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(431, 199);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(70, 22);
            this.customerIDTextBox.TabIndex = 5;
            // 
            // masterIDTextBox
            // 
            this.masterIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "MasterID", true));
            this.masterIDTextBox.Location = new System.Drawing.Point(627, 199);
            this.masterIDTextBox.Name = "masterIDTextBox";
            this.masterIDTextBox.Size = new System.Drawing.Size(70, 22);
            this.masterIDTextBox.TabIndex = 7;
            // 
            // dateStartDateTimePicker
            // 
            this.dateStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "DateStart", true));
            this.dateStartDateTimePicker.Location = new System.Drawing.Point(323, 267);
            this.dateStartDateTimePicker.Name = "dateStartDateTimePicker";
            this.dateStartDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateStartDateTimePicker.TabIndex = 9;
            // 
            // dateStopDateTimePicker
            // 
            this.dateStopDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "DateStop", true));
            this.dateStopDateTimePicker.Location = new System.Drawing.Point(323, 322);
            this.dateStopDateTimePicker.Name = "dateStopDateTimePicker";
            this.dateStopDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateStopDateTimePicker.TabIndex = 11;
            // 
            // summaTextBox
            // 
            this.summaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Summa", true));
            this.summaTextBox.Location = new System.Drawing.Point(254, 410);
            this.summaTextBox.Name = "summaTextBox";
            this.summaTextBox.Size = new System.Drawing.Size(100, 22);
            this.summaTextBox.TabIndex = 13;
            // 
            // guaranteeCheckBox
            // 
            this.guaranteeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.заказыBindingSource, "Guarantee", true));
            this.guaranteeCheckBox.Location = new System.Drawing.Point(792, 126);
            this.guaranteeCheckBox.Name = "guaranteeCheckBox";
            this.guaranteeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.guaranteeCheckBox.TabIndex = 17;
            this.guaranteeCheckBox.Text = "checkBox1";
            this.guaranteeCheckBox.UseVisualStyleBackColor = true;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter;
            this.tableAdapterManager.МастераTableAdapter = null;
            this.tableAdapterManager.Ремонтируемые_изделияTableAdapter = null;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(486, 410);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(125, 22);
            this.commentTextBox.TabIndex = 19;
            // 
            // commentTextBox1
            // 
            this.commentTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Comment", true));
            this.commentTextBox1.Location = new System.Drawing.Point(744, 307);
            this.commentTextBox1.Name = "commentTextBox1";
            this.commentTextBox1.Size = new System.Drawing.Size(172, 22);
            this.commentTextBox1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Первый";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Location = new System.Drawing.Point(1, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 34);
            this.button2.TabIndex = 22;
            this.button2.Text = "Предыдущий";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button3.Location = new System.Drawing.Point(1, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 34);
            this.button3.TabIndex = 23;
            this.button3.Text = "Следующий";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button4.Location = new System.Drawing.Point(1, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 31);
            this.button4.TabIndex = 24;
            this.button4.Text = "Последний";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button5.Location = new System.Drawing.Point(415, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 31);
            this.button5.TabIndex = 25;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button6.Location = new System.Drawing.Point(550, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 31);
            this.button6.TabIndex = 26;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button7.Location = new System.Drawing.Point(276, 55);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 31);
            this.button7.TabIndex = 27;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 445);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentTextBox1);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(guaranteeLabel);
            this.Controls.Add(this.guaranteeCheckBox);
            this.Controls.Add(periodLabel);
            this.Controls.Add(summaLabel);
            this.Controls.Add(this.summaTextBox);
            this.Controls.Add(dateStopLabel);
            this.Controls.Add(this.dateStopDateTimePicker);
            this.Controls.Add(dateStartLabel);
            this.Controls.Add(this.dateStartDateTimePicker);
            this.Controls.Add(masterIDLabel);
            this.Controls.Add(this.masterIDTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(izdelieIDLabel);
            this.Controls.Add(this.izdelieIDTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Orders";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Телеателье__Спектр_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _Телеателье__Спектр_DataSet _Телеателье__Спектр_DataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private _Телеателье__Спектр_DataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private _Телеателье__Спектр_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox izdelieIDTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox masterIDTextBox;
        private System.Windows.Forms.DateTimePicker dateStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateStopDateTimePicker;
        private System.Windows.Forms.TextBox summaTextBox;
        private System.Windows.Forms.CheckBox guaranteeCheckBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox commentTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}