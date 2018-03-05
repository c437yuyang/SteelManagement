using System;
namespace SteelManagement.Model
{
	/// <summary>
	/// ReceiptInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ReceiptInfo
	{
		public ReceiptInfo()
		{}
		#region Model
		private int _id;
		private DateTime? _entrytime;
		private string _serialno;
		private DateTime? _invoicedate;
		private DateTime? _receiptdate;
		private decimal? _invoicenum;
		private decimal? _receiptnum;
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
		public string SerialNo
		{
			set{ _serialno=value;}
			get{return _serialno;}
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
		public DateTime? ReceiptDate
		{
			set{ _receiptdate=value;}
			get{return _receiptdate;}
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
		public decimal? ReceiptNum
		{
			set{ _receiptnum=value;}
			get{return _receiptnum;}
		}
		#endregion Model

	}
}

