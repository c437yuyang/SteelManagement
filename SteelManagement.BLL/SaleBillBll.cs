using System;
using System.Data;
using System.Collections.Generic;
using SteelManagement.Model;
namespace SteelManagement.BLL
{
    /// <summary>
    /// SaleBill
    /// </summary>
    public partial class SaleBill
    {
        public List<Model.SaleBill> GetListByPageOrderById(string strWhere, int pageNo, int pageSize)
        {
            int start = (pageNo - 1) * pageSize + 1;
            int end = pageNo * pageSize;
            var ds = GetListByPage(strWhere, " id desc ", start, end);
            return DataTableToList(ds.Tables[0]);
        }

        public int AddList(List<Model.SaleBill> list)
        {
            int res = 0;
            foreach (var SaleBill in list)
            {
                res += dal.Add(SaleBill) == 0 ? 0 : 1; //返回值是id
            }
            return res;
        }

        public int DeleteList(List<Model.SaleBill> list)
        {
            int res = 0;
            foreach (var SaleBill in list)
            {
                res += Delete(SaleBill.Id) ? 1 : 0;
            }
            return res;
        }

    }
}

