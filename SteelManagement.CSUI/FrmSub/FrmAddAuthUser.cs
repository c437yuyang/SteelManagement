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

                this.Text = "修改采购信息";
            }

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

                _model.UserName = txtUserName.Text;
                _model.Account = txtAccount.Text;
                _model.Password = txtPassword.Text;
                _model.UserMobile = txtUserMobile.Text;


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
