using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SteelManagement.Common;

namespace SteelManagement.CSUI.FrmSub
{
    public partial class FrmAddPurchaseInfo : Form
    {
        private readonly BLL.PurchaseInfo _bllPurchaseInfo = new BLL.PurchaseInfo();
        private readonly Action<int> _updateDel; //副界面传来更新数据库的委托
        private readonly int _curPage; //主界面更新数据库需要一个当前页
        private readonly bool _is4Modify = false;
        private readonly SteelManagement.Model.PurchaseInfo _model = null;
        private readonly SteelManagement.Model.SteelInfo _steelInfomodel = null;


        /// <summary>
        /// 添加和修改
        /// </summary>
        /// <param name="updateDel"></param>
        /// <param name="curPage"></param>
        /// <param name="is4Modify"></param>
        /// <param name="model"></param>
        public FrmAddPurchaseInfo(Action<int> updateDel, int curPage, bool is4Modify = false, SteelManagement.Model.PurchaseInfo model = null)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            _updateDel = updateDel;
            _curPage = curPage;
            _is4Modify = is4Modify;
            _model = model;
        }

        /// <summary>
        /// 从steelmodel进行添加
        /// </summary>
        /// <param name="updateDel"></param>
        /// <param name="curPage"></param>
        /// <param name="model"></param>
        public FrmAddPurchaseInfo(Action<int> updateDel, int curPage, SteelManagement.Model.SteelInfo model)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            _updateDel = updateDel;
            _curPage = curPage;
            _steelInfomodel = model;
        }


        private void FrmAddPurchaseInfo_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            InitComboBoxs();
            if (_steelInfomodel != null)
                InitCtrlsBySteelInfoModel();

            if (_is4Modify)
            {
                //把选中的加载到这里面
                txtCorporation.Text = _model.Corporation;
                txtProject.Text = _model.Project;
                txtDateline.Text = _model.Dateline.ToString();
                txtSupplier.Text = _model.Supplier;
                txtBrand.Text = _model.Brand;
                txtTransportWay.Text = _model.TransportWay;
                txtSize.Text = _model.Size;
                txtTexture.Text = _model.Texture;
                txtAmount.Text = DecimalHandler.DecimalToString(_model.Amount);
                txtQuote.Text = DecimalHandler.DecimalToString(_model.Quote);
                txtFluctuation1.Text = DecimalHandler.DecimalToString(_model.Fluctuation1);
                txtTransportCost.Text = DecimalHandler.DecimalToString(_model.TransportCost);
                txtPrice.Text = DecimalHandler.DecimalToString(_model.Price);
                txtTotalMoney.Text = DecimalHandler.DecimalToString(_model.TotalMoney);
                txtFuYuDate.Text = _model.FuYuDate.ToString();
                txtMoney1.Text = DecimalHandler.DecimalToString(_model.Money1);
                txtInvoiceDate.Text = _model.InvoiceDate.ToString();
                txtMoney2.Text = DecimalHandler.DecimalToString(_model.Money2);

                txtDiaoZhuang.Text = _model.DiaoZhuang.ToString();
                txtLiXi.Text = DecimalHandler.DecimalToString(_model.LiXi);
                txtChengDui.Text = DecimalHandler.DecimalToString(_model.ChengDui);
                txtOtherCost.Text = DecimalHandler.DecimalToString(_model.OtherCost);
                txtTieXi.Text = DecimalHandler.DecimalToString(_model.TieXi);
                this.Text = "修改采购信息";
            }

            AddAutoUpdateEvents();
        }

        private void AddAutoUpdateEvents()
        {
            txtQuote.TextChanged += UpdatePrice;
            txtFluctuation1.TextChanged += UpdatePrice;
            txtTransportCost.TextChanged += UpdatePrice;

            txtPrice.TextChanged += UpdateTotalMoney;
            txtAmount.TextChanged += UpdateTotalMoney;
        }

        private void UpdateTotalMoney(object sender, EventArgs e)
        {
            decimal totalMoney = DecimalHandler.Parse(txtPrice.Text) * DecimalHandler.Parse(txtAmount.Text);
            txtTotalMoney.Text = DecimalHandler.DecimalToString(totalMoney);
        }

        private void UpdatePrice(object sender, EventArgs e)
        {
            decimal quote = DecimalHandler.Parse(txtQuote.Text);
            decimal fluctuation = DecimalHandler.Parse(txtFluctuation1.Text);
            decimal transportCost = DecimalHandler.Parse(txtTransportCost.Text);

            txtPrice.Text = DecimalHandler.DecimalToString(quote + fluctuation + transportCost);
        }

        private void InitCtrlsBySteelInfoModel()
        {
            txtBrand.Text = _steelInfomodel.ProducePlace;
            txtSize.Text = _steelInfomodel.Size;
            txtTexture.Text = _steelInfomodel.Texture;
            txtQuote.Text = _steelInfomodel.Price.ToString();
        }

        private void InitComboBoxs()
        {
            string tablename = "PurchaseInfo";
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

            list = BLL.CommonBll.GetFieldList(tablename, "Quote");
            if (list != null)
                foreach (var item in list)
                {
                    txtQuote.Items.Add(item);
                }


            list = BLL.CommonBll.GetFieldList(tablename, "Fluctuation1");
            if (list != null)
                foreach (var item in list)
                {
                    txtFluctuation1.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "TransportCost");
            if (list != null)
                foreach (var item in list)
                {
                    txtTransportCost.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "Price");
            if (list != null)
                foreach (var item in list)
                {
                    txtPrice.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "DiaoZhuang");
            if (list != null)
                foreach (var item in list)
                {
                    txtDiaoZhuang.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "LiXi");
            if (list != null)
                foreach (var item in list)
                {
                    txtLiXi.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "ChengDui");
            if (list != null)
                foreach (var item in list)
                {
                    txtChengDui.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "OtherCost");
            if (list != null)
                foreach (var item in list)
                {
                    txtOtherCost.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "TieXi");
            if (list != null)
                foreach (var item in list)
                {
                    txtTieXi.Items.Add(item);
                }


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_is4Modify)
            {
                try
                {
                    _model.DiaoZhuang = DecimalHandler.Parse(txtDiaoZhuang.Text);
                    _model.LiXi = DecimalHandler.Parse(txtLiXi.Text);
                    _model.ChengDui = DecimalHandler.Parse(txtChengDui.Text);
                    _model.OtherCost = DecimalHandler.Parse(txtOtherCost.Text);
                    _model.TieXi = DecimalHandler.Parse(txtTieXi.Text);
                    _model.Corporation = txtCorporation.Text;


                    if (string.IsNullOrEmpty(txtProject.Text))
                    {
                        MessageBoxEx.Show("必须填写项目名称!");
                        return;
                    }

                    _model.Project = txtProject.Text;
                    _model.Dateline = DateTime.Parse(txtDateline.Text);
                    _model.Supplier = txtSupplier.Text;
                    _model.Brand = txtBrand.Text;
                    _model.TransportWay = txtTransportWay.Text;
                    _model.Size = txtSize.Text;
                    _model.Texture = txtTexture.Text;
                    _model.Amount = DecimalHandler.Parse(txtAmount.Text);
                    _model.Quote = DecimalHandler.Parse(txtQuote.Text);
                    _model.Fluctuation1 = DecimalHandler.Parse(txtFluctuation1.Text);
                    _model.TransportCost = DecimalHandler.Parse(txtTransportCost.Text);
                    _model.Price = DecimalHandler.Parse(txtPrice.Text);
                    _model.TotalMoney = DecimalHandler.Parse(txtTotalMoney.Text);
                    _model.FuYuDate = DateTime.Parse(txtFuYuDate.Text);
                    _model.Money1 = DecimalHandler.Parse(txtMoney1.Text);
                    _model.InvoiceDate = DateTime.Parse(txtInvoiceDate.Text);
                    _model.Money2 = DecimalHandler.Parse(txtMoney2.Text);
                    if (!_bllPurchaseInfo.Update(_model))
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
                SteelManagement.Model.PurchaseInfo model = new SteelManagement.Model.PurchaseInfo();
                try
                {


                    model.Corporation = txtCorporation.Text;

                    if (string.IsNullOrEmpty(txtProject.Text))
                    {
                        MessageBoxEx.Show("必须填写项目名称!");
                        return;
                    }
                    model.Project = txtProject.Text;

                    model.Dateline = DateTime.Parse(txtDateline.Text);
                    model.Supplier = txtSupplier.Text;
                    model.Brand = txtBrand.Text;
                    model.TransportWay = txtTransportWay.Text;
                    model.Size = txtSize.Text;
                    model.Texture = txtTexture.Text;
                    model.Amount = DecimalHandler.Parse(txtAmount.Text);
                    model.Quote = DecimalHandler.Parse(txtQuote.Text);
                    model.Fluctuation1 = DecimalHandler.Parse(txtFluctuation1.Text);
                    model.TransportCost = DecimalHandler.Parse(txtTransportCost.Text);
                    model.Price = DecimalHandler.Parse(txtPrice.Text);
                    model.TotalMoney = DecimalHandler.Parse(txtTotalMoney.Text);
                    model.FuYuDate = DateTime.Parse(txtFuYuDate.Text);
                    model.Money1 = DecimalHandler.Parse(txtMoney1.Text);
                    model.InvoiceDate = DateTime.Parse(txtInvoiceDate.Text);
                    model.Money2 = DecimalHandler.Parse(txtMoney2.Text);
                    model.EntryTime = DateTime.Now;
                    model.SerialNo = SerialNoGenerator.GetSerialNo(SerialNoGenerator.Type.Type01Purchase);//生成流水号
                    model.OperatorId = GlobalUtils.LoginUser.Id;

                    model.DiaoZhuang = DecimalHandler.Parse(txtDiaoZhuang.Text);
                    model.LiXi = DecimalHandler.Parse(txtLiXi.Text);
                    model.ChengDui = DecimalHandler.Parse(txtChengDui.Text);
                    model.OtherCost = DecimalHandler.Parse(txtOtherCost.Text);
                    model.TieXi = DecimalHandler.Parse(txtTieXi.Text);

                    if (_bllPurchaseInfo.Add(model) <= 0)
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


        #region 公式提示
        private void labelX14_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("单价=报价+浮动+运费");
        }
        private void labelX8_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("总金额=单价*送货量");
        }
        #endregion


    }
}
