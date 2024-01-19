
namespace Teleatel_e
{
    partial class Masters
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
            System.Windows.Forms.Label masterFioLabel;
            System.Windows.Forms.Label experienceLabel;
            System.Windows.Forms.Label defectLabel;
            System.Windows.Forms.Label repairAllLabel;
            this.label1 = new System.Windows.Forms.Label();
            this._Телеателье__Спектр_DataSet = new Teleatel_e._Телеателье__Спектр_DataSet();
            this.мастераBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мастераTableAdapter = new Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.МастераTableAdapter();
            this.tableAdapterManager = new Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.TableAdapterManager();
            this.experienceTextBox = new System.Windows.Forms.TextBox();
            this.defectTextBox = new System.Windows.Forms.TextBox();
            this.repairAllTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            masterFioLabel = new System.Windows.Forms.Label();
            experienceLabel = new System.Windows.Forms.Label();
            defectLabel = new System.Windows.Forms.Label();
            repairAllLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Телеателье__Спектр_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастераBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // masterFioLabel
            // 
            masterFioLabel.AutoSize = true;
            masterFioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            masterFioLabel.Location = new System.Drawing.Point(157, 158);
            masterFioLabel.Name = "masterFioLabel";
            masterFioLabel.Size = new System.Drawing.Size(178, 29);
            masterFioLabel.TabIndex = 2;
            masterFioLabel.Text = "ФИО мастера:";
            // 
            // experienceLabel
            // 
            experienceLabel.AutoSize = true;
            experienceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            experienceLabel.Location = new System.Drawing.Point(543, 249);
            experienceLabel.Name = "experienceLabel";
            experienceLabel.Size = new System.Drawing.Size(193, 87);
            experienceLabel.TabIndex = 4;
            experienceLabel.Text = "Опыт работы\r\nпо\r\nспециальности";
            experienceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            experienceLabel.Click += new System.EventHandler(this.experienceLabel_Click);
            // 
            // defectLabel
            // 
            defectLabel.AutoSize = true;
            defectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            defectLabel.Location = new System.Drawing.Point(298, 249);
            defectLabel.Name = "defectLabel";
            defectLabel.Size = new System.Drawing.Size(204, 87);
            defectLabel.TabIndex = 6;
            defectLabel.Text = "Число\r\nнекачественных\r\n ремонтов:";
            defectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repairAllLabel
            // 
            repairAllLabel.AutoSize = true;
            repairAllLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            repairAllLabel.Location = new System.Drawing.Point(12, 249);
            repairAllLabel.Name = "repairAllLabel";
            repairAllLabel.Size = new System.Drawing.Size(253, 87);
            repairAllLabel.TabIndex = 8;
            repairAllLabel.Text = "Число\r\nотремонтированных\r\nизделий:";
            repairAllLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(306, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мастера";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _Телеателье__Спектр_DataSet
            // 
            this._Телеателье__Спектр_DataSet.DataSetName = "_Телеателье__Спектр_DataSet";
            this._Телеателье__Спектр_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // мастераBindingSource
            // 
            this.мастераBindingSource.DataMember = "Мастера";
            this.мастераBindingSource.DataSource = this._Телеателье__Спектр_DataSet;
            // 
            // мастераTableAdapter
            // 
            this.мастераTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Teleatel_e._Телеателье__Спектр_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.МастераTableAdapter = this.мастераTableAdapter;
            this.tableAdapterManager.Ремонтируемые_изделияTableAdapter = null;
            // 
            // experienceTextBox
            // 
            this.experienceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мастераBindingSource, "Experience", true));
            this.experienceTextBox.Location = new System.Drawing.Point(614, 352);
            this.experienceTextBox.Name = "experienceTextBox";
            this.experienceTextBox.Size = new System.Drawing.Size(58, 22);
            this.experienceTextBox.TabIndex = 5;
            // 
            // defectTextBox
            // 
            this.defectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мастераBindingSource, "Defect", true));
            this.defectTextBox.Location = new System.Drawing.Point(363, 352);
            this.defectTextBox.Name = "defectTextBox";
            this.defectTextBox.Size = new System.Drawing.Size(58, 22);
            this.defectTextBox.TabIndex = 7;
            // 
            // repairAllTextBox
            // 
            this.repairAllTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мастераBindingSource, "RepairAll", true));
            this.repairAllTextBox.Location = new System.Drawing.Point(103, 352);
            this.repairAllTextBox.Name = "repairAllTextBox";
            this.repairAllTextBox.Size = new System.Drawing.Size(58, 22);
            this.repairAllTextBox.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мастераBindingSource, "MasterFio", true));
            this.comboBox1.DataSource = this.мастераBindingSource;
            this.comboBox1.DisplayMember = "MasterFio";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(341, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(2, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Первый";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Location = new System.Drawing.Point(2, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Предыдущий";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button3.Location = new System.Drawing.Point(2, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "Следующий";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button4.Location = new System.Drawing.Point(2, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 37);
            this.button4.TabIndex = 14;
            this.button4.Text = "Последний";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button5.Location = new System.Drawing.Point(322, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 37);
            this.button5.TabIndex = 15;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button6.Location = new System.Drawing.Point(436, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 37);
            this.button6.TabIndex = 16;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button7.Location = new System.Drawing.Point(208, 55);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 37);
            this.button7.TabIndex = 17;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Masters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 380);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(repairAllLabel);
            this.Controls.Add(this.repairAllTextBox);
            this.Controls.Add(defectLabel);
            this.Controls.Add(this.defectTextBox);
            this.Controls.Add(experienceLabel);
            this.Controls.Add(this.experienceTextBox);
            this.Controls.Add(masterFioLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Masters";
            this.Text = "Мастера";
            this.Load += new System.EventHandler(this.Masters_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Телеателье__Спектр_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастераBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _Телеателье__Спектр_DataSet _Телеателье__Спектр_DataSet;
        private System.Windows.Forms.BindingSource мастераBindingSource;
        private _Телеателье__Спектр_DataSetTableAdapters.МастераTableAdapter мастераTableAdapter;
        private _Телеателье__Спектр_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox experienceTextBox;
        private System.Windows.Forms.TextBox defectTextBox;
        private System.Windows.Forms.TextBox repairAllTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}