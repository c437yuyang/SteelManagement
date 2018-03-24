using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SteelManagement.Common;

namespace SteelManagement.CSUI.FrmSub
{
    public partial class FrmAddSaleInfo : Form
    {
        private readonly BLL.SaleInfo _bllSaleInfo = new BLL.SaleInfo();
        private readonly Action<int> _updateDel; //副界面传来更新数据库的委托
        private readonly int _curPage; //主界面更新数据库需要一个当前页
        private readonly bool _is4Modify = false;
        private readonly SteelManagement.Model.SaleInfo _model = null;
        private readonly SteelManagement.Model.PurchaseInfo _purchaseInfoModel = null;

        public FrmAddSaleInfo(Action<int> updateDel, int curPage, bool is4Modify = false, SteelManagement.Model.SaleInfo model = null)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            _updateDel = updateDel;
            _curPage = curPage;
            _is4Modify = is4Modify;
            _model = model;
        }

        public FrmAddSaleInfo(Action<int> updateDel, int curPage, SteelManagement.Model.PurchaseInfo model)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            _updateDel = updateDel;
            _curPage = curPage;
            _purchaseInfoModel = model;
        }

        private void FrmAddSaleInfo_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            InitComboBoxs();
            if (_purchaseInfoModel != null)
                InitCtrlsByPurchaseInfoModel();

            if (_is4Modify)
            {
                //把选中的加载到这里面
                txtJianChiLv.Text = DecimalHandler.DecimalToPercent(_model.JianChiLv);
                txtArrivalTime.Text = DateTimeFormator.DateTimeToString(_model.ArrivalTime);
                txtSettleTime.Text = DateTimeFormator.DateTimeToString(_model.SettleTime);
                txtSupplier.Text = _model.Supplier;
                txtBrand.Text = _model.Brand;
                txtTransportWay.Text = _model.TransportWay;
                txtSize.Text = _model.Size;
                txtTexture.Text = _model.Texture;
                txtAmount.Text = DecimalHandler.DecimalToString(_model.Amount);
                txtMargin.Text = DecimalHandler.DecimalToString(_model.Margin);
                txtOnlinePrice.Text = DecimalHandler.DecimalToString(_model.OnlinePrice);
                txtFluctuation1.Text = DecimalHandler.DecimalToString(_model.Fluctuation1);
                txtFluctuation2.Text = DecimalHandler.DecimalToString(_model.Fluctuation2);
                txtSalePrice.Text = DecimalHandler.DecimalToString(_model.SalePrice);
                txtTotalSale.Text = DecimalHandler.DecimalToString(_model.TotalSale);
                txtMarginRate.Text = DecimalHandler.DecimalToPercent(_model.MarginRate);

                txtCorporation.Text = _model.Corporation;
                txtProject.Text = _model.Project;
                txtTieXi.Text = DecimalHandler.DecimalToString(_model.TieXi);
                txtLiXi.Text = DecimalHandler.DecimalToString(_model.LiXi);

                this.Text = "修改销售信息";
            }

            AddAutoUpdateEvents();
        }

        #region 窗体初始化
        private void InitCtrlsByPurchaseInfoModel()
        {
            txtSupplier.Text = _purchaseInfoModel.Supplier;
            txtBrand.Text = _purchaseInfoModel.Brand;
            txtTransportWay.Text = _purchaseInfoModel.TransportWay;
            txtSize.Text = _purchaseInfoModel.Size;
            txtTexture.Text = _purchaseInfoModel.Texture;
            txtCorporation.Text = _purchaseInfoModel.Corporation;
            txtProject.Text = _purchaseInfoModel.Project;
        }

        private void InitComboBoxs()
        {
            string tablename = "SaleInfo";
            var list = BLL.CommonBll.GetFieldList(tablename, "Project");
            if (list != null)
                foreach (var item in list)
                {
                    txtProject.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "Corporation");
            if (list != null)
                foreach (var item in list)
                {
                    txtCorporation.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "Supplier");
            if (list != null)
                foreach (var item in list)
                {
                    txtSupplier.Items.Add(item);
                }


            list = BLL.CommonBll.GetFieldList(tablename, "Brand");
            if (list != null)
                foreach (var item in list)
                {
                    txtBrand.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "TransportWay");
            if (list != null)
                foreach (var item in list)
                {
                    txtTransportWay.Items.Add(item);
                }


            list = BLL.CommonBll.GetFieldList(tablename, "Size");
            if (list != null)
                foreach (var item in list)
                {
                    txtSize.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "Texture");
            if (list != null)
                foreach (var item in list)
                {
                    txtTexture.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "Amount");
            if (list != null)
                foreach (var item in list)
                {
                    txtAmount.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "OnlinePrice");
            if (list != null)
                foreach (var item in list)
                {
                    txtOnlinePrice.Items.Add(item);
                }


            list = BLL.CommonBll.GetFieldList(tablename, "Fluctuation1");
            if (list != null)
                foreach (var item in list)
                {
                    txtFluctuation1.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "Fluctuation2");
            if (list != null)
                foreach (var item in list)
                {
                    txtFluctuation2.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "LiXi");
            if (list != null)
                foreach (var item in list)
                {
                    txtLiXi.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "TieXi");
            if (list != null)
                foreach (var item in list)
                {
                    txtTieXi.Items.Add(item);
                }
        }
        #endregion

        #region 自动计算部分
        private void AddAutoUpdateEvents()
        {
            txtOnlinePrice.TextChanged += UpdateSalePrice;
            txtFluctuation1.TextChanged += UpdateSalePrice;
            txtFluctuation2.TextChanged += UpdateSalePrice;

            txtSalePrice.TextChanged += UpdateTotalSale;
            txtAmount.TextChanged += UpdateTotalSale;

            if (_purchaseInfoModel == null)
                return; //如果是直接手动新增就不添加这些自动更新函数了
            txtAmount.TextChanged += UpdateJianChiLv;
            txtOnlinePrice.TextChanged += UpdateMargin;
            txtTotalSale.TextChanged += UpdateMarginRate;


        }



        private void UpdateTotalSale(object sender, EventArgs e)
        {
            txtTotalSale.Text = DecimalHandler.DecimalToString(
                DecimalHandler.Parse(txtSalePrice.Text) *
                DecimalHandler.Parse(txtAmount.Text)
            );
        }

        private void UpdateSalePrice(object sender, EventArgs e)
        {
            txtSalePrice.Text = DecimalHandler.DecimalToString(
                DecimalHandler.Parse(txtOnlinePrice.Text) +
                DecimalHandler.Parse(txtFluctuation1.Text) +
                DecimalHandler.Parse(txtFluctuation2.Text)
            );
        }

        private void UpdateMarginRate(object sender, EventArgs e)
        {
            try
            {
                txtMarginRate.Text = DecimalHandler.DecimalToPercent(
                    (DecimalHandler.Parse(txtTotalSale.Text) / _purchaseInfoModel.TotalMoney ?? 0) - 1
                );
            }
            catch (Exception)
            {
                txtMarginRate.Text = "供应商总金额有误!";
            }
        }

        private void UpdateMargin(object sender, EventArgs e)
        {
            decimal onlinePrice = DecimalHandler.Parse(txtOnlinePrice.Text);
            txtMargin.Text = DecimalHandler.DecimalToString(onlinePrice - _purchaseInfoModel.Quote ?? 0);
        }

        private void UpdateJianChiLv(object sender, EventArgs e)
        {
            decimal amount = DecimalHandler.Parse(txtAmount.Text);
            decimal amountPurchase = _purchaseInfoModel.Amount ?? 0;
            txtJianChiLv.Text = DecimalHandler.DecimalToPercent(amount / amountPurchase);
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_is4Modify)
            {
                try
                {
                    _model.Corporation = txtCorporation.Text;
                    if (string.IsNullOrEmpty(txtProject.Text))
                    {
                        MessageBoxEx.Show("项目名称不能为空!");
                        return;
                    }
                    _model.Project = txtProject.Text;
                    _model.TieXi = DecimalHandler.Parse(txtTieXi.Text);
                    _model.LiXi = DecimalHandler.Parse(txtLiXi.Text);

                    _model.JianChiLv = DecimalHandler.Parse(txtJianChiLv.Text);
                    _model.ArrivalTime = DateTime.Parse(txtArrivalTime.Text);
                    _model.SettleTime = DateTime.Parse(txtSettleTime.Text);
                    _model.Supplier = txtSupplier.Text;
                    _model.Brand = txtBrand.Text;
                    _model.TransportWay = txtTransportWay.Text;
                    _model.Size = txtSize.Text;
                    _model.Texture = txtTexture.Text;
                    _model.Amount = DecimalHandler.Parse(txtAmount.Text);
                    _model.Margin = DecimalHandler.Parse(txtMargin.Text);
                    _model.OnlinePrice = DecimalHandler.Parse(txtOnlinePrice.Text);
                    _model.Fluctuation1 = DecimalHandler.Parse(txtFluctuation1.Text);
                    _model.Fluctuation2 = DecimalHandler.Parse(txtFluctuation2.Text);
                    _model.SalePrice = DecimalHandler.Parse(txtSalePrice.Text);
                    _model.TotalSale = DecimalHandler.Parse(txtTotalSale.Text);
                    _model.MarginRate = DecimalHandler.Parse(txtMarginRate.Text);
                    if (!_bllSaleInfo.Update(_model))
                    {
                        MessageBoxEx.Show("更新失败，请稍后重试!");
                        return;
                    }
                    MessageBoxEx.Show("更新成功!");
                    _updateDel(_curPage);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBoxEx.Show("请检查输入是否有误，价格为0请填入0!");
                    //throw;
                }
            }
            else
            {
                SteelManagement.Model.SaleInfo model = new SteelManagement.Model.SaleInfo();
                try
                {
                    model.Corporation = txtCorporation.Text;
                    if (string.IsNullOrEmpty(txtProject.Text))
                    {
                        MessageBoxEx.Show("项目名称不能为空!");
                        return;
                    }
                    model.Project = txtProject.Text;
                    model.TieXi = DecimalHandler.Parse(txtTieXi.Text);
                    model.LiXi = DecimalHandler.Parse(txtLiXi.Text);

                    model.JianChiLv = DecimalHandler.Parse(txtJianChiLv.Text);
                    model.ArrivalTime = DateTime.Parse(txtArrivalTime.Text);
                    model.SettleTime = DateTime.Parse(txtSettleTime.Text);
                    model.Supplier = txtSupplier.Text;
                    model.Brand = txtBrand.Text;
                    model.TransportWay = txtTransportWay.Text;
                    model.Size = txtSize.Text;
                    model.Texture = txtTexture.Text;
                    model.Amount = DecimalHandler.Parse(txtAmount.Text);
                    model.Margin = DecimalHandler.Parse(txtMargin.Text);
                    model.OnlinePrice = DecimalHandler.Parse(txtOnlinePrice.Text);
                    model.Fluctuation1 = DecimalHandler.Parse(txtFluctuation1.Text);
                    model.Fluctuation2 = DecimalHandler.Parse(txtFluctuation2.Text);
                    model.SalePrice = DecimalHandler.Parse(txtSalePrice.Text);
                    model.TotalSale = DecimalHandler.Parse(txtTotalSale.Text);
                    model.MarginRate = DecimalHandler.Parse(txtMarginRate.Text);
                    model.EntryTime = DateTime.Now;
                    model.SerialNo = SerialNoGenerator.GetSerialNo(SerialNoGenerator.Type.Type02Sale);
                    model.OperatorId = GlobalUtils.LoginUser.Id;
                    if (_bllSaleInfo.Add(model) <= 0)
                    {
                        MessageBoxEx.Show("添加失败，请稍后重试!");
                        return;
                    }
                    MessageBoxEx.Show("添加成功");
                    _updateDel(_curPage);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBoxEx.Show("请检查输入是否有误，价格为0请填入0!");
                    //throw;
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
