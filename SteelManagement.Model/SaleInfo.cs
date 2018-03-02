using System;
namespace SteelManagement.Model
{
	/// <summary>
	/// SaleInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SaleInfo
	{
		public SaleInfo()
		{}
		#region Model
		private int _id;
		private DateTime? _entrytime;
		private decimal? _jianchilv;
		private DateTime? _arrivaltime;
		private DateTime? _settletime;
		private string _supplier;
		private string _brand;
		private string _transportway;
		private string _size;
		private string _texture;
		private decimal? _amount;
		private decimal? _margin;
		private decimal? _onlineprice;
		private decimal? _fluctuation1;
		private decimal? _fluctuation2;
		private decimal? _saleprice;
		private decimal? _totalsale;
		private decimal? _marginrate;
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
		public decimal? JianChiLv
		{
			set{ _jianchilv=value;}
			get{return _jianchilv;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ArrivalTime
		{
			set{ _arrivaltime=value;}
			get{return _arrivaltime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SettleTime
		{
			set{ _settletime=value;}
			get{return _settletime;}
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
		public decimal? Margin
		{
			set{ _margin=value;}
			get{return _margin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OnlinePrice
		{
			set{ _onlineprice=value;}
			get{return _onlineprice;}
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
		public decimal? Fluctuation2
		{
			set{ _fluctuation2=value;}
			get{return _fluctuation2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SalePrice
		{
			set{ _saleprice=value;}
			get{return _saleprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalSale
		{
			set{ _totalsale=value;}
			get{return _totalsale;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MarginRate
		{
			set{ _marginrate=value;}
			get{return _marginrate;}
		}
		#endregion Model

	}
}

