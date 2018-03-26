using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace SteelManagement.DAL
{
    /// <summary>
    /// 数据访问类:ProgramUpdate
    /// </summary>
    public partial class ProgramUpdate
    {
        public Model.ProgramUpdate GetLatestModel()
        {
            string sql = "select top 1 * from ProgramUpdate order by Version desc";

            var ds = DbHelperSQL.Query(sql);
            try
            {
                if (ds != null)
                    return DataRowToModel(ds.Tables[0].Rows[0]);
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}

