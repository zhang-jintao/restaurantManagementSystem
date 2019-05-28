using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anteroom.Models;
using System.Data.SqlClient;
using Anteroom.DAL;
using System.Data;

namespace Anteroom.DAL
{
    public class CaudleTurnoverService
    {
        #region 结账酒水
        public int AddCaudlTurnover(Dictionary<int,Caudle> cau)
        {
            int k = 0;
            string sql = "insert into CaudleTurnover values(@id,@count,@li,@time)";
            SqlConnection conn = new SqlConnection(DBHelper.Str);
            SqlTransaction trans=null;
            
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Transaction = trans;
                SqlParameter[] para ={
                                    new SqlParameter("@id",SqlDbType.Int),
                                    new SqlParameter("@count",SqlDbType.Int),
                                    new SqlParameter("@li",SqlDbType.Money),
                                    new SqlParameter("@time",SqlDbType.DateTime)
                                };
                cmd.Parameters.AddRange(para);
                foreach (Caudle item in cau.Values)
                {
                    para[0].Value = item.CaudleId;
                    para[1].Value = item.Count;
                    para[2].Value = (item.CaudleMoney - item.CaudleGoldenCalf) * item.Count;
                    para[3].Value = DateTime.Now;
                    k = cmd.ExecuteNonQuery();
                    if (!(k>0))
                    {
                        trans.Rollback();
                        return -1;
                    }
                }
                trans.Commit();
            }
            catch (Exception )
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
        #endregion

    }
}
