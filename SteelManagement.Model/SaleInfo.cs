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
		private string _serialno;
		private int? _operatorid;
		private string _corporation;
		private string _project;
		private decimal? _lixi;
		private decimal? _tiexi;
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
		/// 检尺率
		/// </summary>
		public decimal? JianChiLv
		{
			set{ _jianchilv=value;}
			get{return _jianchilv;}
		}
		/// <summary>
		/// 到货时间
		/// </summary>
		public DateTime? ArrivalTime
		{
			set{ _arrivaltime=value;}
			get{return _arrivaltime;}
		}
		/// <summary>
		/// 结算时间
		/// </summary>
		public DateTime? SettleTime
		{
			set{ _settletime=value;}
			get{return _settletime;}
		}
		/// <summary>
		/// 供应商
		/// </summary>
		public string Supplier
		{
			set{ _supplier=value;}
			get{return _supplier;}
		}
		/// <summary>
		/// 品牌
		/// </summary>
		public string Brand
		{
			set{ _brand=value;}
			get{return _brand;}
		}
		/// <summary>
		/// 运输方式
		/// </summary>
		public string TransportWay
		{
			set{ _transportway=value;}
			get{return _transportway;}
		}
		/// <summary>
		/// 材质
		/// </summary>
		public string Size
		{
			set{ _size=value;}
			get{return _size;}
		}
		/// <summary>
		/// 规格
		/// </summary>
		public string Texture
		{
			set{ _texture=value;}
			get{return _texture;}
		}
		/// <summary>
		/// 送货重量
		/// </summary>
		public decimal? Amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 价差
		/// </summary>
		public decimal? Margin
		{
			set{ _margin=value;}
			get{return _margin;}
		}
		/// <summary>
		/// 网价
		/// </summary>
		public decimal? OnlinePrice
		{
			set{ _onlineprice=value;}
			get{return _onlineprice;}
		}
		/// <summary>
		/// 浮动1
		/// </summary>
		public decimal? Fluctuation1
		{
			set{ _fluctuation1=value;}
			get{return _fluctuation1;}
		}
		/// <summary>
		/// 浮动2
		/// </summary>
		public decimal? Fluctuation2
		{
			set{ _fluctuation2=value;}
			get{return _fluctuation2;}
		}
		/// <summary>
		/// 销售单价
		/// </summary>
		public decimal? SalePrice
		{
			set{ _saleprice=value;}
			get{return _saleprice;}
		}
		/// <summary>
		/// 销售总金额
		/// </summary>
		public decimal? TotalSale
		{
			set{ _totalsale=value;}
			get{return _totalsale;}
		}
		/// <summary>
		/// 利润率
		/// </summary>
		public decimal? MarginRate
		{
			set{ _marginrate=value;}
			get{return _marginrate;}
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
		public int? OperatorId
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
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
		/// <summary>
		/// 
		/// </summary>
		public decimal? LiXi
		{
			set{ _lixi=value;}
			get{return _lixi;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TieXi
		{
			set{ _tiexi=value;}
			get{return _tiexi;}
		}
		#endregion Model

	}
}

