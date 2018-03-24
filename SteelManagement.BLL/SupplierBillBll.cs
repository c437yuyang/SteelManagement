using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using SteelManagement.Model;

namespace SteelManagement.BLL
{
    public class SupplierBill
    {
        private BLL.SaleInfo _bllSaleInfo = new BLL.SaleInfo();
        private BLL.PurchaseInfo _bllPurchaseInfo = new BLL.PurchaseInfo();

        //现在只考虑了项目名，没有考虑进不同公司项目名相同的情况
        public List<Model.SupplierBill> GetModelList(string where)
        {
            var list = DAL.SupplierDal.GetModelList(where);

            foreach (var supplier in list)
            {
                FillModel(supplier);
            }

            return list;
        }

        private void FillModel(Model.SupplierBill supplier)
        {
            List<Model.PurchaseInfo> purchaseList = _bllPurchaseInfo.GetModelList(
                string.Format(" Corporation = '{0}' and Project = '{1}' and Supplier = '{2}'",
                supplier.Corporation, supplier.Project, supplier.Supplier));

            foreach (var model in purchaseList)
            {
                supplier.TotalPurchase += model.TotalMoney ?? 0;
                supplier.PurchaseAmount += model.Amount ?? 0;
                supplier.TransportCost += model.TransportCost ?? 0;
            }


            List<Model.SaleInfo> saleInfoList = _bllSaleInfo.GetModelList(
    string.Format(" Corporation = '{0}' and Project = '{1}' and Supplier = '{2}'",
    supplier.Corporation, supplier.Project, supplier.Supplier));

            foreach (var model in saleInfoList)
            {
                supplier.TotalSale += model.TotalSale ?? 0;
                supplier.SaleAmount += model.Amount ?? 0;
            }

        }
    }
}