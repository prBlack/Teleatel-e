
namespace Teleatel_e
{
    partial class InOutArmForm
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
            this.InOutTabCtrl = new System.Windows.Forms.TabControl();
            this.ListTab = new System.Windows.Forms.TabPage();
            this.gvIncompOrder = new System.Windows.Forms.DataGridView();
            this.InTab = new System.Windows.Forms.TabPage();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnTakeIn = new System.Windows.Forms.Button();
            this.cbInEqType = new System.Windows.Forms.ComboBox();
            this.cbInCustomerFio = new System.Windows.Forms.ComboBox();
            this.cbInMasterFio = new System.Windows.Forms.ComboBox();
            this.tbInComment = new System.Windows.Forms.TextBox();
            this.tbInDateStart = new System.Windows.Forms.TextBox();
            this.tbInSumma = new System.Windows.Forms.TextBox();
            this.tbInAge = new System.Windows.Forms.TextBox();
            this.tbInCountry = new System.Windows.Forms.TextBox();
            this.tbInVendor = new System.Windows.Forms.TextBox();
            this.tbInId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbInPicture = new System.Windows.Forms.PictureBox();
            this.OutTab = new System.Windows.Forms.TabPage();
            this.tbOutEqType = new System.Windows.Forms.TextBox();
            this.tbOutCstmrName = new System.Windows.Forms.TextBox();
            this.tnOutCstmrFio = new System.Windows.Forms.TextBox();
            this.tbOutMasterFio = new System.Windows.Forms.TextBox();
            this.rtbOutComment = new System.Windows.Forms.RichTextBox();
            this.btnTakeOut = new System.Windows.Forms.Button();
            this.pbOutPicture = new System.Windows.Forms.PictureBox();
            this.tbOutGuarantee = new System.Windows.Forms.TextBox();
            this.tbOutDateStop = new System.Windows.Forms.TextBox();
            this.tbOutDateStart = new System.Windows.Forms.TextBox();
            this.tbOutSummWithDiscont = new System.Windows.Forms.TextBox();
            this.tbOutDiscontPercent = new System.Windows.Forms.TextBox();
            this.tbOutSumma = new System.Windows.Forms.TextBox();
            this.tbOutAge = new System.Windows.Forms.TextBox();
            this.tbOutVendor = new System.Windows.Forms.TextBox();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.InOutTabCtrl.SuspendLayout();
            this.ListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvIncompOrder)).BeginInit();
            this.InTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInPicture)).BeginInit();
            this.OutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.InOutTabCtrl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1262, 606);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // InOutTabCtrl
            // 
            this.InOutTabCtrl.Controls.Add(this.ListTab);
            this.InOutTabCtrl.Controls.Add(this.InTab);
            this.InOutTabCtrl.Controls.Add(this.OutTab);
            this.InOutTabCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InOutTabCtrl.Location = new System.Drawing.Point(3, 3);
            this.InOutTabCtrl.Name = "InOutTabCtrl";
            this.InOutTabCtrl.SelectedIndex = 0;
            this.InOutTabCtrl.Size = new System.Drawing.Size(1247, 591);
            this.InOutTabCtrl.TabIndex = 0;
            this.InOutTabCtrl.Selected += new System.Windows.Forms.TabControlEventHandler(this.InOutTabCtrl_Selected);
            // 
            // ListTab
            // 
            this.ListTab.Controls.Add(this.gvIncompOrder);
            this.ListTab.Location = new System.Drawing.Point(4, 29);
            this.ListTab.Name = "ListTab";
            this.ListTab.Padding = new System.Windows.Forms.Padding(3);
            this.ListTab.Size = new System.Drawing.Size(1239, 558);
            this.ListTab.TabIndex = 0;
            this.ListTab.Text = "Лист невыданных заказов";
            this.ListTab.UseVisualStyleBackColor = true;
            // 
            // gvIncompOrder
            // 
            this.gvIncompOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvIncompOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIncompOrder.Location = new System.Drawing.Point(7, 44);
            this.gvIncompOrder.MultiSelect = false;
            this.gvIncompOrder.Name = "gvIncompOrder";
            this.gvIncompOrder.RowHeadersWidth = 51;
            this.gvIncompOrder.RowTemplate.Height = 24;
            this.gvIncompOrder.Size = new System.Drawing.Size(1226, 508);
            this.gvIncompOrder.TabIndex = 0;
            this.gvIncompOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvIncompOrder_CellContentClick);
            // 
            // InTab
            // 
            this.InTab.Controls.Add(this.btnAddPicture);
            this.InTab.Controls.Add(this.btnTakeIn);
            this.InTab.Controls.Add(this.cbInEqType);
            this.InTab.Controls.Add(this.cbInCustomerFio);
            this.InTab.Controls.Add(this.cbInMasterFio);
            this.InTab.Controls.Add(this.tbInComment);
            this.InTab.Controls.Add(this.tbInDateStart);
            this.InTab.Controls.Add(this.tbInSumma);
            this.InTab.Controls.Add(this.tbInAge);
            this.InTab.Controls.Add(this.tbInCountry);
            this.InTab.Controls.Add(this.tbInVendor);
            this.InTab.Controls.Add(this.tbInId);
            this.InTab.Controls.Add(this.label9);
            this.InTab.Controls.Add(this.label8);
            this.InTab.Controls.Add(this.label7);
            this.InTab.Controls.Add(this.label19);
            this.InTab.Controls.Add(this.label6);
            this.InTab.Controls.Add(this.label5);
            this.InTab.Controls.Add(this.label4);
            this.InTab.Controls.Add(this.label3);
            this.InTab.Controls.Add(this.label2);
            this.InTab.Controls.Add(this.label1);
            this.InTab.Controls.Add(this.pbInPicture);
            this.InTab.Location = new System.Drawing.Point(4, 29);
            this.InTab.Name = "InTab";
            this.InTab.Padding = new System.Windows.Forms.Padding(3);
            this.InTab.Size = new System.Drawing.Size(1239, 558);
            this.InTab.TabIndex = 1;
            this.InTab.Text = "Принять в ремонт";
            this.InTab.UseVisualStyleBackColor = true;
            this.InTab.Click += new System.EventHandler(this.InTab_Click);
            this.InTab.Leave += new System.EventHandler(this.InTab_Leave);
            this.InTab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InTab_MouseClick);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(562, 469);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(315, 44);
            this.btnAddPicture.TabIndex = 5;
            this.btnAddPicture.Text = "Добавить изображение";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // btnTakeIn
            // 
            this.btnTakeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTakeIn.Location = new System.Drawing.Point(27, 469);
            this.btnTakeIn.Name = "btnTakeIn";
            this.btnTakeIn.Size = new System.Drawing.Size(456, 45);
            this.btnTakeIn.TabIndex = 4;
            this.btnTakeIn.Text = "Принять";
            this.btnTakeIn.UseVisualStyleBackColor = true;
            this.btnTakeIn.Click += new System.EventHandler(this.btnTakeIn_Click);
            // 
            // cbInEqType
            // 
            this.cbInEqType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInEqType.FormattingEnabled = true;
            this.cbInEqType.Location = new System.Drawing.Point(295, 65);
            this.cbInEqType.Name = "cbInEqType";
            this.cbInEqType.Size = new System.Drawing.Size(188, 30);
            this.cbInEqType.TabIndex = 2;
            // 
            // cbInCustomerFio
            // 
            this.cbInCustomerFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInCustomerFio.FormattingEnabled = true;
            this.cbInCustomerFio.Location = new System.Drawing.Point(830, 77);
            this.cbInCustomerFio.Name = "cbInCustomerFio";
            this.cbInCustomerFio.Size = new System.Drawing.Size(368, 30);
            this.cbInCustomerFio.TabIndex = 2;
            // 
            // cbInMasterFio
            // 
            this.cbInMasterFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInMasterFio.FormattingEnabled = true;
            this.cbInMasterFio.Location = new System.Drawing.Point(830, 19);
            this.cbInMasterFio.Name = "cbInMasterFio";
            this.cbInMasterFio.Size = new System.Drawing.Size(368, 30);
            this.cbInMasterFio.TabIndex = 2;
            // 
            // tbInComment
            // 
            this.tbInComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInComment.Location = new System.Drawing.Point(295, 403);
            this.tbInComment.Name = "tbInComment";
            this.tbInComment.Size = new System.Drawing.Size(188, 28);
            this.tbInComment.TabIndex = 1;
            // 
            // tbInDateStart
            // 
            this.tbInDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInDateStart.Location = new System.Drawing.Point(295, 337);
            this.tbInDateStart.Name = "tbInDateStart";
            this.tbInDateStart.Size = new System.Drawing.Size(188, 28);
            this.tbInDateStart.TabIndex = 1;
            // 
            // tbInSumma
            // 
            this.tbInSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInSumma.Location = new System.Drawing.Point(295, 282);
            this.tbInSumma.Name = "tbInSumma";
            this.tbInSumma.Size = new System.Drawing.Size(188, 28);
            this.tbInSumma.TabIndex = 1;
            // 
            // tbInAge
            // 
            this.tbInAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInAge.Location = new System.Drawing.Point(295, 222);
            this.tbInAge.Name = "tbInAge";
            this.tbInAge.Size = new System.Drawing.Size(188, 28);
            this.tbInAge.TabIndex = 1;
            // 
            // tbInCountry
            // 
            this.tbInCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInCountry.Location = new System.Drawing.Point(295, 171);
            this.tbInCountry.Name = "tbInCountry";
            this.tbInCountry.Size = new System.Drawing.Size(188, 28);
            this.tbInCountry.TabIndex = 1;
            // 
            // tbInVendor
            // 
            this.tbInVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInVendor.Location = new System.Drawing.Point(295, 119);
            this.tbInVendor.Name = "tbInVendor";
            this.tbInVendor.Size = new System.Drawing.Size(188, 28);
            this.tbInVendor.TabIndex = 1;
            // 
            // tbInId
            // 
            this.tbInId.Enabled = false;
            this.tbInId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInId.Location = new System.Drawing.Point(295, 19);
            this.tbInId.Name = "tbInId";
            this.tbInId.Size = new System.Drawing.Size(188, 28);
            this.tbInId.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(22, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Описание неисправности";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(22, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Дата поступления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(22, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Стоимость ремонта";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(22, 171);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(214, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "Страна производства";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(22, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Наработка в годах";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Производитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(557, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Заказчик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тип изделия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(557, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия И.О. мастера";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заказа на ремонт";
            // 
            // pbInPicture
            // 
            this.pbInPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInPicture.Image = global::Teleatel_e.Properties.Resources.no_image1;
            this.pbInPicture.Location = new System.Drawing.Point(562, 141);
            this.pbInPicture.Name = "pbInPicture";
            this.pbInPicture.Size = new System.Drawing.Size(636, 337);
            this.pbInPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInPicture.TabIndex = 3;
            this.pbInPicture.TabStop = false;
            // 
            // OutTab
            // 
            this.OutTab.Controls.Add(this.tbOutEqType);
            this.OutTab.Controls.Add(this.tbOutCstmrName);
            this.OutTab.Controls.Add(this.tnOutCstmrFio);
            this.OutTab.Controls.Add(this.tbOutMasterFio);
            this.OutTab.Controls.Add(this.rtbOutComment);
            this.OutTab.Controls.Add(this.btnTakeOut);
            this.OutTab.Controls.Add(this.pbOutPicture);
            this.OutTab.Controls.Add(this.tbOutGuarantee);
            this.OutTab.Controls.Add(this.tbOutDateStop);
            this.OutTab.Controls.Add(this.tbOutDateStart);
            this.OutTab.Controls.Add(this.tbOutSummWithDiscont);
            this.OutTab.Controls.Add(this.tbOutDiscontPercent);
            this.OutTab.Controls.Add(this.tbOutSumma);
            this.OutTab.Controls.Add(this.tbOutAge);
            this.OutTab.Controls.Add(this.tbOutVendor);
            this.OutTab.Controls.Add(this.tbOrderId);
            this.OutTab.Controls.Add(this.label10);
            this.OutTab.Controls.Add(this.label21);
            this.OutTab.Controls.Add(this.label24);
            this.OutTab.Controls.Add(this.label20);
            this.OutTab.Controls.Add(this.label23);
            this.OutTab.Controls.Add(this.label11);
            this.OutTab.Controls.Add(this.label12);
            this.OutTab.Controls.Add(this.label13);
            this.OutTab.Controls.Add(this.label14);
            this.OutTab.Controls.Add(this.label22);
            this.OutTab.Controls.Add(this.label15);
            this.OutTab.Controls.Add(this.label16);
            this.OutTab.Controls.Add(this.label17);
            this.OutTab.Controls.Add(this.label18);
            this.OutTab.Location = new System.Drawing.Point(4, 29);
            this.OutTab.Name = "OutTab";
            this.OutTab.Padding = new System.Windows.Forms.Padding(3);
            this.OutTab.Size = new System.Drawing.Size(1239, 558);
            this.OutTab.TabIndex = 2;
            this.OutTab.Text = "Выдать из ремонта";
            this.OutTab.UseVisualStyleBackColor = true;
            // 
            // tbOutEqType
            // 
            this.tbOutEqType.Enabled = false;
            this.tbOutEqType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutEqType.Location = new System.Drawing.Point(304, 66);
            this.tbOutEqType.Name = "tbOutEqType";
            this.tbOutEqType.Size = new System.Drawing.Size(188, 28);
            this.tbOutEqType.TabIndex = 28;
            // 
            // tbOutCstmrName
            // 
            this.tbOutCstmrName.Enabled = false;
            this.tbOutCstmrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutCstmrName.Location = new System.Drawing.Point(839, 110);
            this.tbOutCstmrName.Name = "tbOutCstmrName";
            this.tbOutCstmrName.Size = new System.Drawing.Size(368, 28);
            this.tbOutCstmrName.TabIndex = 27;
            // 
            // tnOutCstmrFio
            // 
            this.tnOutCstmrFio.Enabled = false;
            this.tnOutCstmrFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tnOutCstmrFio.Location = new System.Drawing.Point(839, 73);
            this.tnOutCstmrFio.Name = "tnOutCstmrFio";
            this.tnOutCstmrFio.Size = new System.Drawing.Size(368, 28);
            this.tnOutCstmrFio.TabIndex = 27;
            // 
            // tbOutMasterFio
            // 
            this.tbOutMasterFio.Enabled = false;
            this.tbOutMasterFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutMasterFio.Location = new System.Drawing.Point(839, 32);
            this.tbOutMasterFio.Name = "tbOutMasterFio";
            this.tbOutMasterFio.Size = new System.Drawing.Size(368, 28);
            this.tbOutMasterFio.TabIndex = 26;
            // 
            // rtbOutComment
            // 
            this.rtbOutComment.Location = new System.Drawing.Point(36, 400);
            this.rtbOutComment.Name = "rtbOutComment";
            this.rtbOutComment.Size = new System.Drawing.Size(456, 77);
            this.rtbOutComment.TabIndex = 25;
            this.rtbOutComment.Text = "";
            // 
            // btnTakeOut
            // 
            this.btnTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTakeOut.Location = new System.Drawing.Point(36, 482);
            this.btnTakeOut.Name = "btnTakeOut";
            this.btnTakeOut.Size = new System.Drawing.Size(456, 45);
            this.btnTakeOut.TabIndex = 24;
            this.btnTakeOut.Text = "Выдать";
            this.btnTakeOut.UseVisualStyleBackColor = true;
            this.btnTakeOut.Click += new System.EventHandler(this.btnTakeOut_Click);
            // 
            // pbOutPicture
            // 
            this.pbOutPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutPicture.Image = global::Teleatel_e.Properties.Resources.no_image1;
            this.pbOutPicture.Location = new System.Drawing.Point(571, 154);
            this.pbOutPicture.Name = "pbOutPicture";
            this.pbOutPicture.Size = new System.Drawing.Size(636, 373);
            this.pbOutPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOutPicture.TabIndex = 23;
            this.pbOutPicture.TabStop = false;
            // 
            // tbOutGuarantee
            // 
            this.tbOutGuarantee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutGuarantee.Location = new System.Drawing.Point(304, 345);
            this.tbOutGuarantee.Name = "tbOutGuarantee";
            this.tbOutGuarantee.Size = new System.Drawing.Size(188, 28);
            this.tbOutGuarantee.TabIndex = 17;
            // 
            // tbOutDateStop
            // 
            this.tbOutDateStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutDateStop.Location = new System.Drawing.Point(304, 311);
            this.tbOutDateStop.Name = "tbOutDateStop";
            this.tbOutDateStop.Size = new System.Drawing.Size(188, 28);
            this.tbOutDateStop.TabIndex = 17;
            // 
            // tbOutDateStart
            // 
            this.tbOutDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutDateStart.Location = new System.Drawing.Point(304, 276);
            this.tbOutDateStart.Name = "tbOutDateStart";
            this.tbOutDateStart.Size = new System.Drawing.Size(188, 28);
            this.tbOutDateStart.TabIndex = 17;
            // 
            // tbOutSummWithDiscont
            // 
            this.tbOutSummWithDiscont.Enabled = false;
            this.tbOutSummWithDiscont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutSummWithDiscont.Location = new System.Drawing.Point(304, 242);
            this.tbOutSummWithDiscont.Name = "tbOutSummWithDiscont";
            this.tbOutSummWithDiscont.Size = new System.Drawing.Size(188, 28);
            this.tbOutSummWithDiscont.TabIndex = 16;
            // 
            // tbOutDiscontPercent
            // 
            this.tbOutDiscontPercent.Enabled = false;
            this.tbOutDiscontPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutDiscontPercent.Location = new System.Drawing.Point(304, 206);
            this.tbOutDiscontPercent.Name = "tbOutDiscontPercent";
            this.tbOutDiscontPercent.Size = new System.Drawing.Size(188, 28);
            this.tbOutDiscontPercent.TabIndex = 16;
            // 
            // tbOutSumma
            // 
            this.tbOutSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutSumma.Location = new System.Drawing.Point(304, 172);
            this.tbOutSumma.Name = "tbOutSumma";
            this.tbOutSumma.Size = new System.Drawing.Size(188, 28);
            this.tbOutSumma.TabIndex = 16;
            this.tbOutSumma.Text = "0,00";
            this.tbOutSumma.Enter += new System.EventHandler(this.tbOutSumma_Enter);
            this.tbOutSumma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOutSumma_KeyPress);
            this.tbOutSumma.Leave += new System.EventHandler(this.tbOutSumma_Leave);
            // 
            // tbOutAge
            // 
            this.tbOutAge.Enabled = false;
            this.tbOutAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutAge.Location = new System.Drawing.Point(304, 137);
            this.tbOutAge.Name = "tbOutAge";
            this.tbOutAge.Size = new System.Drawing.Size(188, 28);
            this.tbOutAge.TabIndex = 19;
            // 
            // tbOutVendor
            // 
            this.tbOutVendor.Enabled = false;
            this.tbOutVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutVendor.Location = new System.Drawing.Point(304, 101);
            this.tbOutVendor.Name = "tbOutVendor";
            this.tbOutVendor.Size = new System.Drawing.Size(188, 28);
            this.tbOutVendor.TabIndex = 15;
            // 
            // tbOrderId
            // 
            this.tbOrderId.Enabled = false;
            this.tbOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOrderId.Location = new System.Drawing.Point(304, 32);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(188, 28);
            this.tbOrderId.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(31, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Описание ремонта";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(31, 345);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(164, 25);
            this.label21.TabIndex = 11;
            this.label21.Text = "Гарантия (дней)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(31, 242);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(224, 25);
            this.label24.TabIndex = 10;
            this.label24.Text = "Всего с учетом скидки";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(31, 311);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(134, 25);
            this.label20.TabIndex = 11;
            this.label20.Text = "Дата выдачи";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(31, 206);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 25);
            this.label23.TabIndex = 10;
            this.label23.Text = "Скидка, %";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(31, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Дата поступления";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(31, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Стоимость ремонта";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(31, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 25);
            this.label13.TabIndex = 9;
            this.label13.Text = "Наработка в годах";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(31, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "Производитель";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(566, 110);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(232, 25);
            this.label22.TabIndex = 7;
            this.label22.Text = "Организация заказчика";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(566, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 25);
            this.label15.TabIndex = 7;
            this.label15.Text = "Заказчик";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(31, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 25);
            this.label16.TabIndex = 6;
            this.label16.Text = "Тип изделия";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(566, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(233, 25);
            this.label17.TabIndex = 13;
            this.label17.Text = "Фамилия И.О. мастера";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(31, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(246, 25);
            this.label18.TabIndex = 5;
            this.label18.Text = "Номер заказа на ремонт";
            // 
            // InOutArmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 606);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InOutArmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АРМ Приема/Выдачи";
            this.Load += new System.EventHandler(this.InOutArmForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.InOutTabCtrl.ResumeLayout(false);
            this.ListTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvIncompOrder)).EndInit();
            this.InTab.ResumeLayout(false);
            this.InTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInPicture)).EndInit();
            this.OutTab.ResumeLayout(false);
            this.OutTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl InOutTabCtrl;
        private System.Windows.Forms.TabPage ListTab;
        private System.Windows.Forms.TabPage InTab;
        private System.Windows.Forms.TabPage OutTab;
        private System.Windows.Forms.DataGridView gvIncompOrder;
        private System.Windows.Forms.Button btnTakeIn;
        private System.Windows.Forms.PictureBox pbInPicture;
        private System.Windows.Forms.ComboBox cbInEqType;
        private System.Windows.Forms.ComboBox cbInCustomerFio;
        private System.Windows.Forms.ComboBox cbInMasterFio;
        private System.Windows.Forms.TextBox tbInComment;
        private System.Windows.Forms.TextBox tbInDateStart;
        private System.Windows.Forms.TextBox tbInSumma;
        private System.Windows.Forms.TextBox tbInAge;
        private System.Windows.Forms.TextBox tbInVendor;
        private System.Windows.Forms.TextBox tbInId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTakeOut;
        private System.Windows.Forms.PictureBox pbOutPicture;
        private System.Windows.Forms.TextBox tbOutDateStart;
        private System.Windows.Forms.TextBox tbOutSumma;
        private System.Windows.Forms.TextBox tbOutAge;
        private System.Windows.Forms.TextBox tbOutVendor;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbInCountry;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox rtbOutComment;
        private System.Windows.Forms.TextBox tbOutGuarantee;
        private System.Windows.Forms.TextBox tbOutDateStop;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbOutCstmrName;
        private System.Windows.Forms.TextBox tnOutCstmrFio;
        private System.Windows.Forms.TextBox tbOutMasterFio;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbOutEqType;
        private System.Windows.Forms.TextBox tbOutSummWithDiscont;
        private System.Windows.Forms.TextBox tbOutDiscontPercent;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnAddPicture;
    }
}