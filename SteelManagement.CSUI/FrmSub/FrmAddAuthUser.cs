using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SteelManagement.Common;

namespace SteelManagement.CSUI.FrmSub
{
    public partial class FrmAddAuthUser : Form
    {
        private readonly BLL.AuthUser _bllAuthUser = new BLL.AuthUser();
        private readonly Action<int> _updateDel; //副界面传来更新数据库的委托
        private readonly int _curPage; //主界面更新数据库需要一个当前页
        private readonly bool _is4Modify = false;
        private readonly SteelManagement.Model.AuthUser _model = null;
        private readonly SteelManagement.Model.SteelInfo _steelInfomodel = null;


        /// <summary>
        /// 添加和修改
        /// </summary>
        /// <param name="updateDel"></param>
        /// <param name="curPage"></param>
        /// <param name="is4Modify"></param>
        /// <param name="model"></param>
        public FrmAddAuthUser(Action<int> updateDel, int curPage, bool is4Modify = false, SteelManagement.Model.AuthUser model = null)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            _updateDel = updateDel;
            _curPage = curPage;
            _is4Modify = is4Modify;
            _model = model;


        }

        private void FrmAddAuthUser_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;



            if (_is4Modify)
            {
                //把选中的加载到这里面
                txtAccount.Text = _model.Account;
                txtPassword.Text = _model.Password;
                txtUserMobile.Text = _model.UserMobile;
                txtUserName.Text = _model.UserName;

                PrevilegeToChkBoxs();
                if (_model.UserLevel == 0)
                    chkAdmin.Checked = true;
                else
                    chkAdmin.Checked = false;


                this.Text = "修改采购信息";
            }
        }

        private void PrevilegeToChkBoxs()
        {
            var user = _model;
            if ((user.Privilege.Value & 0x00000001) == 0)
            {
                btnSteelInfoManage.Checked = false;
            }

            if ((user.Privilege.Value & 0x00000002) == 0)
            {
                btnPurchaseInfoManage.Checked = false;
            }

            if ((user.Privilege.Value & 0x00000004) == 0)
            {
                btnSaleInfoManage.Checked = false;
            }

            if ((user.Privilege.Value & 0x00000008) == 0)
            {
                btnPurchaseBillManage.Checked = false;
            }

            if ((user.Privilege.Value & 0x00000010) == 0)
            {
                btnSaleBillManage.Checked = false;
            }

            if ((user.Privilege.Value & 0x00000020) == 0)
            {
                btnProjectBillManage.Checked = false;
            }

            if ((user.Privilege.Value & 0x00000040) == 0)
            {
                btnSupplierBillMange.Checked = false;
            }
        }

        private int ChkBoxsToPrevilege()
        {
            int previlege = 0;
            if (btnSteelInfoManage.Checked)
                previlege += 0x00000001;

            if (btnPurchaseInfoManage.Checked)
                previlege += 0x00000002;

            if (btnSaleInfoManage.Checked)
                previlege += 0x00000004;

            if (btnPurchaseBillManage.Checked)
                previlege += 0x00000008;

            if (btnSaleBillManage.Checked)
                previlege += 0x00000010;

            if (btnProjectBillManage.Checked)
                previlege += 0x00000020;

            if (btnSupplierBillMange.Checked)
                previlege += 0x00000040;

            return previlege;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {




            if (string.IsNullOrEmpty(txtUserName.Text) ||
                       string.IsNullOrEmpty(txtAccount.Text) ||
                       string.IsNullOrEmpty(txtPassword.Text)
                        )
            {
                MessageBoxEx.Show("除手机号外都必须填写!");
                return;
            }




            if (_is4Modify)
            {

                if (GlobalUtils.LoginUser.Account != _model.Account && GlobalUtils.LoginUser.UserLevel == 1)
                {
                    MessageBoxEx.Show("只有管理员才有权限修改其他用户的信息!");
                    return;
                }

                _model.UserName = txtUserName.Text;
                _model.Account = txtAccount.Text;
                _model.Password = txtPassword.Text;
                _model.UserMobile = txtUserMobile.Text;

                if ((ChkBoxsToPrevilege() != _model.Privilege || (chkAdmin.Checked ? 0 : 1) != _model.UserLevel) && GlobalUtils.LoginUser.UserLevel == 1)
                {
                    MessageBoxEx.Show("没有权限修改自己的权限信息，请联系管理员!");
                    return;
                }

                _model.Privilege = ChkBoxsToPrevilege();
                _model.UserLevel = chkAdmin.Checked ? 0 : 1;

                if (!_bllAuthUser.Update(_model))
                {
                    MessageBoxEx.Show("更新失败，请稍后重试!");
                    return;
                }
                MessageBoxEx.Show("更新成功!");
                _updateDel(_curPage);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {

                if (GlobalUtils.LoginUser.UserLevel == 1)
                {
                    MessageBoxEx.Show("只有管理员才有权限添加用户!");
                    return;
                }

                var existedModel = _bllAuthUser.GetModelList(string.Format(" UserName='{0}' or Account='{1}' ", txtUserName.Text, txtAccount.Text));
                if (existedModel != null && existedModel.Count > 0)
                {
                    MessageBoxEx.Show("用户名或登陆账号重复!");
                    return;
                }


                SteelManagement.Model.AuthUser model = new SteelManagement.Model.AuthUser();
                try
                {
                    model.UserName = txtUserName.Text;
                    model.Account = txtAccount.Text;
                    model.Password = txtPassword.Text;
                    model.UserMobile = txtUserMobile.Text;
                    model.Privilege = ChkBoxsToPrevilege();
                    model.UserLevel = chkAdmin.Checked ? 0 : 1;

                    if (_bllAuthUser.Add(model) <= 0)
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
                    MessageBoxEx.Show("请检查输入是否有误!");
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
