using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SteelManagement.Model;

namespace SteelManagement.Common.Excel
{
    public class ExcelParser
    {
        public static List<Model.SteelInfo> GetSteelListFromExcel(string filename)
        {
            //1.创建工作簿对象
            IWorkbook wkbook = null;
            try
            {
                if (Path.GetExtension(filename).Equals(".xls"))
                {

                    wkbook = new HSSFWorkbook(new FileStream(filename, FileMode.Open));
                }
                else if (Path.GetExtension(filename).Equals(".xlsx"))
                {
                    wkbook = new XSSFWorkbook(new FileStream(filename, FileMode.Open));
                }
                else
                {
                    MessageBoxEx.Show("打开文件错误，请重试!");
                    return null;
                }
            }
            catch (Exception)
            {
                MessageBoxEx.Show("文件占用，请关闭Excel后再打开文件!");
                return null;
            }


            //2.创建工作表对象
            ISheet sheet = wkbook.GetSheet("sheet1");
            List<Model.SteelInfo> res = new List<SteelInfo>();
            for (int i = 0; i <= sheet.LastRowNum; ++i)
            {
                try
                {
                    var row = sheet.GetRow(i);
                    Model.SteelInfo model = new SteelInfo();
                    model.EntryTime = DateTime.Now;
                    model.Name = row.GetCell(0)?.StringCellValue;
                    model.Size = row.GetCell(1)?.StringCellValue;
                    model.Texture = row.GetCell(2)?.StringCellValue;
                    model.ProducePlace = row.GetCell(3)?.StringCellValue;
                    model.Price = DecimalHandler.Parse(row.GetCell(4)?.NumericCellValue.ToString());

                    try
                    {
                        model.Fluctuation = DecimalHandler.Parse(row.GetCell(5)?.NumericCellValue.ToString());
                    }
                    catch (Exception)
                    {
                        try
                        {
                            if (row.GetCell(5)?.StringCellValue == "-")
                                model.Fluctuation = null;
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }
                    model.Remark = row.GetCell(6)?.StringCellValue;
                    model.State = row.GetCell(7)?.StringCellValue;
                    res.Add(model);
                }
                catch (Exception)
                {
                    MessageBoxEx.Show("第" + (i + 1) + "行数据有误");
                }
            }
            return res.Count == 0 ? null : res;
        }
    }
}
