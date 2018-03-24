using System;
namespace SteelManagement.Model
{
    /// <summary>
    /// SaleBill:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class SupplierBill
    {
        public SupplierBill()
        { }


        public string Corporation { get; set; }
        public string Project { get; set; }
        public string Supplier { get; set; }
        public decimal TotalPurchase { get; set; } //购进总额
        public decimal PurchaseAmount { get; set; } //购进重量
        public decimal TotalSale { get; set; } //销售总额
        public decimal SaleAmount { get; set; } //销售重量
        public decimal TransportCost { get; set; } //运费


        //自动更新
        public decimal MarginRate//利润率
        {
            get
            {
                if (TotalSale == 0 || TotalPurchase == 0)
                    return -1;
                return (TotalSale / TotalPurchase) - 1;
            }
        } 


        

    }
}

