﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace SteelManagement.DAL
{
	/// <summary>
	/// 数据访问类:SteelInfo
	/// </summary>
	public partial class SteelInfo
	{
		public SteelInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "SteelInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SteelInfo");
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
		public int Add(SteelManagement.Model.SteelInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SteelInfo(");
			strSql.Append("EntryTime,Name,Size,Texture,ProducePlace,Price,Fluctuation,Remark,State,InfoTime)");
			strSql.Append(" values (");
			strSql.Append("@EntryTime,@Name,@Size,@Texture,@ProducePlace,@Price,@Fluctuation,@Remark,@State,@InfoTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EntryTime", SqlDbType.DateTime),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Size", SqlDbType.VarChar,50),
					new SqlParameter("@Texture", SqlDbType.VarChar,50),
					new SqlParameter("@ProducePlace", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@Fluctuation", SqlDbType.Money,8),
					new SqlParameter("@Remark", SqlDbType.VarChar,50),
					new SqlParameter("@State", SqlDbType.VarChar,50),
					new SqlParameter("@InfoTime", SqlDbType.DateTime)};
			parameters[0].Value = model.EntryTime;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Size;
			parameters[3].Value = model.Texture;
			parameters[4].Value = model.ProducePlace;
			parameters[5].Value = model.Price;
			parameters[6].Value = model.Fluctuation;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.State;
			parameters[9].Value = model.InfoTime;

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
		public bool Update(SteelManagement.Model.SteelInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SteelInfo set ");
			strSql.Append("EntryTime=@EntryTime,");
			strSql.Append("Name=@Name,");
			strSql.Append("Size=@Size,");
			strSql.Append("Texture=@Texture,");
			strSql.Append("ProducePlace=@ProducePlace,");
			strSql.Append("Price=@Price,");
			strSql.Append("Fluctuation=@Fluctuation,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("State=@State,");
			strSql.Append("InfoTime=@InfoTime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@EntryTime", SqlDbType.DateTime),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Size", SqlDbType.VarChar,50),
					new SqlParameter("@Texture", SqlDbType.VarChar,50),
					new SqlParameter("@ProducePlace", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@Fluctuation", SqlDbType.Money,8),
					new SqlParameter("@Remark", SqlDbType.VarChar,50),
					new SqlParameter("@State", SqlDbType.VarChar,50),
					new SqlParameter("@InfoTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.EntryTime;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Size;
			parameters[3].Value = model.Texture;
			parameters[4].Value = model.ProducePlace;
			parameters[5].Value = model.Price;
			parameters[6].Value = model.Fluctuation;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.State;
			parameters[9].Value = model.InfoTime;
			parameters[10].Value = model.Id;

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
			strSql.Append("delete from SteelInfo ");
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
			strSql.Append("delete from SteelInfo ");
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
		public SteelManagement.Model.SteelInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,EntryTime,Name,Size,Texture,ProducePlace,Price,Fluctuation,Remark,State,InfoTime from SteelInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			SteelManagement.Model.SteelInfo model=new SteelManagement.Model.SteelInfo();
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
		public SteelManagement.Model.SteelInfo DataRowToModel(DataRow row)
		{
			SteelManagement.Model.SteelInfo model=new SteelManagement.Model.SteelInfo();
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
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Size"]!=null)
				{
					model.Size=row["Size"].ToString();
				}
				if(row["Texture"]!=null)
				{
					model.Texture=row["Texture"].ToString();
				}
				if(row["ProducePlace"]!=null)
				{
					model.ProducePlace=row["ProducePlace"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["Fluctuation"]!=null && row["Fluctuation"].ToString()!="")
				{
					model.Fluctuation=decimal.Parse(row["Fluctuation"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["State"]!=null)
				{
					model.State=row["State"].ToString();
				}
				if(row["InfoTime"]!=null && row["InfoTime"].ToString()!="")
				{
					model.InfoTime=DateTime.Parse(row["InfoTime"].ToString());
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
			strSql.Append("select Id,EntryTime,Name,Size,Texture,ProducePlace,Price,Fluctuation,Remark,State,InfoTime ");
			strSql.Append(" FROM SteelInfo ");
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
			strSql.Append(" Id,EntryTime,Name,Size,Texture,ProducePlace,Price,Fluctuation,Remark,State,InfoTime ");
			strSql.Append(" FROM SteelInfo ");
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
			strSql.Append("select count(1) FROM SteelInfo ");
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
			strSql.Append(")AS Row, T.*  from SteelInfo T ");
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
			parameters[0].Value = "SteelInfo";
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

