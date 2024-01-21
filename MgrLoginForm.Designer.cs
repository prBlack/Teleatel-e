
namespace Teleatel_e
{
    partial class MgrLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.MgrPwdBox = new System.Windows.Forms.TextBox();
            this.MgrLoginPwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите пароль руководителя";
            // 
            // MgrPwdBox
            // 
            this.MgrPwdBox.Location = new System.Drawing.Point(22, 61);
            this.MgrPwdBox.Name = "MgrPwdBox";
            this.MgrPwdBox.Size = new System.Drawing.Size(214, 22);
            this.MgrPwdBox.TabIndex = 1;
            // 
            // MgrLoginPwd
            // 
            this.MgrLoginPwd.Location = new System.Drawing.Point(259, 61);
            this.MgrLoginPwd.Name = "MgrLoginPwd";
            this.MgrLoginPwd.Size = new System.Drawing.Size(101, 23);
            this.MgrLoginPwd.TabIndex = 2;
            this.MgrLoginPwd.Text = "Вход";
            this.MgrLoginPwd.UseVisualStyleBackColor = true;
            this.MgrLoginPwd.Click += new System.EventHandler(this.MgrLoginBtn_Click);
            // 
            // MgrLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 128);
            this.Controls.Add(this.MgrLoginPwd);
            this.Controls.Add(this.MgrPwdBox);
            this.Controls.Add(this.label1);
            this.Name = "MgrLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация Руководителя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MgrLoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MgrPwdBox;
        private System.Windows.Forms.Button MgrLoginPwd;
    }
}