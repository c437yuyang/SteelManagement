namespace SteelManagement.CSUI.FrmMain
{
    partial class FrmSupplierBillManage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Corporation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarginRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain = new DevComponents.DotNetBar.PanelEx();
            this.panelDgv = new DevComponents.DotNetBar.PanelEx();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.lbTotalCount = new DevComponents.DotNetBar.LabelItem();
            this.panelBars = new DevComponents.DotNetBar.PanelEx();
            this.panelSerachBar = new DevComponents.DotNetBar.PanelEx();
            this.btnCreateReport = new DevComponents.DotNetBar.ButtonX();
            this.cbProject = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbCorporation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.progressLoading = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.btnClearSchConditions = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnPageFirst = new DevComponents.DotNetBar.ButtonItem();
            this.btnPagePre = new DevComponents.DotNetBar.ButtonItem();
            this.btnPageNext = new DevComponents.DotNetBar.ButtonItem();
            this.btnPageLast = new DevComponents.DotNetBar.ButtonItem();
            this.cbCurPage = new DevComponents.DotNetBar.ComboBoxItem();
            this.btnGoto = new DevComponents.DotNetBar.ButtonItem();
            this.lbRecordCount = new DevComponents.DotNetBar.LabelItem();
            this.lbl = new DevComponents.DotNetBar.LabelItem();
            this.cbPageSize = new DevComponents.DotNetBar.ComboBoxItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.lbCurPage = new DevComponents.DotNetBar.LabelItem();
            this.btnGeneratePersonalReport = new DevComponents.DotNetBar.ButtonItem();
            this.cmsDgvRb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsItemRefreshState = new System.Windows.Forms.ToolStripMenuItem();
            this.人申请表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.机票报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.外领担保函ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.韩国担保函ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.韩国加急申请书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgWorkerLoadData = new System.ComponentModel.BackgroundWorker();
            this.cbSupplier = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.panelBars.SuspendLayout();
            this.panelSerachBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.cmsDgvRb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Corporation,
            this.Project,
            this.Supplier,
            this.TotalPurchase,
            this.PurchaseAmount,
            this.TotalSale,
            this.SaleAmount,
            this.MarginRate,
            this.TransportCost});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 540);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // Corporation
            // 
            this.Corporation.DataPropertyName = "Corporation";
            this.Corporation.HeaderText = "公司";
            this.Corporation.Name = "Corporation";
            // 
            // Project
            // 
            this.Project.DataPropertyName = "Project";
            this.Project.HeaderText = "项目";
            this.Project.Name = "Project";
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "供应商";
            this.Supplier.Name = "Supplier";
            // 
            // TotalPurchase
            // 
            this.TotalPurchase.DataPropertyName = "TotalPurchase";
            this.TotalPurchase.HeaderText = "购进总额";
            this.TotalPurchase.Name = "TotalPurchase";
            // 
            // PurchaseAmount
            // 
            this.PurchaseAmount.DataPropertyName = "PurchaseAmount";
            this.PurchaseAmount.HeaderText = "购进重量";
            this.PurchaseAmount.Name = "PurchaseAmount";
            // 
            // TotalSale
            // 
            this.TotalSale.DataPropertyName = "TotalSale";
            this.TotalSale.HeaderText = "销总金额";
            this.TotalSale.Name = "TotalSale";
            // 
            // SaleAmount
            // 
            this.SaleAmount.DataPropertyName = "SaleAmount";
            this.SaleAmount.HeaderText = "销售重量";
            this.SaleAmount.Name = "SaleAmount";
            // 
            // MarginRate
            // 
            this.MarginRate.HeaderText = "利润率";
            this.MarginRate.Name = "MarginRate";
            // 
            // TransportCost
            // 
            this.TransportCost.DataPropertyName = "TransportCost";
            this.TransportCost.HeaderText = "运费";
            this.TransportCost.Name = "TransportCost";
            // 
            // panelMain
            // 
            this.panelMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelMain.Controls.Add(this.panelDgv);
            this.panelMain.Controls.Add(this.panelBars);
            this.panelMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1271, 623);
            this.panelMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelMain.Style.GradientAngle = 90;
            this.panelMain.TabIndex = 23;
            // 
            // panelDgv
            // 
            this.panelDgv.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelDgv.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelDgv.Controls.Add(this.dataGridView1);
            this.panelDgv.Controls.Add(this.bar2);
            this.panelDgv.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgv.Location = new System.Drawing.Point(0, 64);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(1271, 559);
            this.panelDgv.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDgv.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelDgv.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelDgv.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelDgv.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelDgv.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelDgv.Style.GradientAngle = 90;
            this.panelDgv.TabIndex = 38;
            // 
            // bar2
            // 
            this.bar2.AntiAlias = true;
            this.bar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar2.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar2.DockTabStripHeight = 30;
            this.bar2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar2.IsMaximized = false;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbTotalCount});
            this.bar2.ItemSpacing = 5;
            this.bar2.Location = new System.Drawing.Point(0, 540);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(1271, 19);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 25;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // lbTotalCount
            // 
            this.lbTotalCount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTotalCount.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbTotalCount.Name = "lbTotalCount";
            this.lbTotalCount.Text = "--";
            // 
            // panelBars
            // 
            this.panelBars.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBars.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelBars.Controls.Add(this.panelSerachBar);
            this.panelBars.Controls.Add(this.bar1);
            this.panelBars.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelBars.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBars.Location = new System.Drawing.Point(0, 0);
            this.panelBars.Name = "panelBars";
            this.panelBars.Size = new System.Drawing.Size(1271, 64);
            this.panelBars.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBars.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBars.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBars.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBars.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBars.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBars.Style.GradientAngle = 90;
            this.panelBars.TabIndex = 34;
            // 
            // panelSerachBar
            // 
            this.panelSerachBar.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelSerachBar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelSerachBar.Controls.Add(this.cbSupplier);
            this.panelSerachBar.Controls.Add(this.labelX1);
            this.panelSerachBar.Controls.Add(this.btnCreateReport);
            this.panelSerachBar.Controls.Add(this.cbProject);
            this.panelSerachBar.Controls.Add(this.labelX3);
            this.panelSerachBar.Controls.Add(this.cbCorporation);
            this.panelSerachBar.Controls.Add(this.labelX15);
            this.panelSerachBar.Controls.Add(this.btnAdd);
            this.panelSerachBar.Controls.Add(this.progressLoading);
            this.panelSerachBar.Controls.Add(this.btnClearSchConditions);
            this.panelSerachBar.Controls.Add(this.btnSearch);
            this.panelSerachBar.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelSerachBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSerachBar.Location = new System.Drawing.Point(0, 28);
            this.panelSerachBar.Name = "panelSerachBar";
            this.panelSerachBar.Size = new System.Drawing.Size(1271, 36);
            this.panelSerachBar.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelSerachBar.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelSerachBar.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelSerachBar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelSerachBar.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelSerachBar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelSerachBar.Style.GradientAngle = 90;
            this.panelSerachBar.TabIndex = 24;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreateReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreateReport.Location = new System.Drawing.Point(699, 6);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(92, 23);
            this.btnCreateReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreateReport.TabIndex = 74;
            this.btnCreateReport.Text = "生成报表";
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // cbProject
            // 
            this.cbProject.DisplayMember = "Text";
            this.cbProject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.ItemHeight = 15;
            this.cbProject.Location = new System.Drawing.Point(169, 7);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(79, 21);
            this.cbProject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbProject.TabIndex = 51;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(133, 8);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(46, 21);
            this.labelX3.TabIndex = 50;
            this.labelX3.Text = "项目:";
            // 
            // cbCorporation
            // 
            this.cbCorporation.DisplayMember = "Text";
            this.cbCorporation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCorporation.FormattingEnabled = true;
            this.cbCorporation.ItemHeight = 15;
            this.cbCorporation.Location = new System.Drawing.Point(47, 8);
            this.cbCorporation.Name = "cbCorporation";
            this.cbCorporation.Size = new System.Drawing.Size(79, 21);
            this.cbCorporation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCorporation.TabIndex = 49;
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(12, 9);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(46, 21);
            this.labelX15.TabIndex = 48;
            this.labelX15.Text = "公司:";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(601, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "新增";
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // progressLoading
            // 
            // 
            // 
            // 
            this.progressLoading.BackgroundStyle.BackgroundImageAlpha = ((byte)(64));
            this.progressLoading.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressLoading.FocusCuesEnabled = false;
            this.progressLoading.Location = new System.Drawing.Point(797, 6);
            this.progressLoading.Name = "progressLoading";
            this.progressLoading.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.progressLoading.ProgressColor = System.Drawing.Color.YellowGreen;
            this.progressLoading.Size = new System.Drawing.Size(37, 24);
            this.progressLoading.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.progressLoading.TabIndex = 27;
            this.progressLoading.Value = 100;
            // 
            // btnClearSchConditions
            // 
            this.btnClearSchConditions.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearSchConditions.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearSchConditions.Location = new System.Drawing.Point(405, 6);
            this.btnClearSchConditions.Name = "btnClearSchConditions";
            this.btnClearSchConditions.Size = new System.Drawing.Size(92, 23);
            this.btnClearSchConditions.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClearSchConditions.TabIndex = 26;
            this.btnClearSchConditions.Text = "清空搜索条件";
            this.btnClearSchConditions.Click += new System.EventHandler(this.btnClearSchConditions_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(503, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar1.DockTabStripHeight = 30;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPageFirst,
            this.btnPagePre,
            this.btnPageNext,
            this.btnPageLast,
            this.cbCurPage,
            this.btnGoto,
            this.lbRecordCount,
            this.lbl,
            this.cbPageSize,
            this.labelItem2,
            this.lbCurPage,
            this.btnGeneratePersonalReport});
            this.bar1.ItemSpacing = 5;
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1271, 28);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 23;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnPageFirst
            // 
            this.btnPageFirst.Name = "btnPageFirst";
            this.btnPageFirst.Text = "首页";
            this.btnPageFirst.Click += new System.EventHandler(this.btnPageFirst_Click);
            // 
            // btnPagePre
            // 
            this.btnPagePre.Name = "btnPagePre";
            this.btnPagePre.Text = "上一页";
            this.btnPagePre.Click += new System.EventHandler(this.btnPagePre_Click);
            // 
            // btnPageNext
            // 
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Text = "下一页";
            this.btnPageNext.Click += new System.EventHandler(this.btnPageNext_Click);
            // 
            // btnPageLast
            // 
            this.btnPageLast.Name = "btnPageLast";
            this.btnPageLast.Text = "尾页";
            this.btnPageLast.Click += new System.EventHandler(this.btnPageLast_Click);
            // 
            // cbCurPage
            // 
            this.cbCurPage.DropDownHeight = 106;
            this.cbCurPage.ItemHeight = 17;
            this.cbCurPage.Name = "cbCurPage";
            // 
            // btnGoto
            // 
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Text = "Go";
            // 
            // lbRecordCount
            // 
            this.lbRecordCount.Name = "lbRecordCount";
            this.lbRecordCount.Text = "共有记录";
            // 
            // lbl
            // 
            this.lbl.Name = "lbl";
            this.lbl.Text = "每页显示";
            // 
            // cbPageSize
            // 
            this.cbPageSize.DropDownHeight = 106;
            this.cbPageSize.ItemHeight = 17;
            this.cbPageSize.Name = "cbPageSize";
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "条";
            // 
            // lbCurPage
            // 
            this.lbCurPage.Name = "lbCurPage";
            // 
            // btnGeneratePersonalReport
            // 
            this.btnGeneratePersonalReport.Name = "btnGeneratePersonalReport";
            // 
            // cmsDgvRb
            // 
            this.cmsDgvRb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsItemRefreshState});
            this.cmsDgvRb.Name = "cmsDgvRb";
            this.cmsDgvRb.Size = new System.Drawing.Size(161, 26);
            // 
            // cmsItemRefreshState
            // 
            this.cmsItemRefreshState.Name = "cmsItemRefreshState";
            this.cmsItemRefreshState.Size = new System.Drawing.Size(160, 22);
            this.cmsItemRefreshState.Text = "刷新数据库状态";
            this.cmsItemRefreshState.Click += new System.EventHandler(this.cmsItemRefreshState_Click);
            // 
            // 人申请表ToolStripMenuItem
            // 
            this.人申请表ToolStripMenuItem.Name = "人申请表ToolStripMenuItem";
            this.人申请表ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // 机票报表ToolStripMenuItem
            // 
            this.机票报表ToolStripMenuItem.Name = "机票报表ToolStripMenuItem";
            this.机票报表ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // 外领担保函ToolStripMenuItem
            // 
            this.外领担保函ToolStripMenuItem.Name = "外领担保函ToolStripMenuItem";
            this.外领担保函ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // 韩国担保函ToolStripMenuItem
            // 
            this.韩国担保函ToolStripMenuItem.Name = "韩国担保函ToolStripMenuItem";
            this.韩国担保函ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // 韩国加急申请书ToolStripMenuItem
            // 
            this.韩国加急申请书ToolStripMenuItem.Name = "韩国加急申请书ToolStripMenuItem";
            this.韩国加急申请书ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // bgWorkerLoadData
            // 
            this.bgWorkerLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerLoadData_DoWork);
            this.bgWorkerLoadData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerLoadData_ProgressChanged);
            this.bgWorkerLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerLoadData_RunWorkerCompleted);
            // 
            // cbSupplier
            // 
            this.cbSupplier.DisplayMember = "Text";
            this.cbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.ItemHeight = 15;
            this.cbSupplier.Location = new System.Drawing.Point(312, 8);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(87, 21);
            this.cbSupplier.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbSupplier.TabIndex = 76;
            this.cbSupplier.Visible = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(256, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(61, 21);
            this.labelX1.TabIndex = 75;
            this.labelX1.Text = "供应商:";
            this.labelX1.Visible = false;
            // 
            // FrmSupplierBillManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 623);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmSupplierBillManage";
            this.Text = "供应商款项汇总";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.panelBars.ResumeLayout(false);
            this.panelSerachBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.cmsDgvRb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.PanelEx panelMain;
        private System.Windows.Forms.ContextMenuStrip cmsDgvRb;
        private System.Windows.Forms.ToolStripMenuItem cmsItemRefreshState;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnPageFirst;
        private DevComponents.DotNetBar.ButtonItem btnPagePre;
        private DevComponents.DotNetBar.ButtonItem btnPageNext;
        private DevComponents.DotNetBar.ButtonItem btnPageLast;
        private DevComponents.DotNetBar.ComboBoxItem cbCurPage;
        private DevComponents.DotNetBar.ButtonItem btnGoto;
        private DevComponents.DotNetBar.LabelItem lbRecordCount;
        private DevComponents.DotNetBar.LabelItem lbl;
        private DevComponents.DotNetBar.ComboBoxItem cbPageSize;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.LabelItem lbCurPage;
        private DevComponents.DotNetBar.PanelEx panelDgv;
        private DevComponents.DotNetBar.PanelEx panelBars;
        private DevComponents.DotNetBar.PanelEx panelSerachBar;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.ButtonX btnClearSchConditions;
        private DevComponents.DotNetBar.Controls.CircularProgress progressLoading;
        private System.ComponentModel.BackgroundWorker bgWorkerLoadData;
        private System.Windows.Forms.ToolStripMenuItem 人申请表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 机票报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 外领担保函ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 韩国担保函ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 韩国加急申请书ToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonItem btnGeneratePersonalReport;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbProject;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCorporation;
        private DevComponents.DotNetBar.LabelX labelX15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corporation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarginRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportCost;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.LabelItem lbTotalCount;
        private DevComponents.DotNetBar.ButtonX btnCreateReport;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSupplier;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}

