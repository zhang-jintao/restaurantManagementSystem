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
    public class MenuTurnOverService
    {
        /// <summary>
        /// 查询菜品营业额
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns>查询菜品营业额</returns>
        public List<Turnover> GetAllMenuTurnOver(DateTime date1,DateTime date2)
        {
            List<Turnover> list = new List<Turnover>();
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select DishName,MenuNumber,AllMoneyMenu,DateTimes from MenuTurnover inner join Menu on MenuTurnover.MenuId=menu.DishId where @date1<DateTimes and @date2>DateTimes";
            comm.Connection = DBHelper.Conn;
            comm.Parameters.Add("@date1", SqlDbType.DateTime).Value = date1;
            comm.Parameters.Add("@date2", SqlDbType.DateTime).Value = date2;
            DBHelper.OpenConn();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Turnover mt = new Turnover();
                mt.Name = dr["DishName"].ToString();
                mt.Number = Convert.ToInt32(dr["MenuNumber"].ToString());
                mt.AllMoney = Convert.ToDecimal(dr["AllMoneyMenu"].ToString());
                mt.DateTime = dr["DateTimes"].ToString();
                list.Add(mt);
            }
            dr.Close();
            DBHelper.CloseConn();
            return list;
        }
    }
}
