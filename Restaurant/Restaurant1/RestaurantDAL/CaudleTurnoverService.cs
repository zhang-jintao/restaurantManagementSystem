using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Models;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant.DAL
{
    public class CaudleTurnoverService
    {
        /// <summary>
        /// 查询酒水营业额
        /// </summary>
        /// <returns>查询酒水营业额</returns>
        public List<Turnover> GetAllCaudleTurnover(DateTime date1,DateTime date2)
        {
            List<Turnover> list = new List<Turnover>();
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select CaudleName,CaudleNumber,AllMoneyCaudle,DateTimes from CaudleTurnover inner join Caudle on CaudleTurnover.CaudleId=caudle.CaudleId where @date1<DateTimes and DateTimes<@date2";
            comm.Connection = DBHelper.Conn;
            comm.Parameters.Add("@date1", SqlDbType.DateTime).Value = date1;
            comm.Parameters.Add("@date2", SqlDbType.DateTime).Value = date2;
            DBHelper.OpenConn();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Turnover ct = new Turnover();
                ct.Name = dr["CaudleName"].ToString();
                ct.Number = Convert.ToInt32(dr["CaudleNumber"].ToString());
                ct.AllMoney = Convert.ToDecimal(dr["AllMoneyCaudle"].ToString());
                ct.DateTime = dr["DateTimes"].ToString();
                list.Add(ct);
            }
            dr.Close();
            DBHelper.CloseConn();
            return list;
        }
    }
}
