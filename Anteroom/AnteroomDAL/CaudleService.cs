using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anteroom.Models;
using System.Data;
using System.Data.SqlClient;

namespace Anteroom.DAL
{
    public class CaudleService
    {
        /// <summary>
        /// 根据参数内的值，模糊查询酒水
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        #region 获取全部酒水
        public Dictionary<int,Caudle> GetAllCaudle(string name)
        {
            Dictionary<int,Caudle> list = new Dictionary<int,Caudle>();
            string sql = "select * from Caudle where CaudleName like '%'+@name+'%'";

            SqlCommand comm = new SqlCommand(sql,DBHelper.Conn);
            comm.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            try
            {
                DBHelper.OpenConn();
                using (SqlDataReader reader=comm.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Caudle cd = new Caudle();
                        cd.CaudleId = Convert.ToInt32(reader["CaudleId"]);
                        cd.CaudleName = reader["CaudleName"].ToString();
                        cd.CaudleMoney = Convert.ToDouble(reader["CaudleMoney"]);
                        cd.CaudleGoldenCalf = Convert.ToDouble(reader["CaudleGoldenCalf"]);
                        cd.CaudleRepertory = Convert.ToInt32(reader["CaudleRepertory"]);
                        list.Add(cd.CaudleId,cd);
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return list;
        }
        #endregion
        /// <summary>
        /// 根据酒对象和值，减少库存，如果不足则返回-1
        /// </summary>
        /// <param name="cd"></param>
        /// <param name="shu"></param>
        /// <returns></returns>
        #region 根据酒对象，检查酒是否够
        public int UpdateCaudle(Caudle cd,int shu)
        {
            int k = 0;
            string sql = "update Caudle set CaudleRepertory=CaudleRepertory-@count where CaudleId=@id";
            SqlCommand cmd = new SqlCommand(sql,DBHelper.Conn);
            SqlParameter[] para ={
                                    new SqlParameter("@count",shu),
                                    new SqlParameter("@id",cd.CaudleId)
                                };
            cmd.Parameters.AddRange(para);
            try
            {
                DBHelper.OpenConn();
                k = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            { 
                DBHelper.CloseConn();
            }
            return k;
        }
        #endregion
        /// <summary>
        /// 根据酒对象和值，退酒
        /// </summary>
        /// <param name="cd"></param>
        /// <param name="shu"></param>
        /// <returns></returns>
        #region 退酒
        public int TuiCaudle(Caudle cd, int shu)
        {
            int k = 0;
            string sql = "update Caudle set CaudleRepertory=CaudleRepertory+@count where CaudleId=@id";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.Conn);
            SqlParameter[] para ={
                                    new SqlParameter("@count",shu),
                                    new SqlParameter("@id",cd.CaudleId)
                                };
            cmd.Parameters.AddRange(para);
            try
            {
                DBHelper.OpenConn();
                k = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                DBHelper.CloseConn();
            }
            return k;
        }
        #endregion
    }
}
