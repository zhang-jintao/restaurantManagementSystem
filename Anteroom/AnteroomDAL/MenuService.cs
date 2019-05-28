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
    public class MenuService
    {
        /// <summary>
        /// 根据参数内的值，模糊查询所有菜品
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        #region 获取全部菜品
        public Dictionary<int,Menu1> GetAllMenu(string name)
        {
            Dictionary<int,Menu1> list = new Dictionary<int,Menu1>();
            string sql = "select * from menu where DishName like '%'+@name+'%'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DBHelper.Conn;
            SqlParameter para = new SqlParameter("@name",SqlDbType.VarChar);
            para.Value = name;
            cmd.Parameters.Add(para);
            try
            {
                DBHelper.OpenConn();
                using (SqlDataReader reader=cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Menu1 mn = new Menu1();
                        mn.DishId = Convert.ToInt32(reader["DishId"]);
                        mn.DishName = reader["DishName"].ToString();
                        mn.DishMoney = Convert.ToDouble(reader["DishMoney"]);
                        mn.CribOne = Convert.ToInt32(reader["CribOne"]);
                        mn.CribTwo = Convert.ToInt32(reader["CribTwo"]);
                        mn.CribOneX = Convert.ToDouble(reader["CribOneX"]);
                        mn.CribTwoX = Convert.ToDouble(reader["CribTwoX"]);
                        list.Add(mn.DishId,mn);
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
        /// 根据菜对象，减少食材数量，同时检查食材是否够
        /// </summary>
        /// <param name="me"></param>
        /// <param name="shu"></param>
        /// <returns></returns>
        #region 根据菜对象，检查食材够不够
        public int UpDateCrib(Menu1 me,int shu)
        {
            int k = 0;
            string sql = "update Crib set CribRepertory=CribRepertory-@Count where CribId=@Id";
            SqlParameter[] para ={
                                    new SqlParameter("@Count",me.CribOneX*shu),
                                    new SqlParameter("@Id",me.CribOne)
                                };
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Restaurant;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand(DBHelper.Str);
            cmd.Connection = conn;
            cmd.Parameters.AddRange(para);
            cmd.CommandText = sql;
            
            SqlTransaction trans=null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;
                int t = cmd.ExecuteNonQuery();
                if (t == 1)
                {
                    para[0].Value = me.CribTwoX * shu;
                    para[1].Value = me.CribTwo;
                    k = cmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        trans.Commit();
                    }
                }
            }
            catch (Exception)
            {
                trans.Rollback();
                k = -1;
            }
            finally 
            {
                conn.Close();
            }
            return k;
        }
        #endregion
        #region 退菜，加食材
        public int TuiMenu(Menu1 me, int count)
        {
            int k = 0;
            string sql = "update Crib set CribRepertory=CribRepertory+@Count where CribId=@Id";
            SqlParameter[] para ={
                                    new SqlParameter("@Count",me.CribOneX*count),
                                    new SqlParameter("@Id",me.CribOne)
                                };
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Restaurant;User ID=sa;Password=123");
            SqlCommand cmd = new SqlCommand(DBHelper.Str);
            cmd.Connection = conn;
            cmd.Parameters.AddRange(para);
            cmd.CommandText = sql;

            SqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;
                int t = cmd.ExecuteNonQuery();
                if (t == 1)
                {
                    para[0].Value = me.CribTwoX * count;
                    para[1].Value = me.CribTwo;
                    k = cmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        trans.Commit();
                    }
                }
            }
            catch (Exception)
            {
                trans.Rollback();
                k = -1;
            }
            finally
            {
                conn.Close();
            }
            return k;
        }
        #endregion

    }
}
