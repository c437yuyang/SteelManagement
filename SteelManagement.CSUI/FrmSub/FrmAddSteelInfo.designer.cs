namespace SteelManagement.CSUI.FrmSub
{
    partial class FrmAddSteelInfo
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
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtSize = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtTexture = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtProducePlace = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtPrice = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtFluctuation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtRemark = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.txtState);
            this.panelEx1.Controls.Add(this.txtRemark);
            this.panelEx1.Controls.Add(this.txtFluctuation);
            this.panelEx1.Controls.Add(this.txtPrice);
            this.panelEx1.Controls.Add(this.txtProducePlace);
            this.panelEx1.Controls.Add(this.txtTexture);
            this.panelEx1.Controls.Add(this.txtSize);
            this.panelEx1.Controls.Add(this.txtName);
            this.panelEx1.Controls.Add(this.labelX8);
            this.panelEx1.Controls.Add(this.btnCancel);
            this.panelEx1.Controls.Add(this.btnOK);
            this.panelEx1.Controls.Add(this.labelX7);
            this.panelEx1.Controls.Add(this.labelX6);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(236, 283);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(23, 212);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(87, 19);
            this.labelX8.TabIndex = 31;
            this.labelX8.Text = "状态:";
            this.labelX8.WordWrap = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(142, 249);
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
            this.btnOK.Location = new System.Drawing.Point(23, 249);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(23, 185);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(87, 19);
            this.labelX7.TabIndex = 18;
            this.labelX7.Text = "备注:";
            this.labelX7.WordWrap = true;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(23, 152);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 19;
            this.labelX6.Text = "涨跌:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(23, 123);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(81, 23);
            this.labelX5.TabIndex = 20;
            this.labelX5.Text = "价格(元/吨):";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(23, 94);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 21;
            this.labelX4.Text = "钢厂/产地:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(23, 68);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(87, 23);
            this.labelX3.TabIndex = 15;
            this.labelX3.Text = "材质:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(23, 39);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(63, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "规格:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(46, 23);
            this.labelX1.TabIndex = 17;
            this.labelX1.Text = "品名:";
            // 
            // txtName
            // 
            this.txtName.DisplayMember = "Text";
            this.txtName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtName.FormattingEnabled = true;
            this.txtName.ItemHeight = 15;
            this.txtName.Location = new System.Drawing.Point(110, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(107, 21);
            this.txtName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtName.TabIndex = 33;
            // 
            // txtSize
            // 
            this.txtSize.DisplayMember = "Text";
            this.txtSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtSize.FormattingEnabled = true;
            this.txtSize.ItemHeight = 15;
            this.txtSize.Location = new System.Drawing.Point(110, 39);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(107, 21);
            this.txtSize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtSize.TabIndex = 34;
            // 
            // txtTexture
            // 
            this.txtTexture.DisplayMember = "Text";
            this.txtTexture.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTexture.FormattingEnabled = true;
            this.txtTexture.ItemHeight = 15;
            this.txtTexture.Location = new System.Drawing.Point(110, 66);
            this.txtTexture.Name = "txtTexture";
            this.txtTexture.Size = new System.Drawing.Size(107, 21);
            this.txtTexture.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtTexture.TabIndex = 34;
            // 
            // txtProducePlace
            // 
            this.txtProducePlace.DisplayMember = "Text";
            this.txtProducePlace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtProducePlace.FormattingEnabled = true;
            this.txtProducePlace.ItemHeight = 15;
            this.txtProducePlace.Location = new System.Drawing.Point(110, 93);
            this.txtProducePlace.Name = "txtProducePlace";
            this.txtProducePlace.Size = new System.Drawing.Size(107, 21);
            this.txtProducePlace.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtProducePlace.TabIndex = 34;
            // 
            // txtPrice
            // 
            this.txtPrice.DisplayMember = "Text";
            this.txtPrice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtPrice.FormattingEnabled = true;
            this.txtPrice.ItemHeight = 15;
            this.txtPrice.Location = new System.Drawing.Point(110, 123);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(107, 21);
            this.txtPrice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtPrice.TabIndex = 34;
            // 
            // txtFluctuation
            // 
            this.txtFluctuation.DisplayMember = "Text";
            this.txtFluctuation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtFluctuation.FormattingEnabled = true;
            this.txtFluctuation.ItemHeight = 15;
            this.txtFluctuation.Location = new System.Drawing.Point(110, 154);
            this.txtFluctuation.Name = "txtFluctuation";
            this.txtFluctuation.Size = new System.Drawing.Size(107, 21);
            this.txtFluctuation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtFluctuation.TabIndex = 34;
            // 
            // txtRemark
            // 
            this.txtRemark.DisplayMember = "Text";
            this.txtRemark.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRemark.FormattingEnabled = true;
            this.txtRemark.ItemHeight = 15;
            this.txtRemark.Location = new System.Drawing.Point(110, 183);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(107, 21);
            this.txtRemark.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtRemark.TabIndex = 34;
            // 
            // txtState
            // 
            this.txtState.DisplayMember = "Text";
            this.txtState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtState.FormattingEnabled = true;
            this.txtState.ItemHeight = 15;
            this.txtState.Location = new System.Drawing.Point(110, 212);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(107, 21);
            this.txtState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtState.TabIndex = 34;
            // 
            // FrmAddSteelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 283);
            this.Controls.Add(this.panelEx1);
            this.Name = "FrmAddSteelInfo";
            this.Text = "新增钢材信息";
            this.Load += new System.EventHandler(this.FrmAddSteelInfo_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtState;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtRemark;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtFluctuation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtPrice;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtProducePlace;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtTexture;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtSize;
    }
}