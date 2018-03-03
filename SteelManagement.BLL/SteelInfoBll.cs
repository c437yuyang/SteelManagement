using System;
using System.Data;
using System.Collections.Generic;
using SteelManagement.Model;
namespace SteelManagement.BLL
{
	/// <summary>
	/// SteelInfo
	/// </summary>
	public partial class SteelInfo
	{
	    public List<Model.SteelInfo> GetListByPageOrderByEntryTime(string strWhere, int pageSize,int pageNo)
	    {
            int start = (pageNo - 1) * pageSize + 1;
            int end = pageNo * pageSize;
	        var ds =  GetListByPage(string.Empty, " entrytime desc ", start, end);
	        return DataTableToList(ds.Tables[0]);
        }

	    public int AddList(List<Model.SteelInfo> list)
	    {
	        int res = 0;
	        foreach (var steelInfo in list)
	        {
	            res += dal.Add(steelInfo);
	        }
	        return res;
	    }

    }
}

