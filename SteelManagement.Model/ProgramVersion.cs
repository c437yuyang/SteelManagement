using System;
namespace SteelManagement.Model
{
	/// <summary>
	/// ProgramVersion:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ProgramVersion
	{
		public ProgramVersion()
		{}
		#region Model
		private int _id;
		private decimal? _version;
		private string _update_files;
		private string _udapte_details;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? version
		{
			set{ _version=value;}
			get{return _version;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string update_files
		{
			set{ _update_files=value;}
			get{return _update_files;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string udapte_details
		{
			set{ _udapte_details=value;}
			get{return _udapte_details;}
		}
		#endregion Model

	}
}

