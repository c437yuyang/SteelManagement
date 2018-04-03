using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SteelManagement.Common;
using SteelManagement.CSUI.FrmSub;

namespace SteelManagement.CSUI.FrmMain
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }


        #region ribbon control上点击按钮
        //private void btnVisaTypeIn_Click(object sender, EventArgs e)
        //{
        //    //FrmVisaTypeIn frm = new FrmVisaTypeIn();
        //    //OpenTab(frm, frm.Name);
        //}

        private void BtnUserManage_Click(object sender, EventArgs e)
        {
            FrmUserManage frm = new FrmUserManage();
            OpenTab(frm, frm.Text);
        }
        private void BtnPurchaseInfoManage_Click(object sender, EventArgs e)
        {
            FrmPurchaseInfoManage frm = new FrmPurchaseInfoManage();
            OpenTab(frm, frm.Name);
        }
        private void BtnSteelInfoManage_Click(object sender, EventArgs e)
        {
            FrmSteelInfoManage frm = new FrmSteelInfoManage();
            OpenTab(frm, frm.Name);
        }

        private void BtnSaleInfoManage_Click(object sender, EventArgs e)
        {
            FrmSaleInfoManage frm = new FrmSaleInfoManage();
            OpenTab(frm, frm.Name);
        }

        private void btnReceiptInfoManage_Click(object sender, EventArgs e)
        {
            FrmSaleBillManage frm = new FrmSaleBillManage();
            OpenTab(frm, frm.Name);
        }
        private void BtnProjectBillManage_Click(object sender, EventArgs e)
        {
            FrmProjectBillManage frm = new FrmProjectBillManage();
            OpenTab(frm, frm.Name);
        }

        private void BtnPurchaseBillManage_Click(object sender, EventArgs e)
        {
            FrmPurchaseBillManage frm = new FrmPurchaseBillManage();
            OpenTab(frm, frm.Name);
        }

        private void BtnSupplierBillMange_Click(object sender, EventArgs e)
        {
            FrmSupplierBillManage frm = new FrmSupplierBillManage();
            OpenTab(frm, frm.Name);
        }
        private void BtnSystemSettings_Click(object sender, EventArgs e)
        {
            FrmSystemSettings frm = new FrmSystemSettings();
            frm.ShowDialog();
        }

        private void BtnChangeLoginUser_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("是否切换用户", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                GlobalUtils.StartExe(Application.ExecutablePath);
                Application.ExitThread();
            }
        }



        #endregion

        public void OpenTab(Form frm, string Name)
        {
            if (IsOpenTab(Name))
                return;

            DevComponents.DotNetBar.TabItem tp = new DevComponents.DotNetBar.TabItem();
            DevComponents.DotNetBar.TabControlPanel tcp = new DevComponents.DotNetBar.TabControlPanel();
            tp.MouseDown += new MouseEventHandler(tp_MouseDown);
            tcp.Dock = System.Windows.Forms.DockStyle.Fill;
            tcp.Location = new System.Drawing.Point(0, 0);

            frm.TopLevel = false;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tcp.Controls.Add(frm);
            tp.Text = frm.Text;
            tp.Name = Name;

            if (!IsOpenTab(Name))
            {
                tcp.TabItem = tp;
                tp.AttachedControl = tcp;
                tabMain.Controls.Add(tcp);
                tabMain.Tabs.Add(tp);
                tabMain.SelectedTab = tp;
            }
            tabMain.Refresh();
        }

        private bool IsOpenTab(string tabName)
        {
            bool isOpened = false;

            foreach (TabItem tab in tabMain.Tabs)
            {
                if (tab.Name == tabName.Trim())
                {
                    isOpened = true;
                    tabMain.SelectedTab = tab;
                    break;
                }
            }
            return isOpened;
        }

        private void tp_MouseDown(object sender, MouseEventArgs e)
        {
            tabMain.SelectedTab = (TabItem)sender;
            if (e.Button == MouseButtons.Right && tabMain.SelectedTab != null)
            {
                this.tabMain.Select();
                cms.Show(this.tabMain, e.X, e.Y);
            }
        }

        private void btnMCloseAll_Click(object sender, EventArgs e)
        {
            tabMain.Tabs.Clear();
        }

        private void btnMCloseOther_Click(object sender, EventArgs e)
        {
            do
            {
                if (tabMain.SelectedTab != tabMain.Tabs[0])
                {
                    tabMain.Tabs.RemoveAt(0);
                }
                else
                {
                    tabMain.Tabs.RemoveAt(1);
                }

            } while (tabMain.Tabs.Count != 1);

            tabMain.Refresh();
        }

        private void tabMain_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            TabItem tb = tabMain.SelectedTab;
            tabMain.Tabs.Remove(tb);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "钢材信息管理系统V" + XmlHandler.GetPropramVersion();
            this.Text = this.Text + "     当前登录用户:" + SteelManagement.Common.GlobalUtils.LoginUser.UserName;
            MinimumSize = Size;
            FrmManager.OpenedMainFrm = this;
            InitCtrlEvents();

            InitComboBoxs();


            //根据用户权限初始化窗体控制
            InitCtrlByUserPrevilige();

        }

        private void InitComboBoxs()
        {
            string tablename = "PurChaseInfo";

            cbCorporation.Items.Add("全部");
            cbProject.Items.Add("全部");

            cbCorporation.SelectedIndex = 0;
            cbProject.SelectedIndex = 0;


            var list = BLL.CommonBll.GetFieldList(tablename, "Corporation");
            if (list != null)
                foreach (var item in list)
                {
                    cbCorporation.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "Project");
            if (list != null)
                foreach (var item in list)
                {
                    cbProject.Items.Add(item);
                }

            cbSupplier.Items.Add("全部");
            cbSupplier.SelectedIndex = 0;
            list = BLL.CommonBll.GetFieldList(tablename, "Supplier");
            if (list != null)
                foreach (var item in list)
                {
                    cbSupplier.Items.Add(item);
                }
        }

        private void InitCtrlByUserPrevilige()
        {
            var user = GlobalUtils.LoginUser;

            //目前这样分配，信息管理占用16位，用户管理占用8位，后8位以后使用
            #region 信息管理
            if ((user.Privilege.Value & 0x00000001) == 0)
            {
                btnSteelInfoManage.Enabled = false;
            }

            if ((user.Privilege.Value & 0x00000002) == 0)
            {
                btnPurchaseInfoManage.Enabled = false;
            }

            if ((user.Privilege.Value & 0x00000004) == 0)
            {
                btnSaleInfoManage.Enabled = false;
            }

            if ((user.Privilege.Value & 0x00000008) == 0)
            {
                btnPurchaseBillManage.Enabled = false;
            }

            if ((user.Privilege.Value & 0x00000010) == 0)
            {
                btnSaleBillManage.Enabled = false;
            }

            if ((user.Privilege.Value & 0x00000020) == 0)
            {
                btnProjectBillManage.Enabled = false;
            }

            if ((user.Privilege.Value & 0x00000040) == 0)
            {
                btnSupplierBillMange.Enabled = false;
            }
            #endregion
        }

        private void InitCtrlEvents()
        {
            this.btnSteelInfoManage.Click += BtnSteelInfoManage_Click;
            this.btnPurchaseInfoManage.Click += BtnPurchaseInfoManage_Click;
            this.btnSaleInfoManage.Click += BtnSaleInfoManage_Click;
            this.btnSaleBillManage.Click += btnReceiptInfoManage_Click;
            this.btnProjectBillManage.Click += BtnProjectBillManage_Click;
            this.btnPurchaseBillManage.Click += BtnPurchaseBillManage_Click;
            this.btnSupplierBillMange.Click += BtnSupplierBillMange_Click;
            this.btnSystemSettings.Click += BtnSystemSettings_Click;
            this.btnUserManage.Click += BtnUserManage_Click;
            this.btnChangeLoginUser.Click += BtnChangeLoginUser_Click;
        }



        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            ICopyRight copyRight = new RegisterCopyRight();
            copyRight.UpdateUserInfo();
            Application.Exit();
        }

    }
}
