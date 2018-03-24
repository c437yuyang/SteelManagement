using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using SteelManagement.Model;

namespace SteelManagement.BLL
{
    public class ProjectBill
    {
        private BLL.SaleInfo _bllSaleInfo = new BLL.SaleInfo();
        private BLL.SaleBill _bllSaleBill = new BLL.SaleBill();

        //现在只考虑了项目名，没有考虑进不同公司项目名相同的情况
        public List<Model.ProjectBill> GetModelList(string projectName)
        {
            List<string> projectList = new List<string>();
            if (string.IsNullOrEmpty(projectName) || projectName == "全部")
                projectList = CommonBll.GetFieldList("SaleInfo", "Project"); //TODO:这里取得话，得假设SaleInfo和SaleBill里面都具有相同的Project,按理说应该是现有SaleInfo再有SaleBill
            else
                projectList.Add(projectName);

            List<Model.ProjectBill> listRes = new List<Model.ProjectBill>();
            //计算指定项目的销售总额，先不考虑不同公司有相同项目名称的情况
            foreach (var project in projectList)
            {
                var projectBillModel = GetModelByProjectName(project);
                listRes.Add(projectBillModel);
            }
            return listRes;
        }

        private Model.ProjectBill GetModelByProjectName(string project)
        {
            Model.ProjectBill projectBillModel = new Model.ProjectBill();

            //查销售信息表拿到销售总金额
            var saleInfoList = _bllSaleInfo.GetModelList(" Project ='" + project + "' ");
            projectBillModel.Corporation = saleInfoList[0].Corporation;
            projectBillModel.Project = project;
            decimal totalSale = 0;
            foreach (var saleInfo in saleInfoList)
            {
                totalSale += saleInfo.TotalSale ?? 0;
            }
            projectBillModel.TotalSale = totalSale;

            //查款项信息表得到验收(发票)和对账和已付款(对应salebill的收款)
            var saleBillList = _bllSaleBill.GetModelList(" Project ='" + project + "' ");
            decimal receiptTotal = 0;
            decimal duiZhangTotal = 0;
            decimal invoiceTotal = 0;
            foreach (var saleBill in saleBillList)
            {
                receiptTotal += saleBill.ReceiptNum ?? 0;
                duiZhangTotal += saleBill.DuiZhang ?? 0;
                invoiceTotal += saleBill.InvoiceNum ?? 0;
            }
            projectBillModel.ReceiptNum = receiptTotal;
            projectBillModel.DuiZhangNum = duiZhangTotal;
            projectBillModel.InvoiceNum = invoiceTotal;
            return projectBillModel;
        }
    }
}