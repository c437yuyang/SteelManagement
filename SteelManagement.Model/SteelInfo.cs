using System;
namespace SteelManagement.Model
{
	/// <summary>
	/// SteelInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SteelInfo
	{
		public SteelInfo()
		{}
		#region Model
		private int _id;
		private DateTime? _entrytime;
		private string _name;
		private string _size;
		private string _texture;
		private string _produceplace;
		private decimal? _price;
		private decimal? _fluctuation;
		private string _remark;
		private string _state;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		public string ProducePlace
		{
			set{ _produceplace=value;}
			get{return _produceplace;}
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
		public decimal? Fluctuation
		{
			set{ _fluctuation=value;}
			get{return _fluctuation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

