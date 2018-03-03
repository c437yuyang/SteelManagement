using System;
using System.Data;
using System.Collections.Generic;
using SteelManagement.Model;
namespace SteelManagement.BLL
{
    /// <summary>
    /// PurchaseInfo
    /// </summary>
    public partial class PurchaseInfo
    {
        public List<Model.PurchaseInfo> GetListByPageOrderById(string strWhere, int pageNo, int pageSize)
        {
            int start = (pageNo - 1) * pageSize + 1;
            int end = pageNo * pageSize;
            var ds = GetListByPage(string.Empty, " id desc ", start, end);
            return DataTableToList(ds.Tables[0]);
        }

        public int AddList(List<Model.PurchaseInfo> list)
        {
            int res = 0;
            foreach (var PurchaseInfo in list)
            {
                res += dal.Add(PurchaseInfo) == 0 ? 0 : 1; //返回值是id
            }
            return res;
        }

        public int DeleteList(List<Model.PurchaseInfo> list)
        {
            int res = 0;
            foreach (var PurchaseInfo in list)
            {
                res += Delete(PurchaseInfo.Id) ? 1 : 0;
            }
            return res;
        }

    }
}

