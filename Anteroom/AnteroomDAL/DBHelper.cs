using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Anteroom.DAL
{
    public class DBHelper
    {
        private static readonly string str =
            ConfigurationManager.ConnectionStrings["str"].ToString();//连接字符串

        public static string Str
        {
            get { return DBHelper.str; }
        } 


        private static SqlConnection conn = new SqlConnection(Str);
        /// <summary>
        /// 获取连接对象
        /// </summary>
        public static SqlConnection Conn
        {
            get { return DBHelper.conn; }
        }

        #region 连接方法
        /// <summary>
        /// 打开连接方法
        /// </summary>
        public static void OpenConn()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            else
            {
                conn.Open();
            }
        }
        /// <summary>
        /// 关闭连接方法
        /// </summary>
        public static void CloseConn()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        #endregion
    }
}
