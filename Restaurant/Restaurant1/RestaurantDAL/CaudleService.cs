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
    public class CaudleService
    {
        #region 获取酒水表
        /// <summary>
        /// 获取酒水表
        /// </summary>
        /// <returns>获取酒水表</returns>
        public List<Caudle> GetAllCaudle(string str)
        {
            List<Caudle> list = new List<Caudle>();
            SqlCommand comm = new SqlCommand();
            string sql = "select * from Caudle where CaudleName like '%'+@name+'%'";
            comm.CommandText = sql;
            comm.Parameters.Add("@name", SqlDbType.VarChar).Value = str;
            comm.Connection = DBHelper.Conn;
            DBHelper.OpenConn();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Caudle ca = new Caudle();
                ca.CaudleId = Convert.ToInt32(dr["CaudleId"].ToString());
                ca.CaudleName = dr["CaudleName"].ToString();
                ca.CaudleMoney = Convert.ToDecimal(dr["CaudleMoney"].ToString());
                ca.CaudleGoldenCalf = Convert.ToDecimal(dr["CaudleGoldenCalf"].ToString());
                ca.CaudleRepertory = Convert.ToInt32(dr["CaudleRepertory"].ToString());

                list.Add(ca);
            }
            dr.Close();
            DBHelper.CloseConn();
            return list;
        }        
        #endregion

        #region 增加酒水
        public int InsertCaudle(string name, decimal money1, decimal money2, int no)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "insert Caudle (CaudleName,CaudleMoney,CaudleGoldenCalf,CaudleRepertory) values(@name,@money1,@money2,@no)";
            comm.Connection = DBHelper.Conn;
            SqlParameter[] par = { 
                               new SqlParameter("@name",name),
                               new SqlParameter("@money1",money1),
                               new SqlParameter("@money2",money2),
                               new SqlParameter("@no",no)
                               };
            comm.Parameters.AddRange(par);
            DBHelper.OpenConn();
            k = comm.ExecuteNonQuery();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
        #region 删除酒水
        public int DelCaudle(int id)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "delete Caudle where CaudleId=@id";
            comm.Connection = DBHelper.Conn;
            comm.Parameters.Add("@id",SqlDbType.Int).Value=id;
            DBHelper.OpenConn();
            k = comm.ExecuteNonQuery();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
        #region 修改酒水
        public int UpdCaudle(int id,decimal money1,decimal money2)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "update Caudle set CaudleMoney=@money1,CaudleGoldenCalf=@money2 where CaudleId=@id";
            comm.Connection = DBHelper.Conn;
            SqlParameter[] par = {
                                 new SqlParameter("@money1",money1),
                                 new SqlParameter("@money2",money2),
                                 new SqlParameter("@id",id)
                                 };
            comm.Parameters.AddRange(par);
            DBHelper.OpenConn();
            k = comm.ExecuteNonQuery();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
        #region 增加酒水库存
        public int UpdateCaudle(int no,int id)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "update Caudle set CaudleRepertory=CaudleRepertory+@no where CaudleId=@id";
            comm.Connection = DBHelper.Conn;
            comm.Parameters.Add("@no", SqlDbType.Int).Value = no;
            comm.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DBHelper.OpenConn();
            k = comm.ExecuteNonQuery();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
    }
}
