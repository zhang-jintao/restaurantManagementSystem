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
    public class MenuService
    {
        #region 获取菜品表
        /// <summary>
        /// 获取菜品表
        /// </summary>
        /// <returns>获取菜品表</returns>
        public List<Menus> GetAllMenu(string str)
        {
            List<Menus> list = new List<Menus>();
            SqlCommand comm = new SqlCommand();
            string sql = "select * from Menu where DishName like '%'+@name+'%'";
            comm.CommandText = sql;
            comm.Parameters.Add("@name", SqlDbType.VarChar).Value = str;
            comm.Connection = DBHelper.Conn;
            DBHelper.OpenConn();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Menus me = new Menus();
                me.DishId = Convert.ToInt32(dr["DishId"].ToString());
                me.DishName = dr["DishName"].ToString();
                me.DishMoney = Convert.ToDecimal(dr["DishMoney"].ToString());
                me.CribTwo = Convert.ToInt32(dr["CribTwo"].ToString());
                me.CribOne = Convert.ToInt32(dr["CribOne"].ToString());
                me.CribOneX = Convert.ToDouble(dr["CribOneX"].ToString());
                me.CribTwoX = Convert.ToDouble(dr["CribTwoX"].ToString());
                list.Add(me);
            }
            dr.Close();
            DBHelper.CloseConn();
            return list;
        }
        #endregion

        #region 增加菜品
        public int InsertMenu(string name,decimal money,int no1,int no2,double dou1,double dou2)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "insert Menu (DishName,DishMoney,CribOne,CribTwo,CribOneX,CribTwoX) values(@name,@money,@no1,@no2,@dou1,@dou2)";
            comm.Connection = DBHelper.Conn;
            SqlParameter[] par = {
                                 new SqlParameter("@name",name),
                                 new SqlParameter("@money",money),
                                 new SqlParameter("@no1",no1),
                                 new SqlParameter("@no2",no2),
                                 new SqlParameter("@dou1",dou1),
                                 new SqlParameter("@dou2",dou2)
                                 };
            comm.Parameters.AddRange(par);
            DBHelper.OpenConn();
            k = comm.ExecuteNonQuery();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
        #region 获取食材列
        public List<Crib> Crib()
        {
            List<Crib> list = new List<Crib>();
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select CribName from Crib";
            comm.Connection = DBHelper.Conn;
            DBHelper.OpenConn();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Models.Crib cr = new Models.Crib();
                cr.CribName= dr["CribName"].ToString();
                list.Add(cr);
            }
            dr.Close();
            DBHelper.CloseConn();
            return list;
        }
        #endregion
        #region 根据食材名称查询编号
        public int CribID(string name)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select CribId from Crib where CribName=@name";
            comm.Connection = DBHelper.Conn;
            comm.Parameters.Add("@name",SqlDbType.VarChar).Value=name;
            DBHelper.OpenConn();
            k = (int)comm.ExecuteScalar();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
        #region 删除菜品
        public int DelMneu(int id)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "delete Menu where DishId=@id";
            comm.Connection = DBHelper.Conn;
            comm.Parameters.Add("@id",SqlDbType.Int).Value=id;
            DBHelper.OpenConn();
            k = comm.ExecuteNonQuery();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
        #region 修改菜品
        public int UpdateMenu(int id,decimal money, double dou1, double dou2)
        {
            int k = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "update Menu set DishMoney=@money, CribOneX=@dou1,CribTwoX=@dou2 where DishId=@id";
            comm.Connection = DBHelper.Conn;
            SqlParameter[] par = {
                                 new SqlParameter("@id",id),
                                 new SqlParameter("@dou1",dou1),
                                 new SqlParameter("@dou2",dou2),
                                 new SqlParameter("@money",money)
                                 };
            comm.Parameters.AddRange(par);
            DBHelper.OpenConn();
            k = comm.ExecuteNonQuery();
            DBHelper.CloseConn();
            return k;
        }
        #endregion
    }
}
