using System;
namespace SteelManagement.Model
{
	/// <summary>
	/// PruchaseInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PruchaseInfo
	{
		public PruchaseInfo()
		{}
		#region Model
		private int _id;
		private DateTime? _entrytime;
		private string _project;
		private DateTime? _dateline;
		private string _supplier;
		private string _brand;
		private string _transportway;
		private string _size;
		private string _texture;
		private decimal? _amount;
		private decimal? _quote;
		private decimal? _fluctuation1;
		private decimal? _transportcost;
		private decimal? _price;
		private decimal? _totalmoney;
		private DateTime? _fuyudate;
		private decimal? _money1;
		private DateTime? _invoicedate;
		private decimal? _money2;
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
		public string Project
		{
			set{ _project=value;}
			get{return _project;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Dateline
		{
			set{ _dateline=value;}
			get{return _dateline;}
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
		public string Brand
		{
			set{ _brand=value;}
			get{return _brand;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TransportWay
		{
			set{ _transportway=value;}
			get{return _transportway;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Size
		{
			set{ _size=value;}
			get{return _size;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Texture
		{
			set{ _texture=value;}
			get{return _texture;}
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
		public decimal? Quote
		{
			set{ _quote=value;}
			get{return _quote;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Fluctuation1
		{
			set{ _fluctuation1=value;}
			get{return _fluctuation1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TransportCost
		{
			set{ _transportcost=value;}
			get{return _transportcost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalMoney
		{
			set{ _totalmoney=value;}
			get{return _totalmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? FuYuDate
		{
			set{ _fuyudate=value;}
			get{return _fuyudate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Money1
		{
			set{ _money1=value;}
			get{return _money1;}
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
		public decimal? Money2
		{
			set{ _money2=value;}
			get{return _money2;}
		}
		#endregion Model

	}
}

