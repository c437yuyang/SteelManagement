﻿using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

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



        public FrmAddPurchaseInfo(Action<int> updateDel, int curPage, bool is4Modify = false, SteelManagement.Model.PurchaseInfo model = null)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            _updateDel = updateDel;
            _curPage = curPage;
            _is4Modify = is4Modify;
            _model = model;
        }

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

                txtProject.Text = _model.Project;
                txtDateline.Text = _model.Dateline.ToString();
                txtSupplier.Text = _model.Supplier;
                txtBrand.Text = _model.Brand;
                txtTransportWay.Text = _model.TransportWay;
                txtSize.Text = _model.Size;
                txtTexture.Text = _model.Texture;
                txtAmount.Text = _model.Amount.ToString();
                txtQuote.Text = _model.Quote.ToString();
                txtFluctuation1.Text = _model.Fluctuation1.ToString();
                txtTransportCost.Text = _model.TransportWay;
                txtPrice.Text = _model.Price.ToString();
                txtTotalMoney.Text = _model.TotalMoney.ToString();
                txtFuYuDate.Text = _model.FuYuDate.ToString();
                txtMoney1.Text = _model.Money1.ToString();
                txtInvoiceDate.Text = _model.InvoiceDate.ToString();
                txtMoney2.Text = _model.Money2.ToString();
                this.Text = "修改采购信息";
            }
        }

        private void InitCtrlsBySteelInfoModel()
        {
            txtBrand.Text = _steelInfomodel.ProducePlace;
            txtSize.Text = _steelInfomodel.Size;
            txtTexture.Text = _steelInfomodel.Texture;
            txtPrice.Text = _steelInfomodel.Price.ToString();
            txtQuote.Text = txtPrice.Text;
        }

        private void InitComboBoxs()
        {
            string tablename = "PurchaseInfo";
            var list = BLL.CommonBll.GetFieldList(tablename, "Project");
            foreach (var item in list)
            {
                txtProject.Items.Add(item);
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
                txtQuote.Items.Add(item);
            }


            list = BLL.CommonBll.GetFieldList(tablename, "Fluctuation1");
            foreach (var item in list)
            {
                txtFluctuation1.Items.Add(item);
            }

            list = BLL.CommonBll.GetFieldList(tablename, "TransportCost");
            foreach (var item in list)
            {
                txtTransportCost.Items.Add(item);
            }

            list = BLL.CommonBll.GetFieldList(tablename, "Price");
            foreach (var item in list)
            {
                txtPrice.Items.Add(item);
            }




            //list = BLL.CommonBll.GetFieldList(tablename, "Price");
            //foreach (var item in list)
            //{
            //    txtQuote.Items.Add(item);
            //}

            //list = BLL.CommonBll.GetFieldList(tablename, "Fluctuation");
            //foreach (var item in list)
            //{
            //    txtFluctuation1.Items.Add(item);
            //}

            //list = BLL.CommonBll.GetFieldList(tablename, "Remark");
            //foreach (var item in list)
            //{
            //    txtTransportCost.Items.Add(item);
            //}

            //list = BLL.CommonBll.GetFieldList(tablename, "State");
            //foreach (var item in list)
            //{
            //    txtTotalMoney.Items.Add(item);
            //}



        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_is4Modify)
            {
                try
                {
                    _model.Project = txtProject.Text;
                    _model.Dateline = DateTime.Parse(txtDateline.Text);
                    _model.Supplier = txtSupplier.Text;
                    _model.Brand = txtBrand.Text;
                    _model.TransportWay = txtTransportWay.Text;
                    _model.Size = txtSize.Text;
                    _model.Texture = txtTexture.Text;
                    _model.Amount = decimal.Parse(txtAmount.Text);
                    _model.Quote = decimal.Parse(txtQuote.Text);
                    _model.Fluctuation1 = decimal.Parse(txtFluctuation1.Text);
                    _model.TransportCost = decimal.Parse(txtTransportCost.Text);
                    _model.Price = decimal.Parse(txtPrice.Text);
                    _model.TotalMoney = decimal.Parse(txtTotalMoney.Text);
                    _model.FuYuDate = DateTime.Parse(txtFuYuDate.Text);
                    _model.Money1 = decimal.Parse(txtMoney1.Text);
                    _model.InvoiceDate = DateTime.Parse(txtInvoiceDate.Text);
                    _model.Money2 = decimal.Parse(txtMoney2.Text);
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
                    model.Project = txtProject.Text;
                    model.Dateline = DateTime.Parse(txtDateline.Text);
                    model.Supplier = txtSupplier.Text;
                    model.Brand = txtBrand.Text;
                    model.TransportWay = txtTransportWay.Text;
                    model.Size = txtSize.Text;
                    model.Texture = txtTexture.Text;
                    model.Amount = decimal.Parse(txtAmount.Text);
                    model.Quote = decimal.Parse(txtQuote.Text);
                    model.Fluctuation1 = decimal.Parse(txtFluctuation1.Text);
                    model.TransportCost = decimal.Parse(txtTransportCost.Text);
                    model.Price = decimal.Parse(txtPrice.Text);
                    model.TotalMoney = decimal.Parse(txtTotalMoney.Text);
                    model.FuYuDate = DateTime.Parse(txtFuYuDate.Text);
                    model.Money1 = decimal.Parse(txtMoney1.Text);
                    model.InvoiceDate = DateTime.Parse(txtInvoiceDate.Text);
                    model.Money2 = decimal.Parse(txtMoney2.Text);
                    model.EntryTime = DateTime.Now;
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




    }
}
