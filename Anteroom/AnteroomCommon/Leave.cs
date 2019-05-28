using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anteroom;
using System.IO;

namespace Anteroom.Common
{
    public class Leave
    {
        #region 离开时生成txt文件
        public void AddLeave(string Pwd)
        {
            FileStream myfs = new FileStream("Leave.txt",FileMode.Create);
            StreamWriter mysw = new StreamWriter(myfs);
            try
            {
                mysw.WriteLine(Pwd);
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
        }
        #endregion
        #region 判断是否有文件
        public bool CheckLeave()
        {
            bool flag = false;
            flag = File.Exists("Leave.txt");
            return flag;
        }
        #endregion
        #region 删除文件
        public void DeleteLeave()
        {
            if (File.Exists("Leave.txt"))
            {
                File.Delete("Leave.txt");
            }
        }
        #endregion
        #region 读取文件
        public string ReadLeave()
        {
            string pwd = "";
            FileStream myfs = new FileStream("Leave.txt",FileMode.Open);
            StreamReader mysr = new StreamReader(myfs);
            try
            {
                pwd = mysr.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                mysr.Close();
                myfs.Close();
            }
            return pwd;
        }
        #endregion
    }
}
