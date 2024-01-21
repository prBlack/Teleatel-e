
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ReloadDataBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1073, 431);
            this.dataGridView2.TabIndex = 0;
            // 
            // ReloadDataBtn
            // 
            this.ReloadDataBtn.Location = new System.Drawing.Point(13, 12);
            this.ReloadDataBtn.Name = "ReloadDataBtn";
            this.ReloadDataBtn.Size = new System.Drawing.Size(88, 36);
            this.ReloadDataBtn.TabIndex = 1;
            this.ReloadDataBtn.Text = "Обновить";
            this.ReloadDataBtn.UseVisualStyleBackColor = true;
            this.ReloadDataBtn.Click += new System.EventHandler(this.ReloadDataBtn_Click);
            // 
            // MgrArmForm
            // 
            this.ClientSize = new System.Drawing.Size(1098, 515);
            this.Controls.Add(this.ReloadDataBtn);
            this.Controls.Add(this.dataGridView2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MgrArmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MgrArmForm_FormClosing);
            this.Load += new System.EventHandler(this.MgrArmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ReloadDataBtn;
    }
}