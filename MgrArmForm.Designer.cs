
namespace Teleatel_e
{
    partial class MgrArmForm
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
            this.mgrTabControl = new System.Windows.Forms.TabControl();
            this.tabPageMaster = new System.Windows.Forms.TabPage();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.ReloadDataBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.mgrTabControl.SuspendLayout();
            this.tabPageMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mgrTabControl
            // 
            this.mgrTabControl.Controls.Add(this.tabPageMaster);
            this.mgrTabControl.Controls.Add(this.tabPageOrders);
            this.mgrTabControl.Controls.Add(this.tabPageCustomers);
            this.mgrTabControl.Location = new System.Drawing.Point(2, 12);
            this.mgrTabControl.Name = "mgrTabControl";
            this.mgrTabControl.SelectedIndex = 0;
            this.mgrTabControl.Size = new System.Drawing.Size(1084, 491);
            this.mgrTabControl.TabIndex = 2;
            // 
            // tabPageMaster
            // 
            this.tabPageMaster.Controls.Add(this.dataGridView2);
            this.tabPageMaster.Controls.Add(this.ReloadDataBtn);
            this.tabPageMaster.Location = new System.Drawing.Point(4, 25);
            this.tabPageMaster.Name = "tabPageMaster";
            this.tabPageMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMaster.Size = new System.Drawing.Size(1076, 462);
            this.tabPageMaster.TabIndex = 0;
            this.tabPageMaster.Text = "Мастера";
            this.tabPageMaster.UseVisualStyleBackColor = true;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(1076, 462);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Заказы";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // ReloadDataBtn
            // 
            this.ReloadDataBtn.Location = new System.Drawing.Point(6, 13);
            this.ReloadDataBtn.Name = "ReloadDataBtn";
            this.ReloadDataBtn.Size = new System.Drawing.Size(88, 36);
            this.ReloadDataBtn.TabIndex = 3;
            this.ReloadDataBtn.Text = "Обновить";
            this.ReloadDataBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 55);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1064, 401);
            this.dataGridView2.TabIndex = 4;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(1076, 462);
            this.tabPageCustomers.TabIndex = 2;
            this.tabPageCustomers.Text = "Заказчики";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // MgrArmForm
            // 
            this.ClientSize = new System.Drawing.Size(1145, 592);
            this.Controls.Add(this.mgrTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MgrArmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MgrArmForm_FormClosing);
            this.Load += new System.EventHandler(this.MgrArmForm_Load);
            this.mgrTabControl.ResumeLayout(false);
            this.tabPageMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl mgrTabControl;
        private System.Windows.Forms.TabPage tabPageMaster;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ReloadDataBtn;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageCustomers;
    }
}