
namespace Teleatel_e
{
    partial class BuhArmForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.buhMainTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersGridView = new System.Windows.Forms.DataGridView();
            this.buhSecTab = new System.Windows.Forms.TabPage();
            this.CumTotalCostGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.buhMainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).BeginInit();
            this.buhSecTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CumTotalCostGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1524, 588);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.buhMainTab);
            this.tabControl1.Controls.Add(this.buhSecTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1514, 603);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // buhMainTab
            // 
            this.buhMainTab.Controls.Add(this.button1);
            this.buhMainTab.Controls.Add(this.label1);
            this.buhMainTab.Controls.Add(this.CustomersGridView);
            this.buhMainTab.Location = new System.Drawing.Point(4, 29);
            this.buhMainTab.Name = "buhMainTab";
            this.buhMainTab.Padding = new System.Windows.Forms.Padding(3);
            this.buhMainTab.Size = new System.Drawing.Size(1506, 570);
            this.buhMainTab.TabIndex = 0;
            this.buhMainTab.Text = "Основное";
            this.buhMainTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заказчики";
            // 
            // CustomersGridView
            // 
            this.CustomersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGridView.Location = new System.Drawing.Point(11, 51);
            this.CustomersGridView.Name = "CustomersGridView";
            this.CustomersGridView.RowHeadersWidth = 51;
            this.CustomersGridView.RowTemplate.Height = 24;
            this.CustomersGridView.Size = new System.Drawing.Size(1489, 488);
            this.CustomersGridView.TabIndex = 0;
            this.CustomersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGridView_CellContentClick);
            this.CustomersGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGridView_CellValueChanged);
            this.CustomersGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.CustomersGridView_UserAddedRow);
            // 
            // buhSecTab
            // 
            this.buhSecTab.Controls.Add(this.CumTotalCostGridView);
            this.buhSecTab.Location = new System.Drawing.Point(4, 29);
            this.buhSecTab.Name = "buhSecTab";
            this.buhSecTab.Padding = new System.Windows.Forms.Padding(3);
            this.buhSecTab.Size = new System.Drawing.Size(1506, 570);
            this.buhSecTab.TabIndex = 1;
            this.buhSecTab.Text = "Дополнительно";
            this.buhSecTab.UseVisualStyleBackColor = true;
            // 
            // CumTotalCostGridView
            // 
            this.CumTotalCostGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CumTotalCostGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CumTotalCostGridView.Location = new System.Drawing.Point(3, 3);
            this.CumTotalCostGridView.Name = "CumTotalCostGridView";
            this.CumTotalCostGridView.RowHeadersWidth = 51;
            this.CumTotalCostGridView.RowTemplate.Height = 24;
            this.CumTotalCostGridView.Size = new System.Drawing.Size(1500, 564);
            this.CumTotalCostGridView.TabIndex = 0;
            // 
            // BuhArmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 639);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "BuhArmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuhArmForm";
            this.Load += new System.EventHandler(this.BuhArmForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.buhMainTab.ResumeLayout(false);
            this.buhMainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).EndInit();
            this.buhSecTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CumTotalCostGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage buhMainTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustomersGridView;
        private System.Windows.Forms.TabPage buhSecTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView CumTotalCostGridView;
    }
}