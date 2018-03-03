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
        public List<Model.SteelInfo> GetListByPageOrderById(string strWhere, int pageNo, int pageSize)
        {
            int start = (pageNo - 1) * pageSize + 1;
            int end = pageNo * pageSize;
            var ds = GetListByPage(string.Empty, " id desc ", start, end);
            return DataTableToList(ds.Tables[0]);
        }

        public int AddList(List<Model.SteelInfo> list)
        {
            int res = 0;
            foreach (var steelInfo in list)
            {
                res += dal.Add(steelInfo) == 0 ? 0 : 1; //返回值是id
            }
            return res;
        }

        public int DeleteList(List<Model.SteelInfo> list)
        {
            int res = 0;
            foreach (var steelInfo in list)
            {
                res += Delete(steelInfo.Id) ? 1 : 0;
            }
            return res;
        }

    }
}

