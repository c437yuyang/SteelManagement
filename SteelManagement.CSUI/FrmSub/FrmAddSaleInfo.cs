using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

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

                //txtProject.Text = _model.Project;
                //txtArrivalTime.Text = _model.Dateline.ToString();
                //txtSupplier.Text = _model.Supplier;
                //txtBrand.Text = _model.Brand;
                //txtTransportWay.Text = _model.TransportWay;
                //txtSize.Text = _model.Size;
                //txtTexture.Text = _model.Texture;
                //txtAmount.Text = _model.Amount.ToString();
                //txtOnlinePrice.Text = _model.Quote.ToString();
                //txtFluctuation1.Text = _model.Fluctuation1.ToString();
                //txtTransportCost.Text = _model.TransportWay;
                //txtSalePrice.Text = _model.Price.ToString();
                //txtTotalSale.Text = _model.TotalMoney.ToString();
                //txtSettleTime.Text = _model.FuYuDate.ToString();
                //txtMarginRate.Text = _model.Money1.ToString();
                //txtInvoiceDate.Text = _model.InvoiceDate.ToString();
                //txtMoney2.Text = _model.Money2.ToString();
                this.Text = "修改采购信息";
            }
        }

        private void InitCtrlsByPurchaseInfoModel()
        {
            //txtBrand.Text = _purchaseInfoModel.ProducePlace;
            //txtSize.Text = _purchaseInfoModel.Size;
            //txtTexture.Text = _purchaseInfoModel.Texture;
            //txtSalePrice.Text = _purchaseInfoModel.Price.ToString();
            //txtOnlinePrice.Text = txtSalePrice.Text;
        }

        private void InitComboBoxs()
        {
            string tablename = "SaleInfo";
            var list = BLL.CommonBll.GetFieldList(tablename, "Project");
            foreach (var item in list)
            {
                //txtProject.Items.Add(item);
            }

            list = BLL.CommonBll.GetFieldList(tablename, "Supplier");
            foreach (var item in list)
            {
                txtSupplier.Items.Add(item);
            }


            list = BLL.CommonBll.GetFieldList(tablename, "Brand");
            foreach (var item in list)
            {
                txtBrand.Items.Add(item);
            }

            list = BLL.CommonBll.GetFieldList(tablename, "TransportWay");
            foreach (var item in list)
            {
                txtTransportWay.Items.Add(item);
            }


            list = BLL.CommonBll.GetFieldList(tablename, "Size");
            foreach (var item in list)
            {
                txtSize.Items.Add(item);
            }

            list = BLL.CommonBll.GetFieldList(tablename, "Texture");
            foreach (var item in list)
            {
                txtTexture.Items.Add(item);
            }

            list = BLL.CommonBll.GetFieldList(tablename, "Amount");
            foreach (var item in list)
            {
                txtAmount.Items.Add(item);
            }

            list = BLL.CommonBll.GetFieldList(tablename, "Quote");
            foreach (var item in list)
            {
                txtOnlinePrice.Items.Add(item);
            }


            list = BLL.CommonBll.GetFieldList(tablename, "Fluctuation1");
            foreach (var item in list)
            {
                txtFluctuation1.Items.Add(item);
            }

            list = BLL.CommonBll.GetFieldList(tablename, "TransportCost");
            foreach (var item in list)
            {
                //txtTransportCost.Items.Add(item);
            }

            list = BLL.CommonBll.GetFieldList(tablename, "Price");
            foreach (var item in list)
            {
                txtSalePrice.Items.Add(item);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_is4Modify)
            {
                try
                {
                    //_model.Project = txtProject.Text;
                    //_model.Dateline = DateTime.Parse(txtArrivalTime.Text);
                    //_model.Supplier = txtSupplier.Text;
                    //_model.Brand = txtBrand.Text;
                    //_model.TransportWay = txtTransportWay.Text;
                    //_model.Size = txtSize.Text;
                    //_model.Texture = txtTexture.Text;
                    //_model.Amount = decimal.Parse(txtAmount.Text);
                    //_model.Quote = decimal.Parse(txtOnlinePrice.Text);
                    //_model.Fluctuation1 = decimal.Parse(txtFluctuation1.Text);
                    //_model.TransportCost = decimal.Parse(txtTransportCost.Text);
                    //_model.Price = decimal.Parse(txtSalePrice.Text);
                    //_model.TotalMoney = decimal.Parse(txtTotalSale.Text);
                    //_model.FuYuDate = DateTime.Parse(txtSettleTime.Text);
                    //_model.Money1 = decimal.Parse(txtMarginRate.Text);
                    //_model.InvoiceDate = DateTime.Parse(txtInvoiceDate.Text);
                    //_model.Money2 = decimal.Parse(txtMoney2.Text);
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
                    //model.Project = txtProject.Text;
                    //model.Dateline = DateTime.Parse(txtArrivalTime.Text);
                    //model.Supplier = txtSupplier.Text;
                    //model.Brand = txtBrand.Text;
                    //model.TransportWay = txtTransportWay.Text;
                    //model.Size = txtSize.Text;
                    //model.Texture = txtTexture.Text;
                    //model.Amount = decimal.Parse(txtAmount.Text);
                    //model.Quote = decimal.Parse(txtOnlinePrice.Text);
                    //model.Fluctuation1 = decimal.Parse(txtFluctuation1.Text);
                    //model.TransportCost = decimal.Parse(txtTransportCost.Text);
                    //model.Price = decimal.Parse(txtSalePrice.Text);
                    //model.TotalMoney = decimal.Parse(txtTotalSale.Text);
                    //model.FuYuDate = DateTime.Parse(txtSettleTime.Text);
                    //model.Money1 = decimal.Parse(txtMarginRate.Text);
                    //model.InvoiceDate = DateTime.Parse(txtInvoiceDate.Text);
                    //model.Money2 = decimal.Parse(txtMoney2.Text);
                    //model.EntryTime = DateTime.Now;
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
