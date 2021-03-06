﻿using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SteelManagement.Common;

namespace SteelManagement.CSUI.FrmSub
{
    public partial class FrmAddSteelInfo : Form
    {
        private readonly BLL.SteelInfo _bllSteelInfo = new BLL.SteelInfo();
        private readonly Action<int> _updateDel; //副界面传来更新数据库的委托
        private readonly int _curPage; //主界面更新数据库需要一个当前页
        private readonly bool _is4Modify = false;
        private readonly SteelManagement.Model.SteelInfo _model = null;



        public FrmAddSteelInfo(Action<int> updateDel, int curPage, bool is4Modify = false, SteelManagement.Model.SteelInfo model = null)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            _updateDel = updateDel;
            _curPage = curPage;
            _is4Modify = is4Modify;
            _model = model;
        }

        private void FrmAddSteelInfo_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            InitComboBoxs();


            if (_is4Modify)
            {
                //把选中的加载到这里面
                txtName.Text = _model.Name;
                txtSize.Text = _model.Size;
                txtTexture.Text = _model.Texture;
                txtProducePlace.Text = _model.ProducePlace;
                txtPrice.Text = _model.Price.ToString();
                txtFluctuation.Text = _model.Fluctuation.ToString();
                txtRemark.Text = _model.Remark;
                txtState.Text = _model.State;
                txtInfoTime.Text = DateTimeFormator.DateTimeToString(_model.InfoTime,DateTimeFormator.TimeFormat.Type14LongTime1);
                this.Text = "修改钢材";
            }
        }

        private void InitComboBoxs()
        {
            string tablename = "SteelInfo";
            var list = BLL.CommonBll.GetFieldList(tablename, "Name");
            if (list != null)
                foreach (var item in list)
                {
                    txtName.Items.Add(item);
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

            list = BLL.CommonBll.GetFieldList(tablename, "ProducePlace");
            if (list != null)
                foreach (var item in list)
                {
                    txtProducePlace.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "Price");
            if (list != null)
                foreach (var item in list)
                {
                    txtPrice.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "Fluctuation");
            if (list != null)
                foreach (var item in list)
                {
                    txtFluctuation.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "Remark");
            if (list != null)
                foreach (var item in list)
                {
                    txtRemark.Items.Add(item);
                }

            list = BLL.CommonBll.GetFieldList(tablename, "State");
            if (list != null)
                foreach (var item in list)
                {
                    txtState.Items.Add(item);
                }



        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_is4Modify)
            {
                try
                {
                    _model.Name = txtName.Text;
                    _model.Size = txtSize.Text;
                    _model.Texture = txtTexture.Text;
                    _model.ProducePlace = txtProducePlace.Text;
                    _model.Price = decimal.Parse(txtPrice.Text);
                    _model.Fluctuation = decimal.Parse(txtFluctuation.Text);
                    _model.Remark = txtRemark.Text;
                    _model.State = txtState.Text;
                    _model.InfoTime = DateTime.Parse(txtInfoTime.Text);
                    if (!_bllSteelInfo.Update(_model))
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
                SteelManagement.Model.SteelInfo model = new SteelManagement.Model.SteelInfo();
                try
                {
                    model.Name = txtName.Text;                    model.Size = txtSize.Text;
                    model.Texture = txtTexture.Text;
                    model.ProducePlace = txtProducePlace.Text;
                    model.Price = decimal.Parse(txtPrice.Text);
                    model.Fluctuation = decimal.Parse(txtFluctuation.Text);
                    model.Remark = txtRemark.Text;
                    model.State = txtState.Text;
                    model.InfoTime = DateTime.Parse(txtInfoTime.Text);
                    model.EntryTime = DateTime.Now;
                    if (_bllSteelInfo.Add(model) <= 0)
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
