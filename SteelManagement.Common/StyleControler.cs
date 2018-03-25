using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteelManagement.Common
{
    public class StyleControler
    {
        public static void SetDgvStyle(DataGridView dataGridView1)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ReadOnly = true;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //列宽自适应,一定不能用AllCells
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders; //这里也一定不能AllCell自适应!
            dataGridView1.DefaultCellStyle.Font = new Font("微软雅黑", 9.0f, FontStyle.Bold);

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 244, 244);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 10.0f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.OrangeRed;
            dataGridView1.RowHeadersDefaultCellStyle.Font = new Font("Consolas", 10.0f, FontStyle.Bold);
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.ForestGreen;
        }
    }
}
