using System;
using System.Data;
using System.Collections.Generic;
using SteelManagement.Model;
namespace SteelManagement.BLL
{
    /// <summary>
    /// PurchaseBill
    /// </summary>
    public partial class PurchaseBill
    {
        public List<Model.PurchaseBill> GetListByPageOrderById(string strWhere, int pageNo, int pageSize)
        {
            int start = (pageNo - 1) * pageSize + 1;
            int end = pageNo * pageSize;
            var ds = GetListByPage(strWhere, " id desc ", start, end);
            return DataTableToList(ds.Tables[0]);
        }

        public int AddList(List<Model.PurchaseBill> list)
        {
            int res = 0;
            foreach (var PurchaseBill in list)
            {
                res += dal.Add(PurchaseBill) == 0 ? 0 : 1; //返回值是id
            }
            return res;
        }

        public int DeleteList(List<Model.PurchaseBill> list)
        {
            int res = 0;
            foreach (var PurchaseBill in list)
            {
                res += Delete(PurchaseBill.Id) ? 1 : 0;
            }
            return res;
        }

    }
}

