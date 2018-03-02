using System;
namespace SteelManagement.Model
{
	/// <summary>
	/// AuthDept:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AuthDept
	{
		public AuthDept()
		{}
		#region Model
		private int _id;
		private DateTime? _entrytime;
		private int? _parentdeptid;
		private string _deptname;
		private int? _chargepersonid;
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
		public int? ParentDeptID
		{
			set{ _parentdeptid=value;}
			get{return _parentdeptid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptName
		{
			set{ _deptname=value;}
			get{return _deptname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ChargePersonId
		{
			set{ _chargepersonid=value;}
			get{return _chargepersonid;}
		}
		#endregion Model

	}
}

