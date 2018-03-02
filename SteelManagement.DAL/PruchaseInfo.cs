using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace SteelManagement.DAL
{
	/// <summary>
	/// 数据访问类:PruchaseInfo
	/// </summary>
	public partial class PruchaseInfo
	{
		public PruchaseInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "PruchaseInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PruchaseInfo");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SteelManagement.Model.PruchaseInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PruchaseInfo(");
			strSql.Append("EntryTime,Project,Dateline,Supplier,Brand,TransportWay,Size,Texture,Amount,Quote,Fluctuation1,TransportCost,Price,TotalMoney,FuYuDate,Money1,InvoiceDate,Money2)");
			strSql.Append(" values (");
			strSql.Append("@EntryTime,@Project,@Dateline,@Supplier,@Brand,@TransportWay,@Size,@Texture,@Amount,@Quote,@Fluctuation1,@TransportCost,@Price,@TotalMoney,@FuYuDate,@Money1,@InvoiceDate,@Money2)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EntryTime", SqlDbType.DateTime),
					new SqlParameter("@Project", SqlDbType.VarChar,50),
					new SqlParameter("@Dateline", SqlDbType.Date,3),
					new SqlParameter("@Supplier", SqlDbType.VarChar,50),
					new SqlParameter("@Brand", SqlDbType.VarChar,50),
					new SqlParameter("@TransportWay", SqlDbType.VarChar,50),
					new SqlParameter("@Size", SqlDbType.VarChar,50),
					new SqlParameter("@Texture", SqlDbType.VarChar,50),
					new SqlParameter("@Amount", SqlDbType.Money,8),
					new SqlParameter("@Quote", SqlDbType.Money,8),
					new SqlParameter("@Fluctuation1", SqlDbType.Money,8),
					new SqlParameter("@TransportCost", SqlDbType.Money,8),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@TotalMoney", SqlDbType.Money,8),
					new SqlParameter("@FuYuDate", SqlDbType.Date,3),
					new SqlParameter("@Money1", SqlDbType.Money,8),
					new SqlParameter("@InvoiceDate", SqlDbType.Date,3),
					new SqlParameter("@Money2", SqlDbType.Money,8)};
			parameters[0].Value = model.EntryTime;
			parameters[1].Value = model.Project;
			parameters[2].Value = model.Dateline;
			parameters[3].Value = model.Supplier;
			parameters[4].Value = model.Brand;
			parameters[5].Value = model.TransportWay;
			parameters[6].Value = model.Size;
			parameters[7].Value = model.Texture;
			parameters[8].Value = model.Amount;
			parameters[9].Value = model.Quote;
			parameters[10].Value = model.Fluctuation1;
			parameters[11].Value = model.TransportCost;
			parameters[12].Value = model.Price;
			parameters[13].Value = model.TotalMoney;
			parameters[14].Value = model.FuYuDate;
			parameters[15].Value = model.Money1;
			parameters[16].Value = model.InvoiceDate;
			parameters[17].Value = model.Money2;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SteelManagement.Model.PruchaseInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PruchaseInfo set ");
			strSql.Append("EntryTime=@EntryTime,");
			strSql.Append("Project=@Project,");
			strSql.Append("Dateline=@Dateline,");
			strSql.Append("Supplier=@Supplier,");
			strSql.Append("Brand=@Brand,");
			strSql.Append("TransportWay=@TransportWay,");
			strSql.Append("Size=@Size,");
			strSql.Append("Texture=@Texture,");
			strSql.Append("Amount=@Amount,");
			strSql.Append("Quote=@Quote,");
			strSql.Append("Fluctuation1=@Fluctuation1,");
			strSql.Append("TransportCost=@TransportCost,");
			strSql.Append("Price=@Price,");
			strSql.Append("TotalMoney=@TotalMoney,");
			strSql.Append("FuYuDate=@FuYuDate,");
			strSql.Append("Money1=@Money1,");
			strSql.Append("InvoiceDate=@InvoiceDate,");
			strSql.Append("Money2=@Money2");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@EntryTime", SqlDbType.DateTime),
					new SqlParameter("@Project", SqlDbType.VarChar,50),
					new SqlParameter("@Dateline", SqlDbType.Date,3),
					new SqlParameter("@Supplier", SqlDbType.VarChar,50),
					new SqlParameter("@Brand", SqlDbType.VarChar,50),
					new SqlParameter("@TransportWay", SqlDbType.VarChar,50),
					new SqlParameter("@Size", SqlDbType.VarChar,50),
					new SqlParameter("@Texture", SqlDbType.VarChar,50),
					new SqlParameter("@Amount", SqlDbType.Money,8),
					new SqlParameter("@Quote", SqlDbType.Money,8),
					new SqlParameter("@Fluctuation1", SqlDbType.Money,8),
					new SqlParameter("@TransportCost", SqlDbType.Money,8),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@TotalMoney", SqlDbType.Money,8),
					new SqlParameter("@FuYuDate", SqlDbType.Date,3),
					new SqlParameter("@Money1", SqlDbType.Money,8),
					new SqlParameter("@InvoiceDate", SqlDbType.Date,3),
					new SqlParameter("@Money2", SqlDbType.Money,8),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.EntryTime;
			parameters[1].Value = model.Project;
			parameters[2].Value = model.Dateline;
			parameters[3].Value = model.Supplier;
			parameters[4].Value = model.Brand;
			parameters[5].Value = model.TransportWay;
			parameters[6].Value = model.Size;
			parameters[7].Value = model.Texture;
			parameters[8].Value = model.Amount;
			parameters[9].Value = model.Quote;
			parameters[10].Value = model.Fluctuation1;
			parameters[11].Value = model.TransportCost;
			parameters[12].Value = model.Price;
			parameters[13].Value = model.TotalMoney;
			parameters[14].Value = model.FuYuDate;
			parameters[15].Value = model.Money1;
			parameters[16].Value = model.InvoiceDate;
			parameters[17].Value = model.Money2;
			parameters[18].Value = model.Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PruchaseInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PruchaseInfo ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SteelManagement.Model.PruchaseInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,EntryTime,Project,Dateline,Supplier,Brand,TransportWay,Size,Texture,Amount,Quote,Fluctuation1,TransportCost,Price,TotalMoney,FuYuDate,Money1,InvoiceDate,Money2 from PruchaseInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			SteelManagement.Model.PruchaseInfo model=new SteelManagement.Model.PruchaseInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SteelManagement.Model.PruchaseInfo DataRowToModel(DataRow row)
		{
			SteelManagement.Model.PruchaseInfo model=new SteelManagement.Model.PruchaseInfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["EntryTime"]!=null && row["EntryTime"].ToString()!="")
				{
					model.EntryTime=DateTime.Parse(row["EntryTime"].ToString());
				}
				if(row["Project"]!=null)
				{
					model.Project=row["Project"].ToString();
				}
				if(row["Dateline"]!=null && row["Dateline"].ToString()!="")
				{
					model.Dateline=DateTime.Parse(row["Dateline"].ToString());
				}
				if(row["Supplier"]!=null)
				{
					model.Supplier=row["Supplier"].ToString();
				}
				if(row["Brand"]!=null)
				{
					model.Brand=row["Brand"].ToString();
				}
				if(row["TransportWay"]!=null)
				{
					model.TransportWay=row["TransportWay"].ToString();
				}
				if(row["Size"]!=null)
				{
					model.Size=row["Size"].ToString();
				}
				if(row["Texture"]!=null)
				{
					model.Texture=row["Texture"].ToString();
				}
				if(row["Amount"]!=null && row["Amount"].ToString()!="")
				{
					model.Amount=decimal.Parse(row["Amount"].ToString());
				}
				if(row["Quote"]!=null && row["Quote"].ToString()!="")
				{
					model.Quote=decimal.Parse(row["Quote"].ToString());
				}
				if(row["Fluctuation1"]!=null && row["Fluctuation1"].ToString()!="")
				{
					model.Fluctuation1=decimal.Parse(row["Fluctuation1"].ToString());
				}
				if(row["TransportCost"]!=null && row["TransportCost"].ToString()!="")
				{
					model.TransportCost=decimal.Parse(row["TransportCost"].ToString());
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["TotalMoney"]!=null && row["TotalMoney"].ToString()!="")
				{
					model.TotalMoney=decimal.Parse(row["TotalMoney"].ToString());
				}
				if(row["FuYuDate"]!=null && row["FuYuDate"].ToString()!="")
				{
					model.FuYuDate=DateTime.Parse(row["FuYuDate"].ToString());
				}
				if(row["Money1"]!=null && row["Money1"].ToString()!="")
				{
					model.Money1=decimal.Parse(row["Money1"].ToString());
				}
				if(row["InvoiceDate"]!=null && row["InvoiceDate"].ToString()!="")
				{
					model.InvoiceDate=DateTime.Parse(row["InvoiceDate"].ToString());
				}
				if(row["Money2"]!=null && row["Money2"].ToString()!="")
				{
					model.Money2=decimal.Parse(row["Money2"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,EntryTime,Project,Dateline,Supplier,Brand,TransportWay,Size,Texture,Amount,Quote,Fluctuation1,TransportCost,Price,TotalMoney,FuYuDate,Money1,InvoiceDate,Money2 ");
			strSql.Append(" FROM PruchaseInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,EntryTime,Project,Dateline,Supplier,Brand,TransportWay,Size,Texture,Amount,Quote,Fluctuation1,TransportCost,Price,TotalMoney,FuYuDate,Money1,InvoiceDate,Money2 ");
			strSql.Append(" FROM PruchaseInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM PruchaseInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from PruchaseInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "PruchaseInfo";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

