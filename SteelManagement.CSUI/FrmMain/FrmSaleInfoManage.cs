using System;
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
    public partial class FrmSaleInfoManage : Form
    {
        private readonly SteelManagement.BLL.SaleInfo _bllSaleInfo = new SteelManagement.BLL.SaleInfo();

        private int _curPage = 1;
        private int _pageCount = 0;
        private int _pageSize;
        private int _recordCount = 0;
        private string _where = string.Empty;

        public FrmSaleInfoManage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _recordCount = _bllSaleInfo.GetRecordCount(_where);
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
            dataGridView1.DataSource = _bllSaleInfo.GetListByPageOrderById(_where, _curPage, _pageSize);
            if (curSelectedRow != -1 && dataGridView1.Rows.Count > curSelectedRow)
                dataGridView1.CurrentCell = dataGridView1.Rows[curSelectedRow].Cells[0];
            dataGridView1.Update();
        }

        private void UpdateState()
        {
            _recordCount = _bllSaleInfo.GetRecordCount(_where);
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
            txtClient.Text = "";
            cbCountry.Text = "全部";
            cbDisplayType.Text = "全部";
            cbDepatureType.Text = "全部";

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
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.HeaderCell.Value = (i + 1).ToString();

                //在这里控制单元格的显示

                var jianChiLv = DgvDataSourceToList()[i].JianChiLv;
                if (jianChiLv != null)
                    dataGridView1["JianChiLv", i].Value = DecimalHandler.DecimalToPercent(jianChiLv);

                var amount = DgvDataSourceToList()[i].Amount;
                if (amount != null)
                    dataGridView1["Amount", i].Value = DecimalHandler.DecimalToString(amount, 3);

                var margin = DgvDataSourceToList()[i].Margin;
                if (margin != null)
                    dataGridView1["dgvCol_Margin", i].Value = DecimalHandler.DecimalToString(margin);

                var onlinePrice = DgvDataSourceToList()[i].OnlinePrice;
                if (onlinePrice != null)
                    dataGridView1["OnlinePrice", i].Value = DecimalHandler.DecimalToString(onlinePrice);

                var fluctuation1 = DgvDataSourceToList()[i].Fluctuation1;
                if (fluctuation1 != null)
                    dataGridView1["Fluctuation1", i].Value = DecimalHandler.DecimalToString(fluctuation1);

                var fluctuation2 = DgvDataSourceToList()[i].Fluctuation2;
                if (fluctuation2 != null)
                    dataGridView1["Fluctuation2", i].Value = DecimalHandler.DecimalToString(fluctuation2);

                var salePrice = DgvDataSourceToList()[i].SalePrice;
                if (salePrice != null)
                    dataGridView1["SalePrice", i].Value = DecimalHandler.DecimalToString(salePrice);

                var totalSale = DgvDataSourceToList()[i].TotalSale;
                if (totalSale != null)
                    dataGridView1["TotalSale", i].Value = DecimalHandler.DecimalToString(totalSale,2);

                var marginRate = DgvDataSourceToList()[i].MarginRate;
                if (marginRate != null)
                    dataGridView1["MarginRate", i].Value = DecimalHandler.DecimalToPercent(marginRate);
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
            //int res = _bllSaleInfo.AddList(list);
            //GlobalUtils.MessageBoxWithRecordNum("导入", res, list.Count);

            //LoadDataToDgvAsyn();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //FrmAddSaleInfo frm = new FrmAddSaleInfo(LoadDataToDataGridView, _curPage);
            //if (DialogResult.Cancel == frm.ShowDialog())
            //    return;
        }
        #endregion

        private List<Model.SaleInfo> DgvDataSourceToList()
        {
            return dataGridView1.DataSource as List<Model.SaleInfo>;
        }

        /// <summary>
        /// 返回当前选择的行的visaModel的List
        /// </summary>
        /// <returns></returns>
        private List<Model.SaleInfo> GetSelectedModelList()
        {
            var visaList = dataGridView1.DataSource as List<Model.SaleInfo>;
            List<Model.SaleInfo> res = new List<SaleInfo>();
            for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                res.Add(DgvDataSourceToList()[dataGridView1.SelectedRows[i].Index]);
            return res.Count > 0 ? res : null;
        }
        #region 右键菜单响应
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
            int res = _bllSaleInfo.DeleteList(modelList);

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
            FrmAddSaleInfo frm = new FrmAddSaleInfo(LoadDataToDataGridView, _curPage, true, list[0]);
            frm.ShowDialog();
        }

        //private void 采购ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var list = GetSelectedModelList();

        //    if (list.Count > 1)
        //    {
        //        MessageBoxEx.Show("请选中一条进行采购!");
        //        return;
        //    }
        //    //FrmAddSaleInfo frm = new FrmAddSaleInfo(LoadDataToDataGridView, _curPage, list[0]);
        //    //frm.ShowDialog();
        //}
        #endregion
    }
}
