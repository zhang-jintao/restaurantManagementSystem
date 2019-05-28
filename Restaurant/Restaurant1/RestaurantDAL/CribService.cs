using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Restaurant.Models;

namespace Restaurant.DAL
{
    public class CribService
    {
        /// <summary>
        /// 获取食材表
        /// </summary>
        /// <param name="str">获取食材表</param>
        /// <returns>获取食材表</returns>
        public List<Crib> GetAllCirb(string str)
        {
            List<Crib> list = new List<Crib>();
            SqlCommand comm = new SqlCommand();
            string sql = "select * from Crib where CribName like '%'+@name+'%'";
            comm.CommandText = sql;
            comm.Parameters.Add("@name",SqlDbType.VarChar).Value=str;
            comm.Connection = DBHelper.Conn;
            DBHelper.OpenConn();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Crib cr = new Crib();
                cr.CribId = Convert.ToInt32(dr["CribId"].ToString());
                cr.CribName = dr["CribName"].ToString();
                cr.CribMoney = Convert.ToDecimal(dr["CribMoney"].ToString());
                cr.CribRepertory = Convert.ToDouble(dr["CribRepertory"].ToString());
                list.Add(cr);
            }
            dr.Close();
            DBHelper.CloseConn();
            return list;
        }
        #region 按编号查询食材
        public string GetCribName(int CribId)
        {
            string name = string.Empty;
            string sql = "select CribName from Crib where CribId=@id";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.Conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = CribId;
            try
            {
                DBHelper.OpenConn();
                name = cmd.ExecuteScalar().ToString();

            }
            catch (Exception)
            {

                throw;
            }
            return name;
        }
        #endregion
        #region 增加食材库存
        /// <summary>
        /// 增加库存
        /// </summary>
        /// <param name="id"></param>
        /// <param name="liang"></param>
        /// <returns></returns>
        public int InertCrib(int id,double liang)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "update Crib set CribRepertory=CribRepertory+@liang where CribId=@id";
            comm.Connection = DBHelper.Conn;
            comm.Parameters.Add("@id",SqlDbType.Int).Value=id;
            comm.Parameters.Add("@liang",SqlDbType.Float).Value=liang;
            DBHelper.OpenConn() ;
            k = comm.ExecuteNonQuery();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
        #region 根据名字查询编号
        /// <summary>
        /// 查询编号
        /// </summary>
        /// <param name="cribName"></param>
        /// <returns></returns>
        //public int SelectCribId(string cribName)
        //{
        //    int k = 0;
        //    SqlCommand comm = new SqlCommand();
        //    comm.CommandText = "select CribId from Crib where CribName=@CribName";
        //    comm.Connection = DBHelper.Conn;
        //    comm.Parameters.Add("@CribName",SqlDbType.VarChar).Value=cribName;
        //    DBHelper.OpenConn();
        //    SqlDataReader dr = comm.ExecuteReader();
        //    k = Convert.ToInt32(dr["CribId"].ToString());
        //    return k;
        //}
        #endregion
        #region 修改食材名称与价格
        public int UpdateCrib(int id,string name,decimal money)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "update Crib set CribName=@name , CribMoney=@money where CribId=@id";
            comm.Connection = DBHelper.Conn;
            SqlParameter[] parm = { 
                                 new SqlParameter("@id",id),
                                 new SqlParameter("@name",name),
                                 new SqlParameter("@money",money)
                                };
            comm.Parameters.AddRange(parm);
            DBHelper.OpenConn();
            k = comm.ExecuteNonQuery();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
        #region 根据编号删除食材
        public int DeleteCrib(int id)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "delete Crib where CribId=@id";
            comm.Connection = DBHelper.Conn;
            comm.Parameters.Add("@id",SqlDbType.Int).Value=id;
            DBHelper.OpenConn();
            k = comm.ExecuteNonQuery();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
        #region 检查是否存在食材
        public int CheckName(string name)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select count(1) from Crib where CribName=@name";
            comm.Connection = DBHelper.Conn;
            comm.Parameters.Add("@name",SqlDbType.VarChar).Value=name;
            DBHelper.OpenConn();
            k = (int)comm.ExecuteScalar();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
        #region 增加食材
        public int InsertCribs(string name,decimal money,double kucun)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "insert Crib (CribName,CribMoney,CribRepertory) values (@name,@money,@kucun)";
            comm.Connection = DBHelper.Conn;
            SqlParameter[] para = {
                                  new SqlParameter("@name",name),
                                  new SqlParameter("@money",money),
                                  new SqlParameter("@kucun",kucun)
                                  };
            comm.Parameters.AddRange(para);
            DBHelper.OpenConn();
            k = comm.ExecuteNonQuery();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
    }
}
