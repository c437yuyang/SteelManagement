using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using SteelManagement.Model;

namespace SteelManagement.Common.Excel
{
    public class ExcelParser
    {


        public static List<Model.SteelInfo> GetSteelListFromExcel(string filename)
        {
            //1.创建工作簿对象
            IWorkbook wkbook = new HSSFWorkbook(new FileStream(filename, FileMode.Open));
            //2.创建工作表对象
            ISheet sheet = wkbook.GetSheet("sheet1");
            List<Model.SteelInfo> res = new List<SteelInfo>();
            for (int i = 0; i <= sheet.LastRowNum; ++i)
            {
                var row = sheet.GetRow(i);
                Model.SteelInfo model = new SteelInfo();
                model.EntryTime = DateTime.Now;
                model.Name = row.GetCell(0).StringCellValue;
                model.Size = row.GetCell(1).StringCellValue;
                model.Texture = row.GetCell(2).StringCellValue;
                model.ProducePlace = row.GetCell(3).StringCellValue;
                model.Price = decimal.Parse(row.GetCell(3).NumericCellValue.ToString());
                model.Fluctuation = decimal.Parse(row.GetCell(4).NumericCellValue.ToString());
                model.Remark = row.GetCell(5).StringCellValue;
                model.State = row.GetCell(6).StringCellValue;
                res.Add(model);
            }
            return res.Count == 0 ? null : res;
        }



    }
}
