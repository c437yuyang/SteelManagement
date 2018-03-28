using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using DevComponents.DotNetBar;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
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
        /// 
        /// 
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool GetSailBillCount(List<Model.SaleBill> list)
        {
            //1.创建工作簿对象
            IWorkbook wkbook = new HSSFWorkbook();
            //2.创建工作表对象
            ISheet sheet = wkbook.CreateSheet("销售收款汇总");

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


        // <summary>
        /// 
        /// 
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool GetSupplierCount(List<Model.SupplierBill> list)
        {
            //1.创建工作簿对象
            IWorkbook wkbook = new HSSFWorkbook();
            //2.创建工作表对象
            ISheet sheet = wkbook.CreateSheet("供应商");

            //2.1创建表头
            IRow row = sheet.CreateRow(0);
            row.CreateCell(0).SetCellValue("供应商");
            row.CreateCell(1).SetCellValue("供应商购金额");
            row.CreateCell(2).SetCellValue("重量");
            row.CreateCell(3).SetCellValue("销售总额");
            row.CreateCell(4).SetCellValue("利润率");
            row.CreateCell(5).SetCellValue("运费");

            //2.2设置列宽度
            sheet.SetColumnWidth(0, 20 * 256);//时间
            sheet.SetColumnWidth(1, 20 * 256);//对账
            sheet.SetColumnWidth(2, 20 * 256);//开票日期
            sheet.SetColumnWidth(3, 20 * 256);//发票
            sheet.SetColumnWidth(4, 20 * 256);//收款日期
            sheet.SetColumnWidth(5, 20 * 256);//收款

            decimal[] total = new decimal[4];
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
                row.CreateCell(0).SetCellValue(list[i].Supplier);
                row.CreateCell(1).SetCellValue(DecimalHandler.DecimalToString(list[i].TotalPurchase, 2));
                total[0] += list[i].TotalPurchase;
                row.CreateCell(2).SetCellValue(DecimalHandler.DecimalToString(list[i].PurchaseAmount, 1));
                row.CreateCell(3).SetCellValue(DecimalHandler.DecimalToString(list[i].TotalSale, 2));
                total[1] += list[i].PurchaseAmount;
                total[2] += list[i].TotalSale;
                total[3] += list[i].TransportCost;


                row.CreateCell(4).SetCellValue(DecimalHandler.DecimalToPercent(list[i].MarginRate));
                row.CreateCell(5).SetCellValue(DecimalHandler.DecimalToString(list[i].TransportCost, 2));

            }

            //统计的一行
            row = sheet.CreateRow(list.Count + 1);
            row.CreateCell(0).SetCellValue("合计");
            row.CreateCell(1).SetCellValue(DecimalHandler.DecimalToString(total[0], 2));
            row.CreateCell(2).SetCellValue(DecimalHandler.DecimalToString(total[1], 1));
            row.CreateCell(3).SetCellValue(DecimalHandler.DecimalToString(total[2], 2));
            row.CreateCell(4);
            row.CreateCell(5).SetCellValue(DecimalHandler.DecimalToString(total[3], 2));

            //统计的一行
            row = sheet.CreateRow(list.Count + 2);
            row.CreateCell(0).SetCellValue("利润");
            row.CreateCell(1).SetCellValue(DecimalHandler.DecimalToString(total[2] - total[0], 2));
            row.CreateCell(2);
            row.CreateCell(3);
            row.CreateCell(4).SetCellValue(DecimalHandler.DecimalToPercent((total[2] - total[0]) / total[0]));


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


        // <summary>
        /// 
        /// 
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool GetProjectBillCount(List<Model.ProjectBill> list)
        {
            //1.创建工作簿对象
            IWorkbook wkbook = new HSSFWorkbook();
            //2.创建工作表对象
            ISheet sheet = wkbook.CreateSheet("汇总");

            //2.1创建表头
            IRow row = sheet.CreateRow(0);
            row.HeightInPoints = 20;
            row.CreateCell(0).SetCellValue("公司");

            row.CreateCell(1).SetCellValue("项目");
            row.CreateCell(2).SetCellValue("发货金额(销总金额)");
            row.CreateCell(3).SetCellValue("验收(发票)");
            row.CreateCell(4).SetCellValue("发货未开票");
            row.CreateCell(5).SetCellValue("已付款");
            row.CreateCell(6).SetCellValue("账面欠款");
            row.CreateCell(7).SetCellValue("进场未验收");
            row.CreateCell(8).SetCellValue("总欠款");
            row.CreateCell(9).SetCellValue("未对账");
            row.CreateCell(10).SetCellValue("对账未开票");
            row.CreateCell(11).SetCellValue("已对账");

            //2.2设置列宽度
            sheet.SetColumnWidth(0, 20 * 256);//时间
            sheet.SetColumnWidth(1, 20 * 256);//对账
            sheet.SetColumnWidth(2, 20 * 256);//开票日期
            sheet.SetColumnWidth(3, 20 * 256);//发票
            sheet.SetColumnWidth(4, 20 * 256);//收款日期
            sheet.SetColumnWidth(5, 20 * 256);//收款
            sheet.SetColumnWidth(6, 20 * 256);//收款
            sheet.SetColumnWidth(7, 20 * 256);//收款
            sheet.SetColumnWidth(8, 20 * 256);//收款
            sheet.SetColumnWidth(9, 20 * 256);//收款
            sheet.SetColumnWidth(10, 20 * 256);//收款
            sheet.SetColumnWidth(11, 20 * 256);//收款

            decimal[] total = new decimal[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //3.插入行和单元格
            for (int i = 0; i != list.Count; ++i)
            {
                //创建单元格
                row = sheet.CreateRow(i + 1);
                ////设置行高
                //row.HeightInPoints = 50;
                //设置值

                row.CreateCell(0).SetCellValue(list[i].Corporation);
                row.CreateCell(1).SetCellValue(list[i].Project);
                row.CreateCell(2).SetCellValue(DecimalHandler.DecimalToString(list[i].TotalSale, 2));
                row.CreateCell(3).SetCellValue(DecimalHandler.DecimalToString(list[i].InvoiceNum, 2));
                row.CreateCell(4).SetCellValue(DecimalHandler.DecimalToString(list[i].FaHuoWeiKaiPiao, 2));
                row.CreateCell(5).SetCellValue(DecimalHandler.DecimalToString(list[i].ReceiptNum, 2));
                row.CreateCell(6).SetCellValue(DecimalHandler.DecimalToString(list[i].ZhangMianQianKuan, 2));
                row.CreateCell(7).SetCellValue(DecimalHandler.DecimalToString(list[i].JinChangWeiYanShou, 2));
                row.CreateCell(8).SetCellValue(DecimalHandler.DecimalToString(list[i].ZongQianKuan, 2));
                row.CreateCell(9).SetCellValue(DecimalHandler.DecimalToString(list[i].WeiDuiZhang, 2));
                row.CreateCell(10).SetCellValue(DecimalHandler.DecimalToString(list[i].DuiZhangWeiKaiPiao, 2));
                row.CreateCell(11).SetCellValue(DecimalHandler.DecimalToString(list[i].DuiZhangNum, 2));
                total[0] += list[i].TotalSale;
                total[1] += list[i].InvoiceNum;
                total[2] += list[i].FaHuoWeiKaiPiao;
                total[3] += list[i].ReceiptNum;
                total[4] += list[i].ZhangMianQianKuan;
                total[5] += list[i].JinChangWeiYanShou;
                total[6] += list[i].ZongQianKuan;
                total[7] += list[i].WeiDuiZhang;
                total[8] += list[i].DuiZhangWeiKaiPiao;
                total[9] += list[i].DuiZhangNum;

            }
            //统计的一行
            row = sheet.CreateRow(list.Count + 1);
            row.CreateCell(0);
            row.CreateCell(1).SetCellValue("合计");
            row.CreateCell(2).SetCellValue(DecimalHandler.DecimalToString(total[0], 2));
            row.CreateCell(3).SetCellValue(DecimalHandler.DecimalToString(total[1], 2));
            row.CreateCell(4).SetCellValue(DecimalHandler.DecimalToString(total[2], 2));
            row.CreateCell(5).SetCellValue(DecimalHandler.DecimalToString(total[3], 2));
            row.CreateCell(6).SetCellValue(DecimalHandler.DecimalToString(total[4], 2));
            row.CreateCell(7).SetCellValue(DecimalHandler.DecimalToString(total[5], 2));
            row.CreateCell(8).SetCellValue(DecimalHandler.DecimalToString(total[6], 2));
            row.CreateCell(9).SetCellValue(DecimalHandler.DecimalToString(total[7], 2));
            row.CreateCell(10).SetCellValue(DecimalHandler.DecimalToString(total[8], 2));
            row.CreateCell(11).SetCellValue(DecimalHandler.DecimalToString(total[9], 2));

            //4.1设置对齐风格和边框
            ICellStyle style = wkbook.CreateCellStyle();
            style.VerticalAlignment = VerticalAlignment.Center;
            style.Alignment = HorizontalAlignment.Right;
            style.BorderTop = BorderStyle.Thin;
            style.BorderBottom = BorderStyle.Thin;
            style.BorderLeft = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            short color = style.FillForegroundColor;
            for (int i = 0; i <= sheet.LastRowNum; i++)
            {
                row = sheet.GetRow(i);
                if (i == 0)
                {
                    style.FillForegroundColor = HSSFColor.BlueGrey.Index;
                    style.FillPattern = FillPattern.SolidForeground;
                }
                else
                {
                    style.FillForegroundColor = color;
                    style.FillPattern = FillPattern.NoFill;
                }
                for (int c = 0; c < row.LastCellNum; ++c)
                {
                    row.GetCell(c).CellStyle = style;
                }
            }
            ////4.2合并单元格
            //sheet.AddMergedRegion(new CellRangeAddress(1, sheet.LastRowNum, 12, 12));
            //sheet.AddMergedRegion(new CellRangeAddress(1, sheet.LastRowNum, 13, 13));
            //5.执行写入磁盘
            string dstName = GlobalUtils.ShowSaveFileDlg(list[0].Corporation + "_" + list[0].Project + "_汇总.xls", "office 2003 excel|*.xls");
            return SaveFile(dstName, wkbook);
        }


    }
}