﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace SteelManagement.DAL
{
	/// <summary>
	/// 数据访问类:AuthUser
	/// </summary>
	public partial class AuthUser
	{
		public AuthUser()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "AuthUser"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AuthUser");
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
		public int Add(SteelManagement.Model.AuthUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AuthUser(");
			strSql.Append("UserName,Account,Password,UserMobile,DepartmentId,UserLevel,Privilege)");
			strSql.Append(" values (");
			strSql.Append("@UserName,@Account,@Password,@UserMobile,@DepartmentId,@UserLevel,@Privilege)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,100),
					new SqlParameter("@Account", SqlDbType.VarChar,20),
					new SqlParameter("@Password", SqlDbType.VarChar,100),
					new SqlParameter("@UserMobile", SqlDbType.VarChar,50),
					new SqlParameter("@DepartmentId", SqlDbType.Int,4),
					new SqlParameter("@UserLevel", SqlDbType.Int,4),
					new SqlParameter("@Privilege", SqlDbType.Int,4)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.Account;
			parameters[2].Value = model.Password;
			parameters[3].Value = model.UserMobile;
			parameters[4].Value = model.DepartmentId;
			parameters[5].Value = model.UserLevel;
			parameters[6].Value = model.Privilege;

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
		public bool Update(SteelManagement.Model.AuthUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AuthUser set ");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Account=@Account,");
			strSql.Append("Password=@Password,");
			strSql.Append("UserMobile=@UserMobile,");
			strSql.Append("DepartmentId=@DepartmentId,");
			strSql.Append("UserLevel=@UserLevel,");
			strSql.Append("Privilege=@Privilege");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,100),
					new SqlParameter("@Account", SqlDbType.VarChar,20),
					new SqlParameter("@Password", SqlDbType.VarChar,100),
					new SqlParameter("@UserMobile", SqlDbType.VarChar,50),
					new SqlParameter("@DepartmentId", SqlDbType.Int,4),
					new SqlParameter("@UserLevel", SqlDbType.Int,4),
					new SqlParameter("@Privilege", SqlDbType.Int,4),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.Account;
			parameters[2].Value = model.Password;
			parameters[3].Value = model.UserMobile;
			parameters[4].Value = model.DepartmentId;
			parameters[5].Value = model.UserLevel;
			parameters[6].Value = model.Privilege;
			parameters[7].Value = model.Id;

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
			strSql.Append("delete from AuthUser ");
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
			strSql.Append("delete from AuthUser ");
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
		public SteelManagement.Model.AuthUser GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,UserName,Account,Password,UserMobile,DepartmentId,UserLevel,Privilege from AuthUser ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			SteelManagement.Model.AuthUser model=new SteelManagement.Model.AuthUser();
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
		public SteelManagement.Model.AuthUser DataRowToModel(DataRow row)
		{
			SteelManagement.Model.AuthUser model=new SteelManagement.Model.AuthUser();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["Account"]!=null)
				{
					model.Account=row["Account"].ToString();
				}
				if(row["Password"]!=null)
				{
					model.Password=row["Password"].ToString();
				}
				if(row["UserMobile"]!=null)
				{
					model.UserMobile=row["UserMobile"].ToString();
				}
				if(row["DepartmentId"]!=null && row["DepartmentId"].ToString()!="")
				{
					model.DepartmentId=int.Parse(row["DepartmentId"].ToString());
				}
				if(row["UserLevel"]!=null && row["UserLevel"].ToString()!="")
				{
					model.UserLevel=int.Parse(row["UserLevel"].ToString());
				}
				if(row["Privilege"]!=null && row["Privilege"].ToString()!="")
				{
					model.Privilege=int.Parse(row["Privilege"].ToString());
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
			strSql.Append("select Id,UserName,Account,Password,UserMobile,DepartmentId,UserLevel,Privilege ");
			strSql.Append(" FROM AuthUser ");
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
			strSql.Append(" Id,UserName,Account,Password,UserMobile,DepartmentId,UserLevel,Privilege ");
			strSql.Append(" FROM AuthUser ");
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
			strSql.Append("select count(1) FROM AuthUser ");
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
			strSql.Append(")AS Row, T.*  from AuthUser T ");
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
			parameters[0].Value = "AuthUser";
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

