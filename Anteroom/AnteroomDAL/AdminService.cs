using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Anteroom.Models;
using System.Data.SqlClient;
using System.Data;

namespace Anteroom.DAL
{
    public class AdminService
    {
        private string path = "Admin.txt";
        /// <summary>
        /// 保存账号密码到本地
        /// </summary>
        /// <param name="ad"></param>
        /// <returns></returns>
        #region 保存账号密码到本地
        public bool AddAdminTxt(List<Admin> ad)
        {
            bool flag = false;
            FileStream myfs = null;
            StreamWriter mysw = null;
            try
            {
                myfs = new FileStream(path, FileMode.Create);
                mysw = new StreamWriter(myfs);
                for (int i = 0; i < ad.Count; i++)
                {
                    mysw.WriteLine(ad[i].LoginId  + "|" + ad[i].LoginPwd);

                }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                mysw.Close();
                myfs.Close();
            }
            return flag;
        }
        #endregion
        /// <summary>
        /// 获取所有账号到DIC集合
        /// </summary>
        /// <returns></returns>
        #region 返回所有账号集合
        public Dictionary<string, Admin> GetAllUser()
        {
            Dictionary<string, Admin> dic = new Dictionary<string, Admin>();
            FileStream myfs = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader myreader = new StreamReader(myfs, Encoding.Default);
            try
            {
                while (myreader.Peek() > 0)
                {
                    string[] s = myreader.ReadLine().Split('|');
                    Admin ad = new Admin();
                    ad.LoginId = s[0];
                    ad.LoginPwd = s[1];
                    dic.Add(ad.LoginId, ad);
                }
            }
            catch (Exception mx)
            {
                throw mx;
            }
            finally
            {
                myreader.Close();
                myfs.Close();
            }

            return dic;
        }
        #endregion

        #region 判断账号密码是否存在
        public bool CheckAdmin(Admin ad)
        {
            bool flag = false;
            string sql = @"select count(*) from Admin 
                           where LoginId=@id and LoginPwd=@pwd";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBHelper.Conn;
            cmd.CommandText = sql;
            SqlParameter[] para ={
                                new SqlParameter("@id",ad.LoginId),
                                new SqlParameter("@pwd",ad.LoginPwd)
                                };
            cmd.Parameters.AddRange(para);
            try
            {
                DBHelper.OpenConn();
                int k = Convert.ToInt32(cmd.ExecuteScalar());
                if (k > 0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DBHelper.CloseConn();
            }
            return flag;
        }
        #endregion
    }
}
