namespace SteelManagement.CSUI.FrmSub
{
    partial class FrmAddAuthUser
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
            PresentationControls.CheckBoxProperties checkBoxProperties2 = new PresentationControls.CheckBoxProperties();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnSupplierBillMange = new System.Windows.Forms.CheckBox();
            this.btnProjectBillManage = new System.Windows.Forms.CheckBox();
            this.btnPurchaseBillManage = new System.Windows.Forms.CheckBox();
            this.btnSaleInfoManage = new System.Windows.Forms.CheckBox();
            this.btnSaleBillManage = new System.Windows.Forms.CheckBox();
            this.btnPurchaseInfoManage = new System.Windows.Forms.CheckBox();
            this.btnSteelInfoManage = new System.Windows.Forms.CheckBox();
            this.txtUserMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtAccount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnTyper = new System.Windows.Forms.RadioButton();
            this.rbtnChecker = new System.Windows.Forms.RadioButton();
            this.chkProjects = new PresentationControls.CheckBoxComboBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.panelBasicInfo = new System.Windows.Forms.Panel();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.panelPrivilege = new System.Windows.Forms.Panel();
            this.panelProjectInfo = new System.Windows.Forms.Panel();
            this.panelEx1.SuspendLayout();
            this.panelBasicInfo.SuspendLayout();
            this.panelPrivilege.SuspendLayout();
            this.panelProjectInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panelProjectInfo);
            this.panelEx1.Controls.Add(this.panelPrivilege);
            this.panelEx1.Controls.Add(this.panelBasicInfo);
            this.panelEx1.Controls.Add(this.btnCancel);
            this.panelEx1.Controls.Add(this.btnOK);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(287, 301);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.ForeColor = System.Drawing.Color.Violet;
            this.labelX5.Location = new System.Drawing.Point(5, 0);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(86, 25);
            this.labelX5.TabIndex = 109;
            this.labelX5.Text = "用户类型:";
            this.labelX5.WordWrap = true;
            // 
            // btnSupplierBillMange
            // 
            this.btnSupplierBillMange.AutoSize = true;
            this.btnSupplierBillMange.Checked = true;
            this.btnSupplierBillMange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSupplierBillMange.Location = new System.Drawing.Point(162, 73);
            this.btnSupplierBillMange.Name = "btnSupplierBillMange";
            this.btnSupplierBillMange.Size = new System.Drawing.Size(108, 16);
            this.btnSupplierBillMange.TabIndex = 108;
            this.btnSupplierBillMange.Text = "供应商款项汇总";
            this.btnSupplierBillMange.UseVisualStyleBackColor = true;
            // 
            // btnProjectBillManage
            // 
            this.btnProjectBillManage.AutoSize = true;
            this.btnProjectBillManage.Checked = true;
            this.btnProjectBillManage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnProjectBillManage.Location = new System.Drawing.Point(162, 51);
            this.btnProjectBillManage.Name = "btnProjectBillManage";
            this.btnProjectBillManage.Size = new System.Drawing.Size(96, 16);
            this.btnProjectBillManage.TabIndex = 107;
            this.btnProjectBillManage.Text = "销售款项汇总";
            this.btnProjectBillManage.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseBillManage
            // 
            this.btnPurchaseBillManage.AutoSize = true;
            this.btnPurchaseBillManage.Checked = true;
            this.btnPurchaseBillManage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnPurchaseBillManage.Location = new System.Drawing.Point(84, 51);
            this.btnPurchaseBillManage.Name = "btnPurchaseBillManage";
            this.btnPurchaseBillManage.Size = new System.Drawing.Size(72, 16);
            this.btnPurchaseBillManage.TabIndex = 106;
            this.btnPurchaseBillManage.Text = "采购款项";
            this.btnPurchaseBillManage.UseVisualStyleBackColor = true;
            // 
            // btnSaleInfoManage
            // 
            this.btnSaleInfoManage.AutoSize = true;
            this.btnSaleInfoManage.Checked = true;
            this.btnSaleInfoManage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSaleInfoManage.Location = new System.Drawing.Point(6, 73);
            this.btnSaleInfoManage.Name = "btnSaleInfoManage";
            this.btnSaleInfoManage.Size = new System.Drawing.Size(72, 16);
            this.btnSaleInfoManage.TabIndex = 105;
            this.btnSaleInfoManage.Text = "销售信息";
            this.btnSaleInfoManage.UseVisualStyleBackColor = true;
            // 
            // btnSaleBillManage
            // 
            this.btnSaleBillManage.AutoSize = true;
            this.btnSaleBillManage.Checked = true;
            this.btnSaleBillManage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSaleBillManage.Location = new System.Drawing.Point(84, 73);
            this.btnSaleBillManage.Name = "btnSaleBillManage";
            this.btnSaleBillManage.Size = new System.Drawing.Size(72, 16);
            this.btnSaleBillManage.TabIndex = 104;
            this.btnSaleBillManage.Text = "销售款项";
            this.btnSaleBillManage.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseInfoManage
            // 
            this.btnPurchaseInfoManage.AutoSize = true;
            this.btnPurchaseInfoManage.Checked = true;
            this.btnPurchaseInfoManage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnPurchaseInfoManage.Location = new System.Drawing.Point(6, 51);
            this.btnPurchaseInfoManage.Name = "btnPurchaseInfoManage";
            this.btnPurchaseInfoManage.Size = new System.Drawing.Size(72, 16);
            this.btnPurchaseInfoManage.TabIndex = 103;
            this.btnPurchaseInfoManage.Text = "采购信息";
            this.btnPurchaseInfoManage.UseVisualStyleBackColor = true;
            // 
            // btnSteelInfoManage
            // 
            this.btnSteelInfoManage.AutoSize = true;
            this.btnSteelInfoManage.Checked = true;
            this.btnSteelInfoManage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSteelInfoManage.Location = new System.Drawing.Point(84, 29);
            this.btnSteelInfoManage.Name = "btnSteelInfoManage";
            this.btnSteelInfoManage.Size = new System.Drawing.Size(72, 16);
            this.btnSteelInfoManage.TabIndex = 103;
            this.btnSteelInfoManage.Text = "钢材信息";
            this.btnSteelInfoManage.UseVisualStyleBackColor = true;
            // 
            // txtUserMobile
            // 
            // 
            // 
            // 
            this.txtUserMobile.Border.Class = "TextBoxBorder";
            this.txtUserMobile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserMobile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.txtUserMobile.Location = new System.Drawing.Point(82, 90);
            this.txtUserMobile.Name = "txtUserMobile";
            this.txtUserMobile.Size = new System.Drawing.Size(107, 23);
            this.txtUserMobile.TabIndex = 102;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.labelX4.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelX4.Location = new System.Drawing.Point(15, 90);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(59, 19);
            this.labelX4.TabIndex = 101;
            this.labelX4.Text = "手机号码:";
            this.labelX4.WordWrap = true;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(82, 61);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(107, 23);
            this.txtPassword.TabIndex = 100;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.labelX3.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelX3.Location = new System.Drawing.Point(15, 61);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 19);
            this.labelX3.TabIndex = 99;
            this.labelX3.Text = "密码:";
            this.labelX3.WordWrap = true;
            // 
            // txtAccount
            // 
            // 
            // 
            // 
            this.txtAccount.Border.Class = "TextBoxBorder";
            this.txtAccount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAccount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.txtAccount.Location = new System.Drawing.Point(82, 32);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(107, 23);
            this.txtAccount.TabIndex = 98;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.labelX2.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelX2.Location = new System.Drawing.Point(15, 32);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(61, 19);
            this.labelX2.TabIndex = 97;
            this.labelX2.Text = "登陆账号:";
            this.labelX2.WordWrap = true;
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.txtUserName.Location = new System.Drawing.Point(82, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(107, 23);
            this.txtUserName.TabIndex = 96;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.labelX1.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelX1.Location = new System.Drawing.Point(15, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(61, 19);
            this.labelX1.TabIndex = 95;
            this.labelX1.Text = "用户名:";
            this.labelX1.WordWrap = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(170, 266);
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
            this.btnOK.Location = new System.Drawing.Point(51, 266);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(88, 4);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(59, 16);
            this.rbtnAdmin.TabIndex = 111;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "管理员";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            this.rbtnAdmin.CheckedChanged += new System.EventHandler(this.rbtnAdmin_CheckedChanged);
            // 
            // rbtnTyper
            // 
            this.rbtnTyper.AutoSize = true;
            this.rbtnTyper.Location = new System.Drawing.Point(148, 4);
            this.rbtnTyper.Name = "rbtnTyper";
            this.rbtnTyper.Size = new System.Drawing.Size(59, 16);
            this.rbtnTyper.TabIndex = 112;
            this.rbtnTyper.TabStop = true;
            this.rbtnTyper.Text = "录入员";
            this.rbtnTyper.UseVisualStyleBackColor = true;
            this.rbtnTyper.CheckedChanged += new System.EventHandler(this.rbtnTyper_CheckedChanged);
            // 
            // rbtnChecker
            // 
            this.rbtnChecker.AutoSize = true;
            this.rbtnChecker.Location = new System.Drawing.Point(211, 4);
            this.rbtnChecker.Name = "rbtnChecker";
            this.rbtnChecker.Size = new System.Drawing.Size(59, 16);
            this.rbtnChecker.TabIndex = 112;
            this.rbtnChecker.TabStop = true;
            this.rbtnChecker.Text = "审核员";
            this.rbtnChecker.UseVisualStyleBackColor = true;
            this.rbtnChecker.CheckedChanged += new System.EventHandler(this.rbtnChecker_CheckedChanged);
            // 
            // chkProjects
            // 
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkProjects.CheckBoxProperties = checkBoxProperties2;
            this.chkProjects.DisplayMemberSingleItem = "";
            this.chkProjects.FormattingEnabled = true;
            this.chkProjects.Location = new System.Drawing.Point(80, 3);
            this.chkProjects.Name = "chkProjects";
            this.chkProjects.Size = new System.Drawing.Size(187, 20);
            this.chkProjects.TabIndex = 113;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.labelX6.ForeColor = System.Drawing.Color.Brown;
            this.labelX6.Location = new System.Drawing.Point(3, 3);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(71, 21);
            this.labelX6.TabIndex = 114;
            this.labelX6.Text = "可审核项目:";
            this.labelX6.WordWrap = true;
            // 
            // panelBasicInfo
            // 
            this.panelBasicInfo.Controls.Add(this.txtUserName);
            this.panelBasicInfo.Controls.Add(this.labelX1);
            this.panelBasicInfo.Controls.Add(this.labelX2);
            this.panelBasicInfo.Controls.Add(this.txtAccount);
            this.panelBasicInfo.Controls.Add(this.labelX3);
            this.panelBasicInfo.Controls.Add(this.txtPassword);
            this.panelBasicInfo.Controls.Add(this.labelX4);
            this.panelBasicInfo.Controls.Add(this.txtUserMobile);
            this.panelBasicInfo.Location = new System.Drawing.Point(3, 8);
            this.panelBasicInfo.Name = "panelBasicInfo";
            this.panelBasicInfo.Size = new System.Drawing.Size(272, 120);
            this.panelBasicInfo.TabIndex = 115;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.ForeColor = System.Drawing.Color.Violet;
            this.labelX7.Location = new System.Drawing.Point(6, 22);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(72, 25);
            this.labelX7.TabIndex = 116;
            this.labelX7.Text = "可用模块:";
            this.labelX7.WordWrap = true;
            // 
            // panelPrivilege
            // 
            this.panelPrivilege.Controls.Add(this.btnProjectBillManage);
            this.panelPrivilege.Controls.Add(this.labelX7);
            this.panelPrivilege.Controls.Add(this.btnSteelInfoManage);
            this.panelPrivilege.Controls.Add(this.btnPurchaseInfoManage);
            this.panelPrivilege.Controls.Add(this.btnSaleBillManage);
            this.panelPrivilege.Controls.Add(this.btnSaleInfoManage);
            this.panelPrivilege.Controls.Add(this.rbtnChecker);
            this.panelPrivilege.Controls.Add(this.btnPurchaseBillManage);
            this.panelPrivilege.Controls.Add(this.rbtnTyper);
            this.panelPrivilege.Controls.Add(this.btnSupplierBillMange);
            this.panelPrivilege.Controls.Add(this.rbtnAdmin);
            this.panelPrivilege.Controls.Add(this.labelX5);
            this.panelPrivilege.Location = new System.Drawing.Point(3, 127);
            this.panelPrivilege.Name = "panelPrivilege";
            this.panelPrivilege.Size = new System.Drawing.Size(273, 96);
            this.panelPrivilege.TabIndex = 117;
            // 
            // panelProjectInfo
            // 
            this.panelProjectInfo.Controls.Add(this.chkProjects);
            this.panelProjectInfo.Controls.Add(this.labelX6);
            this.panelProjectInfo.Location = new System.Drawing.Point(3, 229);
            this.panelProjectInfo.Name = "panelProjectInfo";
            this.panelProjectInfo.Size = new System.Drawing.Size(274, 31);
            this.panelProjectInfo.TabIndex = 118;
            // 
            // FrmAddAuthUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 301);
            this.Controls.Add(this.panelEx1);
            this.Name = "FrmAddAuthUser";
            this.Text = "新增用户信息";
            this.Load += new System.EventHandler(this.FrmAddAuthUser_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelBasicInfo.ResumeLayout(false);
            this.panelPrivilege.ResumeLayout(false);
            this.panelPrivilege.PerformLayout();
            this.panelProjectInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccount;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserMobile;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.CheckBox btnPurchaseInfoManage;
        private System.Windows.Forms.CheckBox btnSteelInfoManage;
        private System.Windows.Forms.CheckBox btnSupplierBillMange;
        private System.Windows.Forms.CheckBox btnProjectBillManage;
        private System.Windows.Forms.CheckBox btnPurchaseBillManage;
        private System.Windows.Forms.CheckBox btnSaleInfoManage;
        private System.Windows.Forms.CheckBox btnSaleBillManage;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.RadioButton rbtnTyper;
        private System.Windows.Forms.RadioButton rbtnChecker;
        private PresentationControls.CheckBoxComboBox chkProjects;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.Panel panelBasicInfo;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.Panel panelPrivilege;
        private System.Windows.Forms.Panel panelProjectInfo;
    }
}