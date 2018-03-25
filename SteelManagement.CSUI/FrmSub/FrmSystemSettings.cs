using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SteelManagement.Common;
namespace SteelManagement.CSUI.FrmSub
{
    public partial class FrmSystemSettings : Form
    {
        public FrmSystemSettings()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }

        private void FrmSystemSettings_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (GlobalUtils.DecimalDigits != -1)
            {
                txtDigits.Text = GlobalUtils.DecimalDigits.ToString();
                chkAutoDigits.Checked = false;
            }
            else
            {
                txtDigits.Enabled = false;
                chkAutoDigits.Checked = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (chkAutoDigits.Checked)
            {
                AppSettingHandler.ModifyConfig("DecimalDigits", (-1).ToString());
            }
            else
            {
                try
                {
                    AppSettingHandler.ModifyConfig("DecimalDigits", int.Parse(txtDigits.Text).ToString());
                }
                catch
                {
                    MessageBoxEx.Show("数字位数有误,请重新输入!");
                    return;
                }

            }
            MessageBoxEx.Show("修改成功!");
            this.Close();
        }

        private void chkAutoDigits_CheckedChanged(object sender, EventArgs e)
        {
            txtDigits.Enabled = !chkAutoDigits.Checked;
        }
    }
}
