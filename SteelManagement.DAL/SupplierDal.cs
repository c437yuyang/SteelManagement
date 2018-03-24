using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelManagement.DAL
{
    public class SupplierDal
    {
        public static List<Model.SupplierBill> GetModelList(string where)
        {
            
            string sql = "select distinct Corporation,Project,Supplier from SaleInfo"; //目前先从SaleInfo里面拿

            if (!string.IsNullOrEmpty(where))
                sql += " where " +  where + " ";

            DataSet ds = DbHelperSQL.Query(sql);
            List<Model.SupplierBill> res = new List<Model.SupplierBill>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Model.SupplierBill model = new Model.SupplierBill();
                    if (row["Corporation"] != null && row["Corporation"].ToString() != "")
                    {
                        model.Corporation = row["Corporation"].ToString();
                    }
                    if (row["Project"] != null && row["Project"].ToString() != "")
                    {
                        model.Project = row["Project"].ToString();
                    }

                    if (row["Supplier"] != null && row["Supplier"].ToString() != "")
                    {
                        model.Supplier = row["Supplier"].ToString();
                    }
                    res.Add(model);
                }
                return res;
            }
            else
            {
                return null;
            }
        }

    }
}
