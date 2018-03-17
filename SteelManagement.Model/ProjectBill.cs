using System;
namespace SteelManagement.Model
{
	/// <summary>
	/// SaleBill:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ProjectBill
    {
		public ProjectBill()
		{}


        public string Corporation { get; set; }
        public string Project { get; set; }
        public decimal TotalSale { get; set; } //发货金额
        public decimal InvoiceNum { get; set; } //验收(发票)
        public decimal ReceiptNum { get; set; } //已付款
        public decimal DuiZhangNum { get; set; } //已对账


        //自动更新部分
        public decimal FaHuoWeiKaiPiao => TotalSale - InvoiceNum;

        public decimal ZhangMianQianKuan => InvoiceNum - ReceiptNum;
        public decimal JinChangWeiYanShou => WeiDuiZhang - DuiZhangWeiKaiPiao; //这个必须在未对账和对账未开票之前更新

        public decimal ZongQianKuan => TotalSale - ReceiptNum;
        public decimal WeiDuiZhang => TotalSale - DuiZhangNum;
        public decimal DuiZhangWeiKaiPiao => DuiZhangNum - InvoiceNum;

    }
}

