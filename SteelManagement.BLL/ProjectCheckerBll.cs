using System;
using System.Data;
using System.Collections.Generic;
using SteelManagement.Model;
namespace SteelManagement.BLL
{
    /// <summary>
    /// ProjectChecker
    /// </summary>
    public partial class ProjectChecker
    {
        //bool Exist(string project,string username)
        //   {
        //       //return GetModelList()
        //   }


        public bool Delete(string username, string project)
        {
            var list = GetModelList(" UserName = '" + username + "' and Project ='" + project + "' ");
            if (list == null || list.Count <= 0)
                return false;

            return Delete(list[0].Id);
        }

        public List<string> GetUserCheckProjects(string username)
        {
            var list = GetModelList(" UserName = '" + username + "' ");
            if (list == null || list.Count == 0)
                return null;

            List<string> res = new List<string>();
            foreach (var item in list)
            {
                res.Add(item.Project);
            }
            return res;
        }

    }
}

