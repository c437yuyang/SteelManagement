﻿using System;
namespace SteelManagement.Model
{
	/// <summary>
	/// PurchaseInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PurchaseInfo
	{
		public PurchaseInfo()
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
		private string _serialno;
		private int? _operatorid;
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
		/// 项目
		/// </summary>
		public string Project
		{
			set{ _project=value;}
			get{return _project;}
		}
		/// <summary>
		/// 日期
		/// </summary>
		public DateTime? Dateline
		{
			set{ _dateline=value;}
			get{return _dateline;}
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
		/// 送货量
		/// </summary>
		public decimal? Amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 报价
		/// </summary>
		public decimal? Quote
		{
			set{ _quote=value;}
			get{return _quote;}
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
		/// 运费
		/// </summary>
		public decimal? TransportCost
		{
			set{ _transportcost=value;}
			get{return _transportcost;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 总金额
		/// </summary>
		public decimal? TotalMoney
		{
			set{ _totalmoney=value;}
			get{return _totalmoney;}
		}
		/// <summary>
		/// 付宇通汇日期
		/// </summary>
		public DateTime? FuYuDate
		{
			set{ _fuyudate=value;}
			get{return _fuyudate;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public decimal? Money1
		{
			set{ _money1=value;}
			get{return _money1;}
		}
		/// <summary>
		/// 开票日期
		/// </summary>
		public DateTime? InvoiceDate
		{
			set{ _invoicedate=value;}
			get{return _invoicedate;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public decimal? Money2
		{
			set{ _money2=value;}
			get{return _money2;}
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
		#endregion Model

	}
}

