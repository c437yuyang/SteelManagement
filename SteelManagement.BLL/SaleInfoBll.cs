using System;
using System.Data;
using System.Collections.Generic;
using SteelManagement.Model;
namespace SteelManagement.BLL
{
    /// <summary>
    /// SaleInfo
    /// </summary>
    public partial class SaleInfo
    {
        public List<Model.SaleInfo> GetListByPageOrderById(string strWhere, int pageNo, int pageSize)
        {
            int start = (pageNo - 1) * pageSize + 1;
            int end = pageNo * pageSize;
            var ds = GetListByPage(string.Empty, " id desc ", start, end);
            return DataTableToList(ds.Tables[0]);
        }

        public int AddList(List<Model.SaleInfo> list)
        {
            int res = 0;
            foreach (var SaleInfo in list)
            {
                res += dal.Add(SaleInfo) == 0 ? 0 : 1; //返回值是id
            }
            return res;
        }

        public int DeleteList(List<Model.SaleInfo> list)
        {
            int res = 0;
            foreach (var SaleInfo in list)
            {
                res += Delete(SaleInfo.Id) ? 1 : 0;
            }
            return res;
        }

    }
}

