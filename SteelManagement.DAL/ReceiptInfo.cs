using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace SteelManagement.DAL
{
	/// <summary>
	/// 数据访问类:ReceiptInfo
	/// </summary>
	public partial class ReceiptInfo
	{
		public ReceiptInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "ReceiptInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReceiptInfo");
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
		public int Add(SteelManagement.Model.ReceiptInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReceiptInfo(");
			strSql.Append("EntryTime,SerialNo,InvoiceDate,ReceiptDate,InvoiceNum,ReceiptNum,OperatorId)");
			strSql.Append(" values (");
			strSql.Append("@EntryTime,@SerialNo,@InvoiceDate,@ReceiptDate,@InvoiceNum,@ReceiptNum,@OperatorId)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EntryTime", SqlDbType.DateTime),
					new SqlParameter("@SerialNo", SqlDbType.VarChar,50),
					new SqlParameter("@InvoiceDate", SqlDbType.DateTime,3),
					new SqlParameter("@ReceiptDate", SqlDbType.DateTime,3),
					new SqlParameter("@InvoiceNum", SqlDbType.Money,8),
					new SqlParameter("@ReceiptNum", SqlDbType.Money,8),
					new SqlParameter("@OperatorId", SqlDbType.Int,4)};
			parameters[0].Value = model.EntryTime;
			parameters[1].Value = model.SerialNo;
			parameters[2].Value = model.InvoiceDate;
			parameters[3].Value = model.ReceiptDate;
			parameters[4].Value = model.InvoiceNum;
			parameters[5].Value = model.ReceiptNum;
			parameters[6].Value = model.OperatorId;

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
		public bool Update(SteelManagement.Model.ReceiptInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReceiptInfo set ");
			strSql.Append("EntryTime=@EntryTime,");
			strSql.Append("SerialNo=@SerialNo,");
			strSql.Append("InvoiceDate=@InvoiceDate,");
			strSql.Append("ReceiptDate=@ReceiptDate,");
			strSql.Append("InvoiceNum=@InvoiceNum,");
			strSql.Append("ReceiptNum=@ReceiptNum,");
			strSql.Append("OperatorId=@OperatorId");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@EntryTime", SqlDbType.DateTime),
					new SqlParameter("@SerialNo", SqlDbType.VarChar,50),
					new SqlParameter("@InvoiceDate", SqlDbType.DateTime,3),
					new SqlParameter("@ReceiptDate", SqlDbType.DateTime,3),
					new SqlParameter("@InvoiceNum", SqlDbType.Money,8),
					new SqlParameter("@ReceiptNum", SqlDbType.Money,8),
					new SqlParameter("@OperatorId", SqlDbType.Int,4),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.EntryTime;
			parameters[1].Value = model.SerialNo;
			parameters[2].Value = model.InvoiceDate;
			parameters[3].Value = model.ReceiptDate;
			parameters[4].Value = model.InvoiceNum;
			parameters[5].Value = model.ReceiptNum;
			parameters[6].Value = model.OperatorId;
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
			strSql.Append("delete from ReceiptInfo ");
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
			strSql.Append("delete from ReceiptInfo ");
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
		public SteelManagement.Model.ReceiptInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,EntryTime,SerialNo,InvoiceDate,ReceiptDate,InvoiceNum,ReceiptNum,OperatorId from ReceiptInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			SteelManagement.Model.ReceiptInfo model=new SteelManagement.Model.ReceiptInfo();
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
		public SteelManagement.Model.ReceiptInfo DataRowToModel(DataRow row)
		{
			SteelManagement.Model.ReceiptInfo model=new SteelManagement.Model.ReceiptInfo();
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
				if(row["SerialNo"]!=null)
				{
					model.SerialNo=row["SerialNo"].ToString();
				}
				if(row["InvoiceDate"]!=null && row["InvoiceDate"].ToString()!="")
				{
					model.InvoiceDate=DateTime.Parse(row["InvoiceDate"].ToString());
				}
				if(row["ReceiptDate"]!=null && row["ReceiptDate"].ToString()!="")
				{
					model.ReceiptDate=DateTime.Parse(row["ReceiptDate"].ToString());
				}
				if(row["InvoiceNum"]!=null && row["InvoiceNum"].ToString()!="")
				{
					model.InvoiceNum=decimal.Parse(row["InvoiceNum"].ToString());
				}
				if(row["ReceiptNum"]!=null && row["ReceiptNum"].ToString()!="")
				{
					model.ReceiptNum=decimal.Parse(row["ReceiptNum"].ToString());
				}
				if(row["OperatorId"]!=null && row["OperatorId"].ToString()!="")
				{
					model.OperatorId=int.Parse(row["OperatorId"].ToString());
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
			strSql.Append("select Id,EntryTime,SerialNo,InvoiceDate,ReceiptDate,InvoiceNum,ReceiptNum,OperatorId ");
			strSql.Append(" FROM ReceiptInfo ");
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
			strSql.Append(" Id,EntryTime,SerialNo,InvoiceDate,ReceiptDate,InvoiceNum,ReceiptNum,OperatorId ");
			strSql.Append(" FROM ReceiptInfo ");
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
			strSql.Append("select count(1) FROM ReceiptInfo ");
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
			strSql.Append(")AS Row, T.*  from ReceiptInfo T ");
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
			parameters[0].Value = "ReceiptInfo";
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

