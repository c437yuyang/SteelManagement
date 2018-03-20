using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SteelManagement.Common;

namespace SteelManagement.CSUI.FrmSub
{
    public partial class FrmAddPurchaseBill : Form
    {
        private readonly BLL.PurchaseBill _bllPurchaseBill = new BLL.PurchaseBill();
        private readonly Action<int> _updateDel; //副界面传来更新数据库的委托
        private readonly int _curPage; //主界面更新数据库需要一个当前页
        private readonly bool _is4Modify = false;
        private readonly SteelManagement.Model.PurchaseBill _model = null;
        private readonly SteelManagement.Model.PurchaseInfo _purchaseInfoModel = null;

        public FrmAddPurchaseBill(Action<int> updateDel, int curPage, bool is4Modify = false, SteelManagement.Model.PurchaseBill model = null)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            _updateDel = updateDel;
            _curPage = curPage;
            _is4Modify = is4Modify;
            _model = model;
        }

        public FrmAddPurchaseBill(Action<int> updateDel, int curPage, SteelManagement.Model.PurchaseInfo model)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            _updateDel = updateDel;
            _curPage = curPage;
            _purchaseInfoModel = model;
        }

        private void FrmAddPurchaseBill_Load(object sender, EventArgs e)
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
                txtCorporation.Text = _model.Corporation;
                txtProject.Text = _model.Project;
                txtSupplier.Text = _model.Supplier;
                txtPayer.Text = _model.Payer;
                txtAmount.Text = DecimalHandler.DecimalToString(_model.Amount);


                this.Text = "修改销售收款";
            }

        }

        #region 窗体初始化
        private void InitCtrlsByPurchaseInfoModel()
        {
            txtCorporation.Text = _purchaseInfoModel.Corporation;
            txtProject.Text = _purchaseInfoModel.Project;
            txtSupplier.Text = _purchaseInfoModel.Supplier;
        }

        private void InitComboBoxs()
        {
            //string tablename = "PurchaseBill";
            //var list = BLL.CommonBll.GetFieldList(tablename, "Project");
            //foreach (var item in list)
            //{
            //    //txtProject.Items.Add(item);
            //}

            //list = BLL.CommonBll.GetFieldList(tablename, "Supplier");
            //foreach (var item in list)
            //{
            //    txtSupplier.Items.Add(item);
            //}


            //list = BLL.CommonBll.GetFieldList(tablename, "Brand");
            //foreach (var item in list)
            //{
            //    txtBrand.Items.Add(item);
            //}

            //list = BLL.CommonBll.GetFieldList(tablename, "TransportWay");
            //foreach (var item in list)
            //{
            //    txtTransportWay.Items.Add(item);
            //}


            //list = BLL.CommonBll.GetFieldList(tablename, "Size");
            //foreach (var item in list)
            //{
            //    txtSize.Items.Add(item);
            //}

            //list = BLL.CommonBll.GetFieldList(tablename, "Texture");
            //foreach (var item in list)
            //{
            //    txtTexture.Items.Add(item);
            //}

            //list = BLL.CommonBll.GetFieldList(tablename, "Amount");
            //foreach (var item in list)
            //{
            //    txtAmount.Items.Add(item);
            //}

            //list = BLL.CommonBll.GetFieldList(tablename, "Quote");
            //foreach (var item in list)
            //{
            //    txtOnlinePrice.Items.Add(item);
            //}


            //list = BLL.CommonBll.GetFieldList(tablename, "Fluctuation1");
            //foreach (var item in list)
            //{
            //    txtFluctuation1.Items.Add(item);
            //}

            //list = BLL.CommonBll.GetFieldList(tablename, "TransportCost");
            //foreach (var item in list)
            //{
            //    //txtTransportCost.Items.Add(item);
            //}

            //list = BLL.CommonBll.GetFieldList(tablename, "Price");
            //foreach (var item in list)
            //{
            //    txtSalePrice.Items.Add(item);
            //}
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
                        MessageBoxEx.Show("必须填写项目名称!");
                        return;
                    }
                    _model.Project = txtProject.Text;
                    _model.Supplier = txtSupplier.Text;
                    _model.Amount = DecimalHandler.Parse(txtAmount.Text);
                    _model.Payer = txtPayer.Text;



                    //下面的字段暂时不进行修改
                    //_model.EntryTime = DateTime.Now;
                    //_model.SerialNo = SerialNoGenerator.GetSerialNo(SerialNoGenerator.Type.Type03Receipt);
                    //_model.OperatorId = GlobalUtils.LoginUser.Id;
                    if (!_bllPurchaseBill.Update(_model))
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
                SteelManagement.Model.PurchaseBill model = new SteelManagement.Model.PurchaseBill();
                try
                {
                    model.Corporation = txtCorporation.Text;
                    if (string.IsNullOrEmpty(txtProject.Text))
                    {
                        MessageBoxEx.Show("必须填写项目名称!");
                        return;
                    }
                    model.Project = txtProject.Text;
                    model.Supplier = txtSupplier.Text;
                    model.Amount = DecimalHandler.Parse(txtAmount.Text);
                    model.Payer = txtPayer.Text;


                    model.EntryTime = DateTime.Now;
                    model.SerialNo = SerialNoGenerator.GetSerialNo(SerialNoGenerator.Type.Type04PurchaseBill);
                    model.OperatorId = GlobalUtils.LoginUser.Id;

                    if (_bllPurchaseBill.Add(model) <= 0)
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
