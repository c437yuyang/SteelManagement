using System;
using System.Data;
using System.Collections.Generic;
using SteelManagement.Model;
namespace SteelManagement.BLL
{
    /// <summary>
    /// AuthUser
    /// </summary>
    public partial class AuthUser
    {
        public List<Model.AuthUser> GetListByPageOrderById(string strWhere, int pageNo, int pageSize)
        {
            int start = (pageNo - 1) * pageSize + 1;
            int end = pageNo * pageSize;
            var ds = GetListByPage(strWhere, " id desc ", start, end);
            return DataTableToList(ds.Tables[0]);
        }

        public int AddList(List<Model.AuthUser> list)
        {
            int res = 0;
            foreach (var AuthUser in list)
            {
                res += dal.Add(AuthUser) == 0 ? 0 : 1; //返回值是id
            }
            return res;
        }

        public int DeleteList(List<Model.AuthUser> list)
        {
            int res = 0;
            foreach (var AuthUser in list)
            {
                res += Delete(AuthUser.Id) ? 1 : 0;
            }
            return res;
        }

    }
}

