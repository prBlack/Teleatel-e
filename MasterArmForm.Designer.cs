
namespace Teleatel_e
{
    partial class MasterArmForm
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
            this.tabMasterControl = new System.Windows.Forms.TabControl();
            this.tabMasterMainPage = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tabMasterExtPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabMasterControl.SuspendLayout();
            this.tabMasterMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabMasterControl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1196, 590);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabMasterControl
            // 
            this.tabMasterControl.Controls.Add(this.tabMasterMainPage);
            this.tabMasterControl.Controls.Add(this.tabMasterExtPage);
            this.tabMasterControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMasterControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabMasterControl.Location = new System.Drawing.Point(0, 3);
            this.tabMasterControl.Name = "tabMasterControl";
            this.tabMasterControl.SelectedIndex = 0;
            this.tabMasterControl.Size = new System.Drawing.Size(1193, 587);
            this.tabMasterControl.TabIndex = 0;
            // 
            // tabMasterMainPage
            // 
            this.tabMasterMainPage.Controls.Add(this.dgvOrders);
            this.tabMasterMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabMasterMainPage.Location = new System.Drawing.Point(4, 31);
            this.tabMasterMainPage.Name = "tabMasterMainPage";
            this.tabMasterMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMasterMainPage.Size = new System.Drawing.Size(1185, 552);
            this.tabMasterMainPage.TabIndex = 0;
            this.tabMasterMainPage.Text = "Невыполненные заказы";
            this.tabMasterMainPage.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1179, 546);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            this.dgvOrders.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellValueChanged);
            // 
            // tabMasterExtPage
            // 
            this.tabMasterExtPage.Location = new System.Drawing.Point(4, 31);
            this.tabMasterExtPage.Name = "tabMasterExtPage";
            this.tabMasterExtPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMasterExtPage.Size = new System.Drawing.Size(1185, 552);
            this.tabMasterExtPage.TabIndex = 1;
            this.tabMasterExtPage.Text = "Дополнительно";
            this.tabMasterExtPage.UseVisualStyleBackColor = true;
            // 
            // MasterArmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 590);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterArmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АРМ Мастера";
            this.Load += new System.EventHandler(this.MasterArmForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabMasterControl.ResumeLayout(false);
            this.tabMasterMainPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabMasterControl;
        private System.Windows.Forms.TabPage tabMasterMainPage;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TabPage tabMasterExtPage;
    }
}