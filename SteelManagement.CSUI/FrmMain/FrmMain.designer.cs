﻿namespace SteelManagement.CSUI.FrmMain
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.cbCorporation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbSupplier = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbProject = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.lbVisaInfoCount = new System.Windows.Forms.Label();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btnSteelInfoManage = new DevComponents.DotNetBar.ButtonItem();
            this.btnPurchaseInfoManage = new DevComponents.DotNetBar.ButtonItem();
            this.btnSaleInfoManage = new DevComponents.DotNetBar.ButtonItem();
            this.btnPurchaseBillManage = new DevComponents.DotNetBar.ButtonItem();
            this.btnSaleBillManage = new DevComponents.DotNetBar.ButtonItem();
            this.btnProjectBillManage = new DevComponents.DotNetBar.ButtonItem();
            this.btnSupplierBillMange = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.btnUserManage = new DevComponents.DotNetBar.ButtonItem();
            this.btnChangeLoginUser = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnSystemSettings = new DevComponents.DotNetBar.ButtonItem();
            this.btnPersonalCount = new DevComponents.DotNetBar.ButtonItem();
            this.btnCommisionMoneyManage = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.btnClientManage = new DevComponents.DotNetBar.ButtonItem();
            this.btnConsulateManage = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.btnVisaRequestPayoutManage = new DevComponents.DotNetBar.ButtonItem();
            this.btnAppAllManage = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel5 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonTabItem3 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem4 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem5 = new DevComponents.DotNetBar.RibbonTabItem();
            this.btnVip = new DevComponents.DotNetBar.ButtonItem();
            this.btnUsers = new DevComponents.DotNetBar.ButtonItem();
            this.tabMain = new DevComponents.DotNetBar.TabControl();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMCloseOther = new System.Windows.Forms.ToolStripMenuItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnFrmGaoPaiManage = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Controls.Add(this.ribbonPanel4);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel5);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem3,
            this.ribbonTabItem4,
            this.ribbonTabItem1,
            this.ribbonTabItem2,
            this.ribbonTabItem5});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.Size = new System.Drawing.Size(1284, 89);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 1;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.cbCorporation);
            this.ribbonPanel3.Controls.Add(this.cbSupplier);
            this.ribbonPanel3.Controls.Add(this.labelX1);
            this.ribbonPanel3.Controls.Add(this.cbProject);
            this.ribbonPanel3.Controls.Add(this.labelX3);
            this.ribbonPanel3.Controls.Add(this.labelX15);
            this.ribbonPanel3.Controls.Add(this.lbVisaInfoCount);
            this.ribbonPanel3.Controls.Add(this.ribbonBar2);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(1284, 61);
            // 
            // 
            // 
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 3;
            // 
            // cbCorporation
            // 
            this.cbCorporation.DisplayMember = "Text";
            this.cbCorporation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCorporation.FormattingEnabled = true;
            this.cbCorporation.ItemHeight = 15;
            this.cbCorporation.Location = new System.Drawing.Point(680, 18);
            this.cbCorporation.Name = "cbCorporation";
            this.cbCorporation.Size = new System.Drawing.Size(79, 21);
            this.cbCorporation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCorporation.TabIndex = 88;
            // 
            // cbSupplier
            // 
            this.cbSupplier.DisplayMember = "Text";
            this.cbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.ItemHeight = 15;
            this.cbSupplier.Location = new System.Drawing.Point(945, 18);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(87, 21);
            this.cbSupplier.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbSupplier.TabIndex = 92;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(889, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(61, 21);
            this.labelX1.TabIndex = 91;
            this.labelX1.Text = "供应商:";
            // 
            // cbProject
            // 
            this.cbProject.DisplayMember = "Text";
            this.cbProject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.ItemHeight = 15;
            this.cbProject.Location = new System.Drawing.Point(802, 18);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(79, 21);
            this.cbProject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbProject.TabIndex = 90;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(766, 18);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(46, 21);
            this.labelX3.TabIndex = 89;
            this.labelX3.Text = "项目:";
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(645, 18);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(46, 21);
            this.labelX15.TabIndex = 87;
            this.labelX15.Text = "公司:";
            // 
            // lbVisaInfoCount
            // 
            this.lbVisaInfoCount.BackColor = System.Drawing.Color.Transparent;
            this.lbVisaInfoCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbVisaInfoCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVisaInfoCount.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbVisaInfoCount.Location = new System.Drawing.Point(1147, 0);
            this.lbVisaInfoCount.Name = "lbVisaInfoCount";
            this.lbVisaInfoCount.Size = new System.Drawing.Size(134, 58);
            this.lbVisaInfoCount.TabIndex = 2;
            this.lbVisaInfoCount.Text = "test string";
            this.lbVisaInfoCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbVisaInfoCount.Visible = false;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSteelInfoManage,
            this.btnPurchaseInfoManage,
            this.btnSaleInfoManage,
            this.btnPurchaseBillManage,
            this.btnSaleBillManage,
            this.btnProjectBillManage,
            this.btnSupplierBillMange});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(1053, 58);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 0;
            this.ribbonBar2.Text = "ribbonBar2";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.TitleVisible = false;
            // 
            // btnSteelInfoManage
            // 
            this.btnSteelInfoManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnSteelInfoManage.Icon")));
            this.btnSteelInfoManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnSteelInfoManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSteelInfoManage.Name = "btnSteelInfoManage";
            this.btnSteelInfoManage.SubItemsExpandWidth = 14;
            this.btnSteelInfoManage.Text = "钢材信息管理";
            // 
            // btnPurchaseInfoManage
            // 
            this.btnPurchaseInfoManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnPurchaseInfoManage.Icon")));
            this.btnPurchaseInfoManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnPurchaseInfoManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPurchaseInfoManage.Name = "btnPurchaseInfoManage";
            this.btnPurchaseInfoManage.SubItemsExpandWidth = 14;
            this.btnPurchaseInfoManage.Text = "采购信息管理";
            // 
            // btnSaleInfoManage
            // 
            this.btnSaleInfoManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnSaleInfoManage.Icon")));
            this.btnSaleInfoManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnSaleInfoManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSaleInfoManage.Name = "btnSaleInfoManage";
            this.btnSaleInfoManage.SubItemsExpandWidth = 14;
            this.btnSaleInfoManage.Text = "销售信息管理";
            // 
            // btnPurchaseBillManage
            // 
            this.btnPurchaseBillManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnPurchaseBillManage.Icon")));
            this.btnPurchaseBillManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnPurchaseBillManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPurchaseBillManage.Name = "btnPurchaseBillManage";
            this.btnPurchaseBillManage.SubItemsExpandWidth = 14;
            this.btnPurchaseBillManage.Text = "采购款项管理";
            // 
            // btnSaleBillManage
            // 
            this.btnSaleBillManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnSaleBillManage.Icon")));
            this.btnSaleBillManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnSaleBillManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSaleBillManage.Name = "btnSaleBillManage";
            this.btnSaleBillManage.SubItemsExpandWidth = 14;
            this.btnSaleBillManage.Text = "销售款项管理";
            this.btnSaleBillManage.Click += new System.EventHandler(this.btnReceiptInfoManage_Click);
            // 
            // btnProjectBillManage
            // 
            this.btnProjectBillManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnProjectBillManage.Icon")));
            this.btnProjectBillManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnProjectBillManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnProjectBillManage.Name = "btnProjectBillManage";
            this.btnProjectBillManage.SubItemsExpandWidth = 14;
            this.btnProjectBillManage.Text = "销售款项汇总";
            // 
            // btnSupplierBillMange
            // 
            this.btnSupplierBillMange.Icon = ((System.Drawing.Icon)(resources.GetObject("btnSupplierBillMange.Icon")));
            this.btnSupplierBillMange.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnSupplierBillMange.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSupplierBillMange.Name = "btnSupplierBillMange";
            this.btnSupplierBillMange.SubItemsExpandWidth = 14;
            this.btnSupplierBillMange.Text = "供应商款项汇总";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel4.Controls.Add(this.ribbonBar5);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(1284, 61);
            // 
            // 
            // 
            this.ribbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel4.TabIndex = 8;
            this.ribbonPanel4.Visible = false;
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.ContainerControlProcessDialogKey = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.DragDropSupport = true;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUserManage,
            this.btnChangeLoginUser});
            this.ribbonBar5.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(850, 58);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar5.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnUserManage
            // 
            this.btnUserManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnUserManage.Icon")));
            this.btnUserManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnUserManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.SubItemsExpandWidth = 14;
            this.btnUserManage.Text = "用户管理";
            // 
            // btnChangeLoginUser
            // 
            this.btnChangeLoginUser.Icon = ((System.Drawing.Icon)(resources.GetObject("btnChangeLoginUser.Icon")));
            this.btnChangeLoginUser.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnChangeLoginUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnChangeLoginUser.Name = "btnChangeLoginUser";
            this.btnChangeLoginUser.SubItemsExpandWidth = 14;
            this.btnChangeLoginUser.Text = "切换用户";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1284, 61);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 6;
            this.ribbonPanel1.Visible = false;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSystemSettings,
            this.btnPersonalCount,
            this.btnCommisionMoneyManage});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(282, 58);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSystemSettings
            // 
            this.btnSystemSettings.Icon = ((System.Drawing.Icon)(resources.GetObject("btnSystemSettings.Icon")));
            this.btnSystemSettings.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnSystemSettings.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSystemSettings.Name = "btnSystemSettings";
            this.btnSystemSettings.SubItemsExpandWidth = 14;
            this.btnSystemSettings.Text = "系统设置";
            // 
            // btnPersonalCount
            // 
            this.btnPersonalCount.Icon = ((System.Drawing.Icon)(resources.GetObject("btnPersonalCount.Icon")));
            this.btnPersonalCount.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnPersonalCount.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPersonalCount.Name = "btnPersonalCount";
            this.btnPersonalCount.SubItemsExpandWidth = 14;
            this.btnPersonalCount.Text = "个人工作量统计";
            this.btnPersonalCount.Visible = false;
            // 
            // btnCommisionMoneyManage
            // 
            this.btnCommisionMoneyManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnCommisionMoneyManage.Icon")));
            this.btnCommisionMoneyManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnCommisionMoneyManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCommisionMoneyManage.Name = "btnCommisionMoneyManage";
            this.btnCommisionMoneyManage.SubItemsExpandWidth = 14;
            this.btnCommisionMoneyManage.Text = "工作提成管理";
            this.btnCommisionMoneyManage.Visible = false;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar4);
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1284, 61);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 7;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.DragDropSupport = true;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClientManage,
            this.btnConsulateManage});
            this.ribbonBar4.Location = new System.Drawing.Point(172, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(182, 58);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar4.TabIndex = 1;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnClientManage
            // 
            this.btnClientManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnClientManage.Icon")));
            this.btnClientManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnClientManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClientManage.Name = "btnClientManage";
            this.btnClientManage.SubItemsExpandWidth = 14;
            this.btnClientManage.Text = "客户收费管理";
            // 
            // btnConsulateManage
            // 
            this.btnConsulateManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnConsulateManage.Icon")));
            this.btnConsulateManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnConsulateManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnConsulateManage.Name = "btnConsulateManage";
            this.btnConsulateManage.SubItemsExpandWidth = 14;
            this.btnConsulateManage.Text = "领馆收费管理";
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.DragDropSupport = true;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnVisaRequestPayoutManage,
            this.btnAppAllManage});
            this.ribbonBar3.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(169, 58);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnVisaRequestPayoutManage
            // 
            this.btnVisaRequestPayoutManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVisaRequestPayoutManage.Icon")));
            this.btnVisaRequestPayoutManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnVisaRequestPayoutManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVisaRequestPayoutManage.Name = "btnVisaRequestPayoutManage";
            this.btnVisaRequestPayoutManage.SubItemsExpandWidth = 14;
            this.btnVisaRequestPayoutManage.Text = "签证请款管理";
            // 
            // btnAppAllManage
            // 
            this.btnAppAllManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnAppAllManage.Icon")));
            this.btnAppAllManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnAppAllManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAppAllManage.Name = "btnAppAllManage";
            this.btnAppAllManage.SubItemsExpandWidth = 14;
            this.btnAppAllManage.Text = "待审批请款";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel5.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel5.Size = new System.Drawing.Size(1284, 61);
            // 
            // 
            // 
            this.ribbonPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel5.TabIndex = 5;
            this.ribbonPanel5.Visible = false;
            // 
            // ribbonTabItem3
            // 
            this.ribbonTabItem3.Checked = true;
            this.ribbonTabItem3.Name = "ribbonTabItem3";
            this.ribbonTabItem3.Panel = this.ribbonPanel3;
            this.ribbonTabItem3.Text = "信息管理";
            // 
            // ribbonTabItem4
            // 
            this.ribbonTabItem4.Name = "ribbonTabItem4";
            this.ribbonTabItem4.Panel = this.ribbonPanel4;
            this.ribbonTabItem4.Text = "用户管理";
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "系统设置";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "财务管理";
            this.ribbonTabItem2.Visible = false;
            // 
            // ribbonTabItem5
            // 
            this.ribbonTabItem5.Name = "ribbonTabItem5";
            this.ribbonTabItem5.Panel = this.ribbonPanel5;
            this.ribbonTabItem5.Text = "关于我们";
            // 
            // btnVip
            // 
            this.btnVip.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnVip.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVip.Name = "btnVip";
            this.btnVip.SubItemsExpandWidth = 14;
            this.btnVip.Text = "会员管理";
            // 
            // btnUsers
            // 
            this.btnUsers.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnUsers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.SubItemsExpandWidth = 14;
            this.btnUsers.Text = "员工管理";
            // 
            // tabMain
            // 
            this.tabMain.CanReorderTabs = true;
            this.tabMain.CloseButtonOnTabsVisible = true;
            this.tabMain.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 89);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabMain.SelectedTabIndex = -1;
            this.tabMain.Size = new System.Drawing.Size(1284, 622);
            this.tabMain.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock;
            this.tabMain.TabIndex = 5;
            this.tabMain.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabMain.Text = " ";
            this.tabMain.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(this.tabMain_TabItemClose);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMCloseAll,
            this.btnMCloseOther});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(125, 48);
            // 
            // btnMCloseAll
            // 
            this.btnMCloseAll.Name = "btnMCloseAll";
            this.btnMCloseAll.Size = new System.Drawing.Size(124, 22);
            this.btnMCloseAll.Text = "全部关闭";
            this.btnMCloseAll.Click += new System.EventHandler(this.btnMCloseAll_Click);
            // 
            // btnMCloseOther
            // 
            this.btnMCloseOther.Name = "btnMCloseOther";
            this.btnMCloseOther.Size = new System.Drawing.Size(124, 22);
            this.btnMCloseOther.Text = "关闭其它";
            this.btnMCloseOther.Click += new System.EventHandler(this.btnMCloseOther_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(42))))));
            // 
            // btnFrmGaoPaiManage
            // 
            this.btnFrmGaoPaiManage.Icon = ((System.Drawing.Icon)(resources.GetObject("btnFrmGaoPaiManage.Icon")));
            this.btnFrmGaoPaiManage.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.btnFrmGaoPaiManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFrmGaoPaiManage.Name = "btnFrmGaoPaiManage";
            this.btnFrmGaoPaiManage.SubItemsExpandWidth = 14;
            this.btnFrmGaoPaiManage.Text = "高排图像管理";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "东瀛假日:签证自动扫描识别系统V2.7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanel4.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnSaleInfoManage;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel5;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem3;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem5;
        private DevComponents.DotNetBar.ButtonItem btnVip;
        private DevComponents.DotNetBar.ButtonItem btnUsers;
        private DevComponents.DotNetBar.TabControl tabMain;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem btnMCloseAll;
        private System.Windows.Forms.ToolStripMenuItem btnMCloseOther;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonItem btnPurchaseInfoManage;
        private DevComponents.DotNetBar.ButtonItem btnSteelInfoManage;
        private DevComponents.DotNetBar.ButtonItem btnFrmGaoPaiManage;
        private System.Windows.Forms.Label lbVisaInfoCount;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnSystemSettings;
        private DevComponents.DotNetBar.ButtonItem btnPersonalCount;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem btnVisaRequestPayoutManage;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem btnClientManage;
        private DevComponents.DotNetBar.ButtonItem btnConsulateManage;
        private DevComponents.DotNetBar.ButtonItem btnCommisionMoneyManage;
        private DevComponents.DotNetBar.ButtonItem btnAppAllManage;
        private DevComponents.DotNetBar.ButtonItem btnSaleBillManage;
        private DevComponents.DotNetBar.ButtonItem btnProjectBillManage;
        private DevComponents.DotNetBar.ButtonItem btnPurchaseBillManage;
        private DevComponents.DotNetBar.ButtonItem btnSupplierBillMange;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem4;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.ButtonItem btnUserManage;
        private DevComponents.DotNetBar.ButtonItem btnChangeLoginUser;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX15;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cbSupplier;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cbProject;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cbCorporation;
    }
}