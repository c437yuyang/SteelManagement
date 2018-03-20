using System;
namespace SteelManagement.Model
{
	/// <summary>
	/// PurchaseBill:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PurchaseBill
	{
		public PurchaseBill()
		{}
		#region Model
		private int _id;
		private DateTime? _entrytime;
		private string _serialno;
		private string _corporation;
		private string _project;
		private int? _operatorid;
		private string _supplier;
		private decimal? _amount;
		private string _payer;
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
		public int? OperatorId
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
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
		public string Payer
		{
			set{ _payer=value;}
			get{return _payer;}
		}
		#endregion Model

	}
}

