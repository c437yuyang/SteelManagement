namespace SteelManagement.CSUI.FrmSub
{
    partial class FrmAddReceiptInfo
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.txtReceiptNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtInvoiceNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.txtInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnUploadImage = new DevComponents.DotNetBar.ButtonX();
            this.panelLeft = new DevComponents.DotNetBar.PanelEx();
            this.btnAddFromExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.progressLoading = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.proPictureBox1 = new TravelAgency.CSUI.CustomCtrls.ProPictureBox();
            this.panelEx1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.proPictureBox1);
            this.panelEx1.Controls.Add(this.panelLeft);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(619, 188);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // txtReceiptNum
            // 
            // 
            // 
            // 
            this.txtReceiptNum.Border.Class = "TextBoxBorder";
            this.txtReceiptNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReceiptNum.Location = new System.Drawing.Point(109, 93);
            this.txtReceiptNum.Name = "txtReceiptNum";
            this.txtReceiptNum.Size = new System.Drawing.Size(107, 21);
            this.txtReceiptNum.TabIndex = 99;
            // 
            // txtInvoiceNum
            // 
            // 
            // 
            // 
            this.txtInvoiceNum.Border.Class = "TextBoxBorder";
            this.txtInvoiceNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInvoiceNum.Location = new System.Drawing.Point(109, 66);
            this.txtInvoiceNum.Name = "txtInvoiceNum";
            this.txtInvoiceNum.Size = new System.Drawing.Size(107, 21);
            this.txtInvoiceNum.TabIndex = 99;
            // 
            // labelX20
            // 
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Location = new System.Drawing.Point(22, 68);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(87, 19);
            this.labelX20.TabIndex = 98;
            this.labelX20.Text = "发票:(应收)";
            this.labelX20.WordWrap = true;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(22, 93);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(81, 23);
            this.labelX1.TabIndex = 96;
            this.labelX1.Text = "收款(实收):";
            // 
            // txtReceiptDate
            // 
            this.txtReceiptDate.CustomFormat = "yyyy/MM/dd";
            this.txtReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtReceiptDate.Location = new System.Drawing.Point(109, 39);
            this.txtReceiptDate.Name = "txtReceiptDate";
            this.txtReceiptDate.Size = new System.Drawing.Size(107, 21);
            this.txtReceiptDate.TabIndex = 87;
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(22, 39);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(87, 23);
            this.labelX15.TabIndex = 86;
            this.labelX15.Text = "收款日期:";
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.CustomFormat = "yyyy/MM/dd";
            this.txtInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtInvoiceDate.Location = new System.Drawing.Point(109, 12);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.Size = new System.Drawing.Size(107, 21);
            this.txtInvoiceDate.TabIndex = 81;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(22, 12);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(80, 23);
            this.labelX10.TabIndex = 80;
            this.labelX10.Text = "开票日期:";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(141, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Location = new System.Drawing.Point(22, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(22, 121);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(81, 23);
            this.labelX2.TabIndex = 100;
            this.labelX2.Text = "收据图片:";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUploadImage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUploadImage.Location = new System.Drawing.Point(109, 121);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(107, 23);
            this.btnUploadImage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUploadImage.TabIndex = 101;
            this.btnUploadImage.Text = "点击上传图像";
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelLeft.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelLeft.Controls.Add(this.btnAddFromExcel);
            this.panelLeft.Controls.Add(this.btnAdd);
            this.panelLeft.Controls.Add(this.btnUploadImage);
            this.panelLeft.Controls.Add(this.progressLoading);
            this.panelLeft.Controls.Add(this.labelX2);
            this.panelLeft.Controls.Add(this.txtInvoiceDate);
            this.panelLeft.Controls.Add(this.txtReceiptNum);
            this.panelLeft.Controls.Add(this.btnOK);
            this.panelLeft.Controls.Add(this.txtInvoiceNum);
            this.panelLeft.Controls.Add(this.btnCancel);
            this.panelLeft.Controls.Add(this.labelX20);
            this.panelLeft.Controls.Add(this.labelX10);
            this.panelLeft.Controls.Add(this.labelX1);
            this.panelLeft.Controls.Add(this.labelX15);
            this.panelLeft.Controls.Add(this.txtReceiptDate);
            this.panelLeft.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(248, 188);
            this.panelLeft.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelLeft.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelLeft.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelLeft.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelLeft.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelLeft.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelLeft.Style.GradientAngle = 90;
            this.panelLeft.TabIndex = 106;
            // 
            // btnAddFromExcel
            // 
            this.btnAddFromExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddFromExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddFromExcel.Location = new System.Drawing.Point(996, 6);
            this.btnAddFromExcel.Name = "btnAddFromExcel";
            this.btnAddFromExcel.Size = new System.Drawing.Size(92, 23);
            this.btnAddFromExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddFromExcel.TabIndex = 56;
            this.btnAddFromExcel.Text = "从excel导入";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(884, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "新增";
            // 
            // progressLoading
            // 
            // 
            // 
            // 
            this.progressLoading.BackgroundStyle.BackgroundImageAlpha = ((byte)(64));
            this.progressLoading.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressLoading.FocusCuesEnabled = false;
            this.progressLoading.Location = new System.Drawing.Point(833, 0);
            this.progressLoading.Name = "progressLoading";
            this.progressLoading.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.progressLoading.ProgressColor = System.Drawing.Color.YellowGreen;
            this.progressLoading.Size = new System.Drawing.Size(45, 28);
            this.progressLoading.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.progressLoading.TabIndex = 27;
            this.progressLoading.Value = 100;
            // 
            // proPictureBox1
            // 
            this.proPictureBox1.DefaultSaveFileName = null;
            this.proPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proPictureBox1.Image = null;
            this.proPictureBox1.Location = new System.Drawing.Point(248, 0);
            this.proPictureBox1.Name = "proPictureBox1";
            this.proPictureBox1.Size = new System.Drawing.Size(371, 188);
            this.proPictureBox1.TabIndex = 102;
            this.proPictureBox1.TabStop = false;
            // 
            // FrmAddReceiptInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 188);
            this.Controls.Add(this.panelEx1);
            this.Name = "FrmAddReceiptInfo";
            this.Text = "新增收据信息";
            this.Load += new System.EventHandler(this.FrmAddReceiptInfo_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private System.Windows.Forms.DateTimePicker txtInvoiceDate;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.DateTimePicker txtReceiptDate;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInvoiceNum;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.DotNetBar.Controls.TextBoxX txtReceiptNum;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnUploadImage;
        private TravelAgency.CSUI.CustomCtrls.ProPictureBox proPictureBox1;
        private DevComponents.DotNetBar.PanelEx panelLeft;
        private DevComponents.DotNetBar.ButtonX btnAddFromExcel;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.CircularProgress progressLoading;
    }
}