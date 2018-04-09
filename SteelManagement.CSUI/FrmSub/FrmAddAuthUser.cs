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
            bool myself = GlobalUtils.LoginUser.Account == _model.Account;

            if (_is4Modify)//修改的时候:(1)管理员all(2)审核员只能修改自己的基础信息(3)录入员可以修改所有人的项目信息
            {
                //审核员没有权限直接关闭
                if (!myself &&
                           (GlobalUtils.LoginUser.UserLevel != 1 && GlobalUtils.LoginUser.UserLevel != 0))
                {
                    MessageBoxEx.Show("审核员不能修改其他用户信息!");
                    Close();
                }

                panelPrivilege.Enabled = false;
                panelProjectInfo.Enabled = false;
                panelBasicInfo.Enabled = false;

                if (myself)
                    panelBasicInfo.Enabled = true;

                if (GlobalUtils.LoginUser.UserLevel == 1)
                    panelProjectInfo.Enabled = true;

                if (GlobalUtils.LoginUser.UserLevel == 0)
                {
                    panelPrivilege.Enabled = true;
                    panelBasicInfo.Enabled = true;
                    panelProjectInfo.Enabled = true;
                }



                //把选中的加载到这里面
                txtAccount.Text = _model.Account;
                txtPassword.Text = _model.Password;
                txtUserMobile.Text = _model.UserMobile;
                txtUserName.Text = _model.UserName;

                PrevilegeToChkBoxs();
                UserLevelToRbtns(_model.UserLevel.Value);

                this.Text = "修改用户信息";

                //只有修改的时候，并且是管理员和录入员才能够指定审核项目
                if (GlobalUtils.LoginUser.UserLevel == 0)
                {
                    chkProjects.Enabled = true;
                    //添加所有的项目
                    var list = BLL.CommonBll.GetFieldList("PurchaseInfo", "Project");
                    if (list != null)
                    {
                        foreach (var item in list)
                        {
                            chkProjects.Items.Add(item);
                        }
                    }
                }
            }
            else
            {//新增的时候两条逻辑:(1)非管理员直接不能添加(2)新增的时候不管项目
                panelProjectInfo.Enabled = false;
                if (GlobalUtils.LoginUser.UserLevel != 0)
                {
                    MessageBoxEx.Show("非管理员无权添加用户!");
                    Close();
                }
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
                if (GlobalUtils.LoginUser.Account != _model.Account &&
                    GlobalUtils.LoginUser.UserLevel != 0)
                {
                    MessageBoxEx.Show("只有管理员才有权限修改其他用户的信息!");
                    return;
                }

                _model.UserName = txtUserName.Text;
                _model.Account = txtAccount.Text;
                _model.Password = txtPassword.Text;
                _model.UserMobile = txtUserMobile.Text;

                if ((ChkBoxsToPrevilege() != _model.Privilege
                    || (GetUserLevelByRbtns()) != _model.UserLevel)
                    && GlobalUtils.LoginUser.UserLevel != 0)
                {
                    MessageBoxEx.Show("不能修改自己的权限信息，请联系管理员!");
                    return;
                }

                _model.Privilege = ChkBoxsToPrevilege();
                _model.UserLevel = GetUserLevelByRbtns();

                //执行负责项目更改
                //if()


                if (!_bllAuthUser.Update(_model))
                {
                    MessageBoxEx.Show("更新失败，请稍后重试!");
                    return;
                }
                MessageBoxEx.Show("更新成功!");
                _updateDel(_curPage);
                this.DialogResult = DialogResult.OK;
                this.Close();

                if (GlobalUtils.LoginUser.Account == _model.Account) //修改的自己的账号重启程序
                {
                    MessageBoxEx.Show("修改了自己的信息，即将重启系统!");
                    GlobalUtils.StartExe(Application.ExecutablePath);
                    Application.ExitThread();
                }
            }
            else //新增
            {

                if (GlobalUtils.LoginUser.UserLevel != 0)
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
                    model.UserLevel = GetUserLevelByRbtns();

                    //新增的时候不让修改审核项目

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

        private int GetUserLevelByRbtns()
        {
            if (rbtnAdmin.Checked)
                return 0;
            if (rbtnTyper.Checked)
                return 1;
            if (rbtnChecker.Checked)
                return 2;
            throw new Exception("Undefined Operation!");
        }

        private void UserLevelToRbtns(int level)
        {
            if (level == 0)
                rbtnAdmin.Checked = true;
            if (level == 1)
                rbtnTyper.Checked = true;
            if (level == 2)
                rbtnChecker.Checked = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            //chkProjects.Enabled = true;
        }

        private void rbtnTyper_CheckedChanged(object sender, EventArgs e)
        {
            //chkProjects.Enabled = false;
        }

        private void rbtnChecker_CheckedChanged(object sender, EventArgs e)
        {
            //chkProjects.Enabled = false;
        }
    }
}
