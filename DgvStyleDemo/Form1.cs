using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DgvStyleDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SteelManagement.BLL.SteelInfo steelInfo = new SteelManagement.BLL.SteelInfo();
            setstyle(dataGridView1);
            setstyle(dataGridViewX1);

            dataGridView1.DataSource = steelInfo.GetModelList("");
            dataGridViewX1.DataSource = steelInfo.GetModelList("");

        }

        private void setstyle(DataGridView dataGridView1)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //列宽自适应,一定不能用AllCells
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders; //这里也一定不能AllCell自适应!
            dataGridView1.DefaultCellStyle.Font = new Font("微软雅黑", 9.0f, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(110, 110, 110);

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 244, 244);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 10.0f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 174, 219);
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 174, 219);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(165, 227, 242);
            dataGridView1.RowHeadersDefaultCellStyle.Font = new Font("Consolas", 10.0f, FontStyle.Bold);
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.ForestGreen;
        }

    }
}
