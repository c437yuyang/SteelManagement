using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace SteelManagement.DAL
{
	/// <summary>
	/// 数据访问类:SaleInfo
	/// </summary>
	public partial class SaleInfo
	{
		public SaleInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "SaleInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SaleInfo");
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
		public int Add(SteelManagement.Model.SaleInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SaleInfo(");
			strSql.Append("EntryTime,JianChiLv,ArrivalTime,SettleTime,Supplier,Brand,TransportWay,Size,Texture,Amount,Margin,OnlinePrice,Fluctuation1,Fluctuation2,SalePrice,TotalSale,MarginRate)");
			strSql.Append(" values (");
			strSql.Append("@EntryTime,@JianChiLv,@ArrivalTime,@SettleTime,@Supplier,@Brand,@TransportWay,@Size,@Texture,@Amount,@Margin,@OnlinePrice,@Fluctuation1,@Fluctuation2,@SalePrice,@TotalSale,@MarginRate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EntryTime", SqlDbType.DateTime),
					new SqlParameter("@JianChiLv", SqlDbType.Money,8),
					new SqlParameter("@ArrivalTime", SqlDbType.Date,3),
					new SqlParameter("@SettleTime", SqlDbType.Date,3),
					new SqlParameter("@Supplier", SqlDbType.VarChar,50),
					new SqlParameter("@Brand", SqlDbType.VarChar,50),
					new SqlParameter("@TransportWay", SqlDbType.VarChar,50),
					new SqlParameter("@Size", SqlDbType.VarChar,50),
					new SqlParameter("@Texture", SqlDbType.VarChar,50),
					new SqlParameter("@Amount", SqlDbType.Money,8),
					new SqlParameter("@Margin", SqlDbType.Money,8),
					new SqlParameter("@OnlinePrice", SqlDbType.Money,8),
					new SqlParameter("@Fluctuation1", SqlDbType.Money,8),
					new SqlParameter("@Fluctuation2", SqlDbType.Money,8),
					new SqlParameter("@SalePrice", SqlDbType.Money,8),
					new SqlParameter("@TotalSale", SqlDbType.Money,8),
					new SqlParameter("@MarginRate", SqlDbType.Money,8)};
			parameters[0].Value = model.EntryTime;
			parameters[1].Value = model.JianChiLv;
			parameters[2].Value = model.ArrivalTime;
			parameters[3].Value = model.SettleTime;
			parameters[4].Value = model.Supplier;
			parameters[5].Value = model.Brand;
			parameters[6].Value = model.TransportWay;
			parameters[7].Value = model.Size;
			parameters[8].Value = model.Texture;
			parameters[9].Value = model.Amount;
			parameters[10].Value = model.Margin;
			parameters[11].Value = model.OnlinePrice;
			parameters[12].Value = model.Fluctuation1;
			parameters[13].Value = model.Fluctuation2;
			parameters[14].Value = model.SalePrice;
			parameters[15].Value = model.TotalSale;
			parameters[16].Value = model.MarginRate;

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
		public bool Update(SteelManagement.Model.SaleInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SaleInfo set ");
			strSql.Append("EntryTime=@EntryTime,");
			strSql.Append("JianChiLv=@JianChiLv,");
			strSql.Append("ArrivalTime=@ArrivalTime,");
			strSql.Append("SettleTime=@SettleTime,");
			strSql.Append("Supplier=@Supplier,");
			strSql.Append("Brand=@Brand,");
			strSql.Append("TransportWay=@TransportWay,");
			strSql.Append("Size=@Size,");
			strSql.Append("Texture=@Texture,");
			strSql.Append("Amount=@Amount,");
			strSql.Append("Margin=@Margin,");
			strSql.Append("OnlinePrice=@OnlinePrice,");
			strSql.Append("Fluctuation1=@Fluctuation1,");
			strSql.Append("Fluctuation2=@Fluctuation2,");
			strSql.Append("SalePrice=@SalePrice,");
			strSql.Append("TotalSale=@TotalSale,");
			strSql.Append("MarginRate=@MarginRate");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@EntryTime", SqlDbType.DateTime),
					new SqlParameter("@JianChiLv", SqlDbType.Money,8),
					new SqlParameter("@ArrivalTime", SqlDbType.Date,3),
					new SqlParameter("@SettleTime", SqlDbType.Date,3),
					new SqlParameter("@Supplier", SqlDbType.VarChar,50),
					new SqlParameter("@Brand", SqlDbType.VarChar,50),
					new SqlParameter("@TransportWay", SqlDbType.VarChar,50),
					new SqlParameter("@Size", SqlDbType.VarChar,50),
					new SqlParameter("@Texture", SqlDbType.VarChar,50),
					new SqlParameter("@Amount", SqlDbType.Money,8),
					new SqlParameter("@Margin", SqlDbType.Money,8),
					new SqlParameter("@OnlinePrice", SqlDbType.Money,8),
					new SqlParameter("@Fluctuation1", SqlDbType.Money,8),
					new SqlParameter("@Fluctuation2", SqlDbType.Money,8),
					new SqlParameter("@SalePrice", SqlDbType.Money,8),
					new SqlParameter("@TotalSale", SqlDbType.Money,8),
					new SqlParameter("@MarginRate", SqlDbType.Money,8),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.EntryTime;
			parameters[1].Value = model.JianChiLv;
			parameters[2].Value = model.ArrivalTime;
			parameters[3].Value = model.SettleTime;
			parameters[4].Value = model.Supplier;
			parameters[5].Value = model.Brand;
			parameters[6].Value = model.TransportWay;
			parameters[7].Value = model.Size;
			parameters[8].Value = model.Texture;
			parameters[9].Value = model.Amount;
			parameters[10].Value = model.Margin;
			parameters[11].Value = model.OnlinePrice;
			parameters[12].Value = model.Fluctuation1;
			parameters[13].Value = model.Fluctuation2;
			parameters[14].Value = model.SalePrice;
			parameters[15].Value = model.TotalSale;
			parameters[16].Value = model.MarginRate;
			parameters[17].Value = model.Id;

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
			strSql.Append("delete from SaleInfo ");
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
			strSql.Append("delete from SaleInfo ");
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
		public SteelManagement.Model.SaleInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,EntryTime,JianChiLv,ArrivalTime,SettleTime,Supplier,Brand,TransportWay,Size,Texture,Amount,Margin,OnlinePrice,Fluctuation1,Fluctuation2,SalePrice,TotalSale,MarginRate from SaleInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			SteelManagement.Model.SaleInfo model=new SteelManagement.Model.SaleInfo();
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
		public SteelManagement.Model.SaleInfo DataRowToModel(DataRow row)
		{
			SteelManagement.Model.SaleInfo model=new SteelManagement.Model.SaleInfo();
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
				if(row["JianChiLv"]!=null && row["JianChiLv"].ToString()!="")
				{
					model.JianChiLv=decimal.Parse(row["JianChiLv"].ToString());
				}
				if(row["ArrivalTime"]!=null && row["ArrivalTime"].ToString()!="")
				{
					model.ArrivalTime=DateTime.Parse(row["ArrivalTime"].ToString());
				}
				if(row["SettleTime"]!=null && row["SettleTime"].ToString()!="")
				{
					model.SettleTime=DateTime.Parse(row["SettleTime"].ToString());
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
				if(row["Margin"]!=null && row["Margin"].ToString()!="")
				{
					model.Margin=decimal.Parse(row["Margin"].ToString());
				}
				if(row["OnlinePrice"]!=null && row["OnlinePrice"].ToString()!="")
				{
					model.OnlinePrice=decimal.Parse(row["OnlinePrice"].ToString());
				}
				if(row["Fluctuation1"]!=null && row["Fluctuation1"].ToString()!="")
				{
					model.Fluctuation1=decimal.Parse(row["Fluctuation1"].ToString());
				}
				if(row["Fluctuation2"]!=null && row["Fluctuation2"].ToString()!="")
				{
					model.Fluctuation2=decimal.Parse(row["Fluctuation2"].ToString());
				}
				if(row["SalePrice"]!=null && row["SalePrice"].ToString()!="")
				{
					model.SalePrice=decimal.Parse(row["SalePrice"].ToString());
				}
				if(row["TotalSale"]!=null && row["TotalSale"].ToString()!="")
				{
					model.TotalSale=decimal.Parse(row["TotalSale"].ToString());
				}
				if(row["MarginRate"]!=null && row["MarginRate"].ToString()!="")
				{
					model.MarginRate=decimal.Parse(row["MarginRate"].ToString());
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
			strSql.Append("select Id,EntryTime,JianChiLv,ArrivalTime,SettleTime,Supplier,Brand,TransportWay,Size,Texture,Amount,Margin,OnlinePrice,Fluctuation1,Fluctuation2,SalePrice,TotalSale,MarginRate ");
			strSql.Append(" FROM SaleInfo ");
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
			strSql.Append(" Id,EntryTime,JianChiLv,ArrivalTime,SettleTime,Supplier,Brand,TransportWay,Size,Texture,Amount,Margin,OnlinePrice,Fluctuation1,Fluctuation2,SalePrice,TotalSale,MarginRate ");
			strSql.Append(" FROM SaleInfo ");
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
			strSql.Append("select count(1) FROM SaleInfo ");
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
			strSql.Append(")AS Row, T.*  from SaleInfo T ");
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
			parameters[0].Value = "SaleInfo";
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

