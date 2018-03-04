﻿using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SteelManagement.Common;

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
            FrmsManager.OpenedForms.Add(this);

            InitCtrlEvents();

        }

        private void InitCtrlEvents()
        {
            this.btnSteelInfoManage.Click += BtnSteelInfoManage_Click;
            this.btnPurchaseInfoManage.Click += BtnPurchaseInfoManage_Click;
            this.btnSaleInfoManage.Click += BtnSaleInfoManage_Click;
        }



        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
