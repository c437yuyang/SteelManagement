﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SteelManagement.Common;
using SteelManagement.Common.PictureHandler;
using SteelManagement.CSUI.Properties;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace SteelManagement.CSUI.CustomCtrls
{
    public partial class FrmShowPicture : Form
    {
        /// <summary>
        /// 其实这个窗体里面大多数消息都没用，图片框控件里面实现了已经
        /// </summary>

        private readonly List<string> _imageList; //每张图片的名字

        private readonly string _title; //20171227

        private int _idx = 0; //当前位置

        public FrmShowPicture()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public FrmShowPicture(List<string> imageList, string title, int idx)
            : this()
        {
            _imageList = imageList;
            _title = title;
            _idx = idx;
        }

        #region 窗体事件
        private void FrmShowPicture_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            UpdateState();
        }

        private void UpdateState()
        {
            btnPre.Enabled = true;
            btnNext.Enabled = true;
            if (_idx == 0)
                btnPre.Enabled = false;
            if (_idx == _imageList.Count - 1)
                btnNext.Enabled = false;
            this.Text = "图片查看:  " + _imageList[_idx];
            this.picBox1.Image = ReceiptPicHandler.GetImage(_imageList[_idx] );
            if (picBox1.Image == null)
                picBox1.Image = Resources.PictureNotFound;
            lbPageIdx.Text = (_idx + 1) + "/" + _imageList.Count;
        }

        #endregion

        #region 按钮事件

        private void btnPre_Click(object sender, EventArgs e)
        {
            --_idx;
            UpdateState();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ++_idx;
            UpdateState();
        }

        //下面的按钮和右键菜单响应都没用了，只是没删掉而已
        private void btnLeft90_Click(object sender, EventArgs e)
        {
            picBox1.Image = Common.PicHandler.KiRotate90(new Bitmap(picBox1.Image), 270);
        }
        private void btnRight90_Click(object sender, EventArgs e)
        {
            picBox1.Image = Common.PicHandler.KiRotate90(new Bitmap(picBox1.Image), 90);
        }
        private void btnFlipVertical_Click(object sender, EventArgs e)
        {
            picBox1.Image = Common.PicHandler.KiRotate90(new Bitmap(picBox1.Image), -180);
        }
        private void btnFlipHorizontal_Click(object sender, EventArgs e)
        {
            picBox1.Image = Common.PicHandler.KiRotate90(new Bitmap(picBox1.Image), 180);
        }
        #endregion
        #region 右键菜单响应
        private void picBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //    cmsPicBox.Show(MousePosition);
        }

        private void 左旋90度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLeft90_Click(null, null);
        }

        private void 右旋90度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRight90_Click(null, null);
        }

        private void 垂直翻转ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFlipVertical_Click(null, null);
        }

        private void 水平翻转ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFlipHorizontal_Click(null, null);
        }
        private void 保存图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = GlobalUtils.ShowSaveFileDlg(string.Empty);
            if (!string.IsNullOrEmpty(filename))
                picBox1.Image.Save(filename);
        }
        #endregion















    }
}
