using System;
namespace SteelManagement.Model
{
	/// <summary>
	/// SaleBill:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SaleBill
	{
		public SaleBill()
		{}
		#region Model
		private int _id;
		private DateTime? _entrytime;
		private string _supplier;
		private decimal? _amount;
		private decimal? _duizhnag;
		private DateTime? _invoicedate;
		private decimal? _invoicenum;
		private DateTime? _receiptdate;
		private decimal? _receiptnum;
		private string _corporation;
		private string _project;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EntryTime
		{
			set{ _entrytime=value;}
			get{return _entrytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Supplier
		{
			set{ _supplier=value;}
			get{return _supplier;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DuiZhnag
		{
			set{ _duizhnag=value;}
			get{return _duizhnag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InvoiceDate
		{
			set{ _invoicedate=value;}
			get{return _invoicedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? InvoiceNum
		{
			set{ _invoicenum=value;}
			get{return _invoicenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ReceiptDate
		{
			set{ _receiptdate=value;}
			get{return _receiptdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ReceiptNum
		{
			set{ _receiptnum=value;}
			get{return _receiptnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Corporation
		{
			set{ _corporation=value;}
			get{return _corporation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Project
		{
			set{ _project=value;}
			get{return _project;}
		}
		#endregion Model

	}
}

