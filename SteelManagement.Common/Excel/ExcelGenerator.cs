using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using DevComponents.DotNetBar;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace SteelManagement.Common.Excel
{
    /// <summary>
    /// 这个类是自己生成的Excel
    /// </summary>
    public static class ExcelGenerator
    {
        private static bool SaveFile(string dstName, IWorkbook wk)
        {
            if (string.IsNullOrEmpty(dstName))
                return false;
            try
            {
                using (FileStream fs = new FileStream(dstName, FileMode.Create))
                    wk.Write(fs);
            }
            catch (Exception)
            {
                MessageBoxEx.Show("指定文件名的文件正在使用中，无法写入，请关闭后重试!");
                return false;
            }

            Process.Start(dstName);
            return true;
        }

        // <summary>
        /// 团签报表
        /// 
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool GetSailBillCount(List<Model.SaleBill> list)
        {
            //1.创建工作簿对象
            IWorkbook wkbook = new HSSFWorkbook();
            //2.创建工作表对象
            ISheet sheet = wkbook.CreateSheet("签证申请名单");

            //2.1创建表头
            IRow row = sheet.CreateRow(0);
            row.CreateCell(0).SetCellValue("时间");
            row.CreateCell(1).SetCellValue("对账");
            row.CreateCell(2).SetCellValue("开票日期");
            row.CreateCell(3).SetCellValue("发票");
            row.CreateCell(4).SetCellValue("收款日期");
            row.CreateCell(5).SetCellValue("收款");

            //2.2设置列宽度
            sheet.SetColumnWidth(0, 20 * 256);//时间
            sheet.SetColumnWidth(1, 20 * 256);//对账
            sheet.SetColumnWidth(2, 20 * 256);//开票日期
            sheet.SetColumnWidth(3, 20 * 256);//发票
            sheet.SetColumnWidth(4, 20 * 256);//收款日期
            sheet.SetColumnWidth(5, 20 * 256);//收款

            decimal duiZhangTotal = 0;
            decimal invoiceTotal = 0;
            decimal receiptTotal = 0;
            //3.插入行和单元格
            for (int i = 0; i != list.Count; ++i)
            {
                //创建单元格
                row = sheet.CreateRow(i + 1);
                ////设置行高
                //row.HeightInPoints = 50;
                //设置值
                row.CreateCell(0).SetCellValue(DateTimeFormator.DateTimeToString(list[i].EntryTime));
                row.CreateCell(1).SetCellValue(DecimalHandler.DecimalToString(list[i].DuiZhang, 2));
                duiZhangTotal += list[i].DuiZhang ?? 0;
                row.CreateCell(2).SetCellValue(DateTimeFormator.DateTimeToString(list[i].InvoiceDate));
                row.CreateCell(3).SetCellValue(DecimalHandler.DecimalToString(list[i].InvoiceNum, 2));
                invoiceTotal += list[i].InvoiceNum ?? 0;

                row.CreateCell(4).SetCellValue(DateTimeFormator.DateTimeToString(list[i].ReceiptDate));
                row.CreateCell(5).SetCellValue(DecimalHandler.DecimalToString(list[i].ReceiptNum, 2));
                receiptTotal += list[i].ReceiptNum ?? 0;
            }

            //统计的一行
            row = sheet.CreateRow(list.Count + 1);
            row.CreateCell(0).SetCellValue("合计");
            row.CreateCell(1).SetCellValue(DecimalHandler.DecimalToString(duiZhangTotal, 2));
            row.CreateCell(2);
            row.CreateCell(3).SetCellValue(DecimalHandler.DecimalToString(invoiceTotal, 2));
            row.CreateCell(4);
            row.CreateCell(5).SetCellValue(DecimalHandler.DecimalToString(receiptTotal, 2));

            //4.1设置对齐风格和边框
            ICellStyle style = wkbook.CreateCellStyle();
            style.VerticalAlignment = VerticalAlignment.Center;
            style.Alignment = HorizontalAlignment.Right;
            style.BorderTop = BorderStyle.Thin;
            style.BorderBottom = BorderStyle.Thin;
            style.BorderLeft = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            for (int i = 0; i <= sheet.LastRowNum; i++)
            {
                row = sheet.GetRow(i);
                for (int c = 0; c < row.LastCellNum; ++c)
                {
                    row.GetCell(c).CellStyle = style;
                }
            }
            ////4.2合并单元格
            //sheet.AddMergedRegion(new CellRangeAddress(1, sheet.LastRowNum, 12, 12));
            //sheet.AddMergedRegion(new CellRangeAddress(1, sheet.LastRowNum, 13, 13));




            //5.执行写入磁盘
            string dstName = GlobalUtils.ShowSaveFileDlg(list[0].Corporation + "_" + list[0].Project + ".xls", "office 2003 excel|*.xls");
            return SaveFile(dstName, wkbook);
        }

    }
}