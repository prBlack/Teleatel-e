
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.buhMainTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersGridView = new System.Windows.Forms.DataGridView();
            this.buhSecTab = new System.Windows.Forms.TabPage();
            this.CumTotalCostGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cumCostChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.buhMainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).BeginInit();
            this.buhSecTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CumTotalCostGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cumCostChart)).BeginInit();
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
            this.CustomersGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomersGridView.Location = new System.Drawing.Point(3, 79);
            this.CustomersGridView.Name = "CustomersGridView";
            this.CustomersGridView.RowHeadersWidth = 51;
            this.CustomersGridView.RowTemplate.Height = 24;
            this.CustomersGridView.Size = new System.Drawing.Size(1500, 488);
            this.CustomersGridView.TabIndex = 0;
            this.CustomersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGridView_CellContentClick);
            this.CustomersGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGridView_CellValueChanged);
            this.CustomersGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.CustomersGridView_UserAddedRow);
            // 
            // buhSecTab
            // 
            this.buhSecTab.Controls.Add(this.cumCostChart);
            this.buhSecTab.Controls.Add(this.label2);
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
            this.CumTotalCostGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CumTotalCostGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CumTotalCostGridView.Location = new System.Drawing.Point(3, 47);
            this.CumTotalCostGridView.Name = "CumTotalCostGridView";
            this.CumTotalCostGridView.RowHeadersWidth = 51;
            this.CumTotalCostGridView.RowTemplate.Height = 24;
            this.CumTotalCostGridView.Size = new System.Drawing.Size(743, 509);
            this.CumTotalCostGridView.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(606, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Накопительные итоги по выручке";
            // 
            // cumCostChart
            // 
            this.cumCostChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.cumCostChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cumCostChart.Legends.Add(legend1);
            this.cumCostChart.Location = new System.Drawing.Point(752, 47);
            this.cumCostChart.Name = "cumCostChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Выручка";
            series1.YValuesPerPoint = 4;
            this.cumCostChart.Series.Add(series1);
            this.cumCostChart.Size = new System.Drawing.Size(733, 509);
            this.cumCostChart.TabIndex = 2;
            this.cumCostChart.Text = "chart1";
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
            this.buhSecTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CumTotalCostGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cumCostChart)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cumCostChart;
    }
}