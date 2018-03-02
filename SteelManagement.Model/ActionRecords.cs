using System;
namespace SteelManagement.Model
{
	/// <summary>
	/// ActionRecords:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ActionRecords
	{
		public ActionRecords()
		{}
		#region Model
		private int _id;
		private DateTime? _entrytime;
		private int? _userid;
		private string _acttype;
		private int? _actid;
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
		public int? UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActType
		{
			set{ _acttype=value;}
			get{return _acttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ActId
		{
			set{ _actid=value;}
			get{return _actid;}
		}
		#endregion Model

	}
}

