using System.Collections.Generic;
using SteelManagement.DAL;

namespace SteelManagement.BLL
{
    public class CommonBll
    {
        public static List<string> GetFieldList(string tableName, string filedName)
        {
            return CommonDal.GetFieldList(tableName, filedName);
        }
    }
}