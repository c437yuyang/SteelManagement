﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SteelManagement.Common;
using SteelManagement.CSUI.FrmSub;
using SteelManagement.CSUI.Properties;
using SteelManagement.Model;

namespace SteelManagement.CSUI.FrmMain
{
    public partial class FrmPurchaseInfoManage : Form
    {
        private readonly SteelManagement.BLL.PurchaseInfo _bllPurchaseInfo = new SteelManagement.BLL.PurchaseInfo();

        private int _curPage = 1;
        private int _pageCount = 0;
        private int _pageSize;
        private int _recordCount = 0;
        private string _where = string.Empty;

        public FrmPurchaseInfoManage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _recordCount = _bllPurchaseInfo.GetRecordCount(_where);
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

            _pageSize = int.Parse(cbPageSize.Text);
            cbPageSize.TextChanged += CbPageSize_TextChanged;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //列宽自适应,一定不能用AllCells
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders; //这里也一定不能AllCell自适应!
            dataGridView1.DefaultCellStyle.Font = new Font("微软雅黑", 9.0f, FontStyle.Bold);
            dataGridView1.DoubleClick += DataGridView1_DoubleClick;
            dataGridView1.ReadOnly = true;

            bgWorkerLoadData.WorkerReportsProgress = true;

            progressLoading.Visible = false;
            LoadDataToDgvAsyn();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            修改ToolStripMenuItem_Click(null, null);
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
            dataGridView1.DataSource = _bllPurchaseInfo.GetListByPageOrderById(_where, _curPage, _pageSize);
            if (curSelectedRow != -1 && dataGridView1.Rows.Count > curSelectedRow)
                dataGridView1.CurrentCell = dataGridView1.Rows[curSelectedRow].Cells[0];
            dataGridView1.Update();
        }

        private void UpdateState()
        {
            _recordCount = _bllPurchaseInfo.GetRecordCount(_where);
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
            //if (cbDisplayType.Text == "全部")
            //{
            //}
            //else if (cbDisplayType.Text == "未记录")
            //{
            //    conditions.Add(" Types is null or Types='' ");
            //}
            //else if (cbDisplayType.Text == "个签")
            //{
            //    conditions.Add(" Types = '个签' ");
            //}
            //else if (cbDisplayType.Text == "团签")
            //{
            //    conditions.Add(" Types = '团签' ");
            //}
            //else if (cbDisplayType.Text == "团做个")
            //{
            //    conditions.Add(" Types = '团做个' ");
            //}
            //else if (cbDisplayType.Text == "个签&&团做个")
            //{
            //    conditions.Add(" Types = '团做个' or Types = '个签'");
            //}

            //if (cbCountry.Text == "全部")
            //{

            //}
            //else
            //{
            //    conditions.Add(" Country = '" + cbCountry.Text + "' ");
            //}

            if (!string.IsNullOrEmpty(txtSerialNo.Text.Trim()))
            {
                conditions.Add(" (SerialNo like '%" + txtSerialNo.Text + "%') ");
            }

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
            txtSerialNo.Text = "";
            //cbCountry.Text = "全部";
            //cbDisplayType.Text = "全部";
            //cbDepatureType.Text = "全部";

        }


        #endregion
        #region dgv消息相应
        /// <summary>
        /// dgv设置行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.HeaderCell.Value = (i + 1).ToString();

                //在这里控制单元格的显示
                var amount = DgvDataSourceToList()[i].Amount;
                if (amount != null)
                    dataGridView1["Amount", i].Value = DecimalHandler.DecimalToString(amount.Value, 3);

                var quote = DgvDataSourceToList()[i].Quote;
                if (quote != null)
                    dataGridView1["Quote", i].Value = DecimalHandler.DecimalToString(quote.Value, 1);

                var fluctuation1 = DgvDataSourceToList()[i].Fluctuation1;
                if (fluctuation1 != null)
                    dataGridView1["Fluctuation1", i].Value = DecimalHandler.DecimalToString(fluctuation1.Value, 1);

                var transportcost = DgvDataSourceToList()[i].TransportCost;
                if (transportcost != null)
                    dataGridView1["TransportCost", i].Value = DecimalHandler.DecimalToString(transportcost.Value, 2);

                var price = DgvDataSourceToList()[i].Price;
                if (price != null)
                    dataGridView1["Price", i].Value = DecimalHandler.DecimalToString(price.Value, 1);

                var totalMoney = DgvDataSourceToList()[i].TotalMoney;
                if (totalMoney != null)
                    dataGridView1["TotalMoney", i].Value = DecimalHandler.DecimalToString(totalMoney.Value, 2);

                var money1 = DgvDataSourceToList()[i].Money1;
                if (money1 != null)
                    dataGridView1["Money1", i].Value = DecimalHandler.DecimalToString(money1.Value, 2);

                var money2 = DgvDataSourceToList()[i].Money2;
                if (money2 != null)
                    dataGridView1["Money2", i].Value = DecimalHandler.DecimalToString(money2.Value, 2);
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
        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            //ExcelGenerator.GetStatisticPersonalTable(dataGridView1.DataSource as List<Model.PersonalStat>);
        }

        private void btnAddFromExcel_Click(object sender, EventArgs e)
        {
            //string filename = GlobalUtils.ShowOpenFileDlg("Excel文件|*.xls;*.xlsx");
            //if (string.IsNullOrEmpty(filename))
            //    return;

            //var list = Common.Excel.ExcelParser.GetSteelListFromExcel(filename);
            //if (list == null || list.Count == 0)
            //    return;
            //int res = _bllPurchaseInfo.AddList(list);
            //GlobalUtils.MessageBoxWithRecordNum("导入", res, list.Count);

            //LoadDataToDgvAsyn();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddPurchaseInfo frm = new FrmAddPurchaseInfo(LoadDataToDataGridView, _curPage);
            if (DialogResult.Cancel == frm.ShowDialog())
                return;
            LoadDataToDgvAsyn();
        }
        #endregion

        private List<Model.PurchaseInfo> DgvDataSourceToList()
        {
            return dataGridView1.DataSource as List<Model.PurchaseInfo>;
        }

        /// <summary>
        /// 返回当前选择的行的visaModel的List
        /// </summary>
        /// <returns></returns>
        private List<Model.PurchaseInfo> GetSelectedModelList()
        {
            var visaList = dataGridView1.DataSource as List<Model.PurchaseInfo>;
            List<Model.PurchaseInfo> res = new List<PurchaseInfo>();
            for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                res.Add(DgvDataSourceToList()[dataGridView1.SelectedRows[i].Index]);
            return res.Count > 0 ? res : null;
        }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (GlobalUtils.LoginUserLevel != RigthLevel.Manager)
            //{
            //    MessageBoxEx.Show("权限不足!");
            //    return;
            //}

            int count = this.dataGridView1.SelectedRows.Count;
            if (MessageBoxEx.Show("确认删除" + count + "条记录?", "提醒", MessageBoxButtons.OKCancel)
                == DialogResult.Cancel)
                return;
            var modelList = GetSelectedModelList();
            int res = _bllPurchaseInfo.DeleteList(modelList);

            GlobalUtils.MessageBoxWithRecordNum("删除", res, count);
            LoadDataToDataGridView(_curPage);
            UpdateState();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = GetSelectedModelList();

            if (list.Count > 1)
            {
                MessageBoxEx.Show("请选中一条进行修改!");
                return;
            }
            FrmAddPurchaseInfo frm = new FrmAddPurchaseInfo(LoadDataToDataGridView, _curPage, true, list[0]);
            frm.ShowDialog();
        }

        private void 售出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = GetSelectedModelList();

            if (list.Count > 1)
            {
                MessageBoxEx.Show("请选中一条进行销售!");
                return;
            }
            FrmAddSaleInfo frm = new FrmAddSaleInfo(LoadDataToDataGridView, _curPage, list[0]);
            frm.ShowDialog();
        }
    }
}
