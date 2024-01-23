
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mgrTabControl = new System.Windows.Forms.TabControl();
            this.tabPageMaster = new System.Windows.Forms.TabPage();
            this.TotalCostMasterChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ReloadDataBtn = new System.Windows.Forms.Button();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.GarantieOrderGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.IncomplateOrderGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.orderComplateGridView = new System.Windows.Forms.DataGridView();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.TotalCostByCustomerGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerUpdateBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.mgrTabControl.SuspendLayout();
            this.tabPageMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCostMasterChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GarantieOrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomplateOrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderComplateGridView)).BeginInit();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCostByCustomerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.mgrTabControl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1077, 740);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // mgrTabControl
            // 
            this.mgrTabControl.Controls.Add(this.tabPageMaster);
            this.mgrTabControl.Controls.Add(this.tabPageOrders);
            this.mgrTabControl.Controls.Add(this.tabPageCustomers);
            this.mgrTabControl.Location = new System.Drawing.Point(8, 8);
            this.mgrTabControl.Name = "mgrTabControl";
            this.mgrTabControl.SelectedIndex = 0;
            this.mgrTabControl.Size = new System.Drawing.Size(1062, 720);
            this.mgrTabControl.TabIndex = 3;
            // 
            // tabPageMaster
            // 
            this.tabPageMaster.Controls.Add(this.TotalCostMasterChart);
            this.tabPageMaster.Controls.Add(this.dataGridView2);
            this.tabPageMaster.Controls.Add(this.ReloadDataBtn);
            this.tabPageMaster.Location = new System.Drawing.Point(4, 25);
            this.tabPageMaster.Name = "tabPageMaster";
            this.tabPageMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMaster.Size = new System.Drawing.Size(1054, 691);
            this.tabPageMaster.TabIndex = 0;
            this.tabPageMaster.Text = "Мастера";
            this.tabPageMaster.UseVisualStyleBackColor = true;
            // 
            // TotalCostMasterChart
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = -60;
            chartArea1.AxisX.LabelStyle.TruncatedLabels = true;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.AxisY.Title = "Выручка, руб.";
            chartArea1.Name = "ChartArea1";
            this.TotalCostMasterChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TotalCostMasterChart.Legends.Add(legend1);
            this.TotalCostMasterChart.Location = new System.Drawing.Point(6, 320);
            this.TotalCostMasterChart.Name = "TotalCostMasterChart";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series1.SmartLabelStyle.IsOverlappedHidden = false;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.TotalCostMasterChart.Series.Add(series1);
            this.TotalCostMasterChart.Size = new System.Drawing.Size(1042, 359);
            this.TotalCostMasterChart.TabIndex = 5;
            this.TotalCostMasterChart.Text = "График";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 55);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1042, 259);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_UserAddedRow);
            // 
            // ReloadDataBtn
            // 
            this.ReloadDataBtn.Location = new System.Drawing.Point(6, 13);
            this.ReloadDataBtn.Name = "ReloadDataBtn";
            this.ReloadDataBtn.Size = new System.Drawing.Size(88, 36);
            this.ReloadDataBtn.TabIndex = 3;
            this.ReloadDataBtn.Text = "Обновить";
            this.ReloadDataBtn.UseVisualStyleBackColor = true;
            this.ReloadDataBtn.Click += new System.EventHandler(this.ReloadDataBtn_Click);
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.label3);
            this.tabPageOrders.Controls.Add(this.GarantieOrderGridView);
            this.tabPageOrders.Controls.Add(this.label2);
            this.tabPageOrders.Controls.Add(this.IncomplateOrderGridView);
            this.tabPageOrders.Controls.Add(this.label1);
            this.tabPageOrders.Controls.Add(this.orderComplateGridView);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(1054, 691);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Заказы";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "В стадии выполнения:";
            // 
            // GarantieOrderGridView
            // 
            this.GarantieOrderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GarantieOrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GarantieOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GarantieOrderGridView.Location = new System.Drawing.Point(536, 36);
            this.GarantieOrderGridView.Name = "GarantieOrderGridView";
            this.GarantieOrderGridView.RowHeadersWidth = 51;
            this.GarantieOrderGridView.RowTemplate.Height = 24;
            this.GarantieOrderGridView.Size = new System.Drawing.Size(512, 65);
            this.GarantieOrderGridView.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(536, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Из них по гарантии:";
            // 
            // IncomplateOrderGridView
            // 
            this.IncomplateOrderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IncomplateOrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.IncomplateOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomplateOrderGridView.Location = new System.Drawing.Point(7, 139);
            this.IncomplateOrderGridView.Name = "IncomplateOrderGridView";
            this.IncomplateOrderGridView.RowHeadersWidth = 51;
            this.IncomplateOrderGridView.RowTemplate.Height = 24;
            this.IncomplateOrderGridView.Size = new System.Drawing.Size(1041, 437);
            this.IncomplateOrderGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выполненные заказы на ремонт";
            // 
            // orderComplateGridView
            // 
            this.orderComplateGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderComplateGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.orderComplateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderComplateGridView.Location = new System.Drawing.Point(7, 36);
            this.orderComplateGridView.Name = "orderComplateGridView";
            this.orderComplateGridView.RowHeadersWidth = 51;
            this.orderComplateGridView.RowTemplate.Height = 24;
            this.orderComplateGridView.Size = new System.Drawing.Size(515, 65);
            this.orderComplateGridView.TabIndex = 0;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.CustomerUpdateBtn);
            this.tabPageCustomers.Controls.Add(this.label4);
            this.tabPageCustomers.Controls.Add(this.TotalCostByCustomerGridView);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(1054, 691);
            this.tabPageCustomers.TabIndex = 2;
            this.tabPageCustomers.Text = "Заказчики";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // TotalCostByCustomerGridView
            // 
            this.TotalCostByCustomerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TotalCostByCustomerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TotalCostByCustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalCostByCustomerGridView.Location = new System.Drawing.Point(7, 47);
            this.TotalCostByCustomerGridView.Name = "TotalCostByCustomerGridView";
            this.TotalCostByCustomerGridView.RowHeadersWidth = 51;
            this.TotalCostByCustomerGridView.RowTemplate.Height = 24;
            this.TotalCostByCustomerGridView.Size = new System.Drawing.Size(1041, 638);
            this.TotalCostByCustomerGridView.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Распределение выручки по заказчикам";
            // 
            // CustomerUpdateBtn
            // 
            this.CustomerUpdateBtn.Location = new System.Drawing.Point(370, 7);
            this.CustomerUpdateBtn.Name = "CustomerUpdateBtn";
            this.CustomerUpdateBtn.Size = new System.Drawing.Size(185, 34);
            this.CustomerUpdateBtn.TabIndex = 2;
            this.CustomerUpdateBtn.Text = "Обновить информацию";
            this.CustomerUpdateBtn.UseVisualStyleBackColor = true;
            this.CustomerUpdateBtn.Click += new System.EventHandler(this.CustomerUpdateBtn_Click);
            // 
            // MgrArmForm
            // 
            this.ClientSize = new System.Drawing.Size(1077, 740);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MgrArmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АРМ Руководителя || Телеателье \"Спектр\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MgrArmForm_FormClosing);
            this.Load += new System.EventHandler(this.MgrArmForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.mgrTabControl.ResumeLayout(false);
            this.tabPageMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TotalCostMasterChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GarantieOrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomplateOrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderComplateGridView)).EndInit();
            this.tabPageCustomers.ResumeLayout(false);
            this.tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCostByCustomerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl mgrTabControl;
        private System.Windows.Forms.TabPage tabPageMaster;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ReloadDataBtn;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.DataVisualization.Charting.Chart TotalCostMasterChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GarantieOrderGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView IncomplateOrderGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderComplateGridView;
        private System.Windows.Forms.Button CustomerUpdateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView TotalCostByCustomerGridView;
    }
}