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
    public class MenuTurnoverService
    {
        public int AddMenuTurnover(Dictionary<int,Menu1> me)
        {
            int k = 0;
            string sql = "insert into MenuTurnover values(@id,@count,@money,@time)";
            SqlConnection conn = new SqlConnection(DBHelper.Str);
            SqlParameter[] para ={
                                    new SqlParameter("@id",SqlDbType.Int),
                                    new SqlParameter("@count",SqlDbType.Int),
                                    new SqlParameter("@money",SqlDbType.Decimal),
                                    new SqlParameter("@time",SqlDbType.DateTime)
                                 };
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                cmd.Parameters.AddRange(para);
                cmd.Transaction = trans;
                foreach (KeyValuePair<int,Menu1> item in me)
                {
                    para[0].Value = item.Value.DishId;
                    para[1].Value = item.Value.Count;

                    para[2].Value = Convert.ToDouble(item.Value.DishMoney*item.Value.Count) - (CheckCrib(item.Value.CribOne)*item.Value.CribOneX + CheckCrib(item.Value.CribTwo)*item.Value.CribTwoX);
                    para[3].Value = DateTime.Now;
                    k = cmd.ExecuteNonQuery();
                    if (!(k > 0))
                    {
                        trans.Rollback();
                        return -1;
                    }
                }
                trans.Commit();
            }
            catch (Exception)
            {
                trans.Rollback();
                throw;
            }
            finally
            {
                conn.Close();
            }
            return k;
        }
        #region 查询食材原价
        public double CheckCrib(int cId)
        {
            double money=0;
            string sql = "select CribMoney from Crib where CribId=@Id";
            SqlCommand cmd = new SqlCommand(sql,DBHelper.Conn);
            cmd.Parameters.Add("@Id",SqlDbType.Int).Value=cId;
            try
            {
                DBHelper.OpenConn();
                money = Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DBHelper.CloseConn();
            }
            return money;
        }
        #endregion 
    }
}
