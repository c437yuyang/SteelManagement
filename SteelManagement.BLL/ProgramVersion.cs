using System;
using System.Data;
using System.Collections.Generic;
using SteelManagement.Model;
namespace SteelManagement.BLL
{
	/// <summary>
	/// ProgramVersion
	/// </summary>
	public partial class ProgramVersion
	{
		private readonly SteelManagement.DAL.ProgramVersion dal=new SteelManagement.DAL.ProgramVersion();
		public ProgramVersion()
		{}
        #region  BasicMethod

	    /// <summary>
	    /// 得到最大ID
	    /// </summary>
	    public int GetMaxId()
	    {
	        return dal.GetMaxId();
	    }

	    /// <summary>
	    /// 是否存在该记录
	    /// </summary>
	    public bool Exists(int id)
	    {
	        return dal.Exists(id);
	    }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int  Add(SteelManagement.Model.ProgramVersion model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SteelManagement.Model.ProgramVersion model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SteelManagement.Model.ProgramVersion GetModel(int id)
		{
			
			return dal.GetModel(id);
		}



		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SteelManagement.Model.ProgramVersion> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SteelManagement.Model.ProgramVersion> DataTableToList(DataTable dt)
		{
			List<SteelManagement.Model.ProgramVersion> modelList = new List<SteelManagement.Model.ProgramVersion>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				SteelManagement.Model.ProgramVersion model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

