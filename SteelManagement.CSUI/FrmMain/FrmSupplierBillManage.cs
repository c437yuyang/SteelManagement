﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SteelManagement.Common;
using SteelManagement.Common.Excel;
using SteelManagement.CSUI.CustomCtrls;
using SteelManagement.CSUI.FrmSub;
using SteelManagement.CSUI.Properties;
using SteelManagement.Model;

namespace SteelManagement.CSUI.FrmMain
{
    public partial class FrmSupplierBillManage : Form
    {
        private readonly SteelManagement.BLL.SupplierBill _bllSupplierBill = new SteelManagement.BLL.SupplierBill();

        private int _curPage = 1;
        private int _pageCount = 0;
        private int _pageSize;
        private int _recordCount = 0;
        private string _where = string.Empty;

        public FrmSupplierBillManage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_recordCount = _bllSupplierBill.GetRecordCount(_where);
            _pageCount = (int)Math.Ceiling(_recordCount / (double)_pageSize);

            //初始化一些控件
            //txtPicPath.Text = GlobalInfo.AppPath;
            cbPageSize.Items.Add("30");
            cbPageSize.Items.Add("50");
            cbPageSize.Items.Add("100");
            cbPageSize.Items.Add("300");
            cbPageSize.Items.Add("500");
            cbPageSize.Items.Add("1000");
            cbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPageSize.SelectedIndex = 2;

            InitComboBoxs();


            _pageSize = int.Parse(cbPageSize.Text);
            cbPageSize.TextChanged += CbPageSize_TextChanged;

            dataGridView1.DoubleClick += DataGridView1_DoubleClick;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            StyleControler.SetDgvStyle(dataGridView1);

            bgWorkerLoadData.WorkerReportsProgress = true;

            progressLoading.Visible = false;
            LoadDataToDgvAsyn();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;
            int digit = GlobalUtils.DecimalDigits;
            decimal goujinzonge = 0, goujinzhongliang = 0, xiaoshouzonge = 0, xiaoshouzhongliang = 0, yunfei = 0;

            for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
            {
                var model = DgvDataSourceToList()[dataGridView1.SelectedRows[i].Index];
                goujinzonge += DecimalHandler.Parse(model.TotalPurchase.ToString());
                goujinzhongliang += DecimalHandler.Parse(model.PurchaseAmount.ToString());
                xiaoshouzonge += DecimalHandler.Parse(model.TotalSale.ToString());
                xiaoshouzhongliang += DecimalHandler.Parse(model.SaleAmount.ToString());
                yunfei += DecimalHandler.Parse(model.TransportCost.ToString());
            }

            lbTotalCount.Text = string.Format("选中{5}项 合计: 购进额 {0}   购进量 {1}  销售总额 {2}  销售量 {3} 运费 {4}",
                DecimalHandler.DecimalToString(goujinzonge, digit),
                DecimalHandler.DecimalToString(goujinzhongliang, digit),
                DecimalHandler.DecimalToString(xiaoshouzonge, digit),
                DecimalHandler.DecimalToString(xiaoshouzhongliang, digit),
                DecimalHandler.DecimalToString(yunfei, digit),
                 dataGridView1.SelectedRows.Count);

            if (goujinzonge == 0)
            {
                //lbCount1.Text = string.Format("利润 {0}  利润率 {1}",
                //DecimalHandler.DecimalToString(xiaoshouzonge - goujinzonge), -1);
            }
        }

        private void InitComboBoxs()
        {
            cbCorporation.Items.Add("全部");
            cbProject.Items.Add("全部");

            cbCorporation.SelectedIndex = 0;
            cbProject.SelectedIndex = 0;


            string tablename = "SaleInfo";
            var list = BLL.CommonBll.GetFieldList(tablename, "Project");
            if (list != null)
                foreach (var item in list)
                {
                    cbProject.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "Corporation");
            if (list != null)
                foreach (var item in list)
                {
                    cbCorporation.Items.Add(item);
                }




        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //修改ToolStripMenuItem_Click(null, null);
        }

        private void CbPageSize_TextChanged(object sender, EventArgs e)
        {
            _pageSize = int.Parse(cbPageSize.Text);
            LoadDataToDgvAsyn();
        }

        #region model与control
        //private void ModelToCtrls(SteelManagement.Model.VisaInfo model)
        //{
        //    //添加多线程情况的时候的判断
        //    if (this.InvokeRequired)
        //    {
        //        this.Invoke(new Action(() =>
        //        {
        //            //model.Types = "个签";
        //            model.EntryTime = DateTime.Now;
        //            model.outState = OutState.Type01NoRecord;
        //            txtName.Text = model.Name;
        //            txtEnglishName.Text = model.EnglishName;
        //            txtSex.Text = model.Sex;
        //            txtBirthday.Text = model.Birthday.ToString();
        //            txtPassNo.Text = model.PassportNo;
        //            txtLicenseTime.Text = model.LicenceTime.ToString();
        //            txtExpireDate.Text = model.ExpiryDate.ToString();
        //            txtBirthPlace.Text = model.Birthplace;
        //            txtIssuePlace.Text = model.IssuePlace;
        //        }));
        //        return;
        //    }
        //    //model.Types = "个签";
        //    model.EntryTime = DateTime.Now;
        //    model.outState = OutState.Type01NoRecord;
        //    txtName.Text = model.Name;
        //    txtEnglishName.Text = model.EnglishName;
        //    txtSex.Text = model.Sex;
        //    txtBirthday.Text = model.Birthday.ToString();
        //    txtPassNo.Text = model.PassportNo;
        //    txtLicenseTime.Text = model.LicenceTime.ToString();
        //    txtExpireDate.Text = model.ExpiryDate.ToString();
        //    txtBirthPlace.Text = model.Birthplace;
        //    txtIssuePlace.Text = model.IssuePlace;
        //}

        //private VisaInfo CtrlsToModel()
        //{
        //    VisaInfo model = new VisaInfo();
        //    //model.Types = "个签";
        //    model.EntryTime = DateTime.Now;
        //    model.outState = OutState.Type01NoRecord;
        //    try
        //    {
        //        model.Name = txtName.Text;
        //        model.EnglishName = txtEnglishName.Text;
        //        model.Sex = txtSex.Text;
        //        model.Birthday = DateTime.Parse(txtBirthday.Text);
        //        model.PassportNo = txtPassNo.Text;
        //        model.LicenceTime = DateTime.Parse(txtLicenseTime.Text);
        //        model.ExpiryDate = DateTime.Parse(txtExpireDate.Text);
        //        model.Birthplace = txtBirthPlace.Text;
        //        model.IssuePlace = txtIssuePlace.Text;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBoxEx.Show(Resources.PleaseCheckDateTimeFormat);
        //        return null;
        //    }
        //    return model;
        //}
        #endregion

        #region dgv用到的相关方法

        /// <summary>
        /// 显示进度条
        /// </summary>
        public void ShowProgress()
        {
            progressLoading.Visible = true;
            progressLoading.IsRunning = true;
        }

        public void LoadDataToDataGridView(int page) //刷新后保持选中
        {
            _where = GetWhereCondition();
            int curSelectedRow = -1;
            if (dataGridView1.SelectedRows.Count > 0)
                curSelectedRow = dataGridView1.SelectedRows[0].Index;
            dataGridView1.DataSource = _bllSupplierBill.GetModelList(_where);
            if (curSelectedRow != -1 && dataGridView1.Rows.Count > curSelectedRow)
                dataGridView1.CurrentCell = dataGridView1.Rows[curSelectedRow].Cells[0];
            dataGridView1.Update();
        }

        private void UpdateState()
        {
            //_recordCount = _bllSupplierBill.GetRecordCount(_where);
            _pageCount = (int)Math.Ceiling((double)_recordCount / (double)_pageSize);
            if (_curPage == 1)
                btnPagePre.Enabled = false;
            else
                btnPagePre.Enabled = true;
            if (_curPage == _pageCount)
                btnPageNext.Enabled = false;
            else
                btnPageNext.Enabled = true;

            lbRecordCount.Text = "共有记录:" + _recordCount + "条";
            lbCurPage.Text = "当前为第" + _curPage + "页";
        }
        #endregion

        #region dgv的bar栏和搜索栏
        private void btnPageNext_Click(object sender, EventArgs e)
        {
            ++_curPage;
            LoadDataToDgvAsyn();
        }

        private void btnPagePre_Click(object sender, EventArgs e)
        {
            --_curPage;
            LoadDataToDgvAsyn();
        }

        private void btnPageFirst_Click(object sender, EventArgs e)
        {
            _curPage = 1;
            LoadDataToDgvAsyn();
        }

        private void btnPageLast_Click(object sender, EventArgs e)
        {
            _curPage = _pageCount;
            LoadDataToDgvAsyn();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _where = GetWhereCondition();
            _curPage = 1;
            LoadDataToDgvAsyn();
        }



        private string GetWhereCondition()
        {
            List<string> conditions = new List<string>();

            if (FrmManager.OpenedMainFrm.cbCorporation.Text == "全部")
            {

            }
            else
            {
                conditions.Add(" Corporation = '" + FrmManager.OpenedMainFrm.cbCorporation.Text + "' ");
            }

            if (FrmManager.OpenedMainFrm.cbProject.Text == "全部")
            {

            }
            else
            {
                conditions.Add(" Project = '" + FrmManager.OpenedMainFrm.cbProject.Text + "' ");
            }

            if (FrmManager.OpenedMainFrm.cbSupplier.Text == "全部")
            {

            }
            else
            {
                conditions.Add(" Supplier = '" + FrmManager.OpenedMainFrm.cbSupplier.Text + "' ");
            }

            //if (!string.IsNullOrEmpty(txtClient.Text.Trim()))
            //{
            //    conditions.Add(" (Client like '%" + txtClient.Text + "%') ");
            //}

            //if (cbDepatureType.Text == "全部")
            //{

            //}
            //else
            //{
            //    conditions.Add(" DepartureType = '" + cbDepatureType.Text + "' ");
            //}



            string[] arr = conditions.ToArray();
            string where = string.Join(" and ", arr);
            return where;
        }


        private void btnClearSchConditions_Click(object sender, EventArgs e)
        {
            cbProject.Text = "全部";
            cbCorporation.Text = "全部";
        }


        #endregion
        #region dgv消息相应
        /// <summary>
        /// 根据送签状态设置单元格颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (dataGridView1.Columns[e.ColumnIndex].Name == "outState")
            //{
            //    Color c = Color.Empty;
            //    //string state = e.Value.ToString();
            //    string state = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //    if (state == OutState.Type01NoRecord)
            //        c = Color.AliceBlue;
            //    else if (state == OutState.Type01Delay)
            //        c = Color.DarkOrange;
            //    else if (state == OutState.Type02In)
            //        c = Color.Yellow;
            //    else if (state == OutState.Type03NormalOut)
            //        c = Color.Green;
            //    else if (state == OutState.TYPE04AbnormalOut)
            //        c = Color.Red;
            //    else
            //        c = Color.Black;
            //    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = c;
            //}
        }

        /// <summary>
        /// dgv设置行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int digit = GlobalUtils.DecimalDigits;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.HeaderCell.Value = (i + 1).ToString();

                for (int j = 0; j != dataGridView1.ColumnCount; ++j)
                {
                    var value = dataGridView1.Rows[i].Cells[j].Value;
                    if (dataGridView1.Rows[i].Cells[j].ValueType == typeof(decimal) && value != null)
                    {
                        if (digit == -1)
                            dataGridView1.Rows[i].Cells[j].Value = DecimalHandler.DecimalToString((decimal)value);
                        else
                            dataGridView1.Rows[i].Cells[j].Value = DecimalHandler.DecimalToString((decimal)value, digit);
                    }

                    if (dataGridView1.Columns[j].Name == "MarginRate")
                    {
                        dataGridView1.Rows[i].Cells[j].Value = DecimalHandler.DecimalToPercent(DgvDataSourceToList()[i].MarginRate);
                    }

                }

            }
        }

        /// <summary>
        /// dgv右键响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    //如果没选中当前活动行则选中这一行
                    if (dataGridView1.Rows[e.RowIndex].Selected == false)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dataGridView1.SelectedRows.Count == 1)
                    {
                        if (e.ColumnIndex != -1) //选中表头了
                            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        else
                        {
                            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                        }

                    }
                    //弹出操作菜单
                    cmsDgvRb.Show(MousePosition.X, MousePosition.Y);

                }
            }
        }

        #endregion

        #region dgv右键菜单相应
        /// <summary>
        /// 刷新dgv数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsItemRefreshState_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView(_curPage);
        }

        #endregion


        #region backgroundworker load data to datagridview

        private void LoadDataToDgvAsyn()
        {
            while (bgWorkerLoadData.IsBusy)
            {
                ;
            }
            ShowProgress();
            bgWorkerLoadData.RunWorkerAsync();
        }

        private void bgWorkerLoadData_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    LoadDataToDataGridView(_curPage);
                    UpdateState();
                }));
            }
            else
            {
                LoadDataToDataGridView(_curPage);
                UpdateState();
            }
        }

        private void bgWorkerLoadData_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            //this.progressLoading.Visible = true;
            //this.progressLoading.IsRunning = true;
        }

        private void bgWorkerLoadData_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.progressLoading.Visible = false;
            this.progressLoading.IsRunning = false;
        }
        #endregion


        #region 按钮事件




        private void btnAdd_Click(object sender, EventArgs e)
        {
            //FrmAddSupplierBill frm = new FrmAddSupplierBill(LoadDataToDataGridView, _curPage);
            //frm.ShowDialog();
        }
        #endregion

        private List<Model.SupplierBill> DgvDataSourceToList()
        {
            return dataGridView1.DataSource as List<Model.SupplierBill>;
        }

        /// <summary>
        /// 返回当前选择的行的visaModel的List
        /// </summary>
        /// <returns></returns>
        private List<Model.SupplierBill> GetSelectedModelList()
        {
            var visaList = dataGridView1.DataSource as List<Model.SupplierBill>;
            List<Model.SupplierBill> res = new List<SupplierBill>();
            for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                res.Add(DgvDataSourceToList()[dataGridView1.SelectedRows[i].Index]);
            return res.Count > 0 ? res : null;
        }

        #region 右键菜单响应

        #endregion

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            ExcelGenerator.GetSupplierCount(DgvDataSourceToList());
        }
    }
}
