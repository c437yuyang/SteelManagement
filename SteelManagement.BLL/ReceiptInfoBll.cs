using System;
using System.Data;
using System.Collections.Generic;
using SteelManagement.Model;
namespace SteelManagement.BLL
{
    /// <summary>
    /// ReceiptInfo
    /// </summary>
    public partial class ReceiptInfo
    {
        public List<Model.ReceiptInfo> GetListByPageOrderById(string strWhere, int pageNo, int pageSize)
        {
            int start = (pageNo - 1) * pageSize + 1;
            int end = pageNo * pageSize;
            var ds = GetListByPage(strWhere, " id desc ", start, end);
            return DataTableToList(ds.Tables[0]);
        }

        public int AddList(List<Model.ReceiptInfo> list)
        {
            int res = 0;
            foreach (var ReceiptInfo in list)
            {
                res += dal.Add(ReceiptInfo) == 0 ? 0 : 1; //返回值是id
            }
            return res;
        }

        public int DeleteList(List<Model.ReceiptInfo> list)
        {
            int res = 0;
            foreach (var ReceiptInfo in list)
            {
                res += Delete(ReceiptInfo.Id) ? 1 : 0;
            }
            return res;
        }

    }
}

