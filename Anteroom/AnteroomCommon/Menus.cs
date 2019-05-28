using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anteroom.Models;
using Anteroom.BLL;
using Anteroom.Common;
using System.IO;
using System.Windows.Forms;

namespace Anteroom
{
    public class Menus
    {
        
        public Dictionary<int,Menu1> mens = new Dictionary<int,Menu1>();
        public Dictionary<int,Caudle> caus = new Dictionary<int,Caudle>();
        public Tables tables = new Tables();
        private int tableId;

        public int TableId
        {
            get { return TableId; }
            set { tableId = value; }
        }
        private string tablePath;
        public Menus(int tableId)
        {
            this.TableId = tableId;
            this.tablePath = "Files\\Tables" + tableId + ".txt";
        }
        public Menus() { }

        #region 检查有没有桌
        public bool CheckTxt()
        {
            bool flag = File.Exists(tablePath);
            return flag;
        }
        #endregion
        #region 删除桌信息
        public static void DeleteTable(int k,int g)
        {
            
            try
            {
                for (int i = k+1; i <=g ; i++)
                {
                    string path = "Files\\Tables" + i + ".txt";
                    string path1 = "Files\\Tables" + (i+(g-k)) + ".txt";
                    if (File.Exists(path))
                    {
                        File.Delete(path);    
                    }
                    
                    if (File.Exists(path1))
                    {
                        File.Copy(path1, path, true);
                        File.Delete(path1);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("删除失败");
            }
        }
        #endregion
        #region 删除包厢信息
        public static void DeleteTBao(int n,int o,int t)
        {
            
            try
            {
                for (int i = t+n+1; i <= o+t; i++)
                {
                    File.Delete("Files\\Tables" + i + ".txt");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("删除失败");
            }
        }
        #endregion
        #region 保存桌信息
        public void CreateTxt()
        {
            FileStream myfs = new FileStream(tablePath, FileMode.Create);
            StreamWriter mysw = new StreamWriter(myfs);
            try
            {
                mysw.Write(tables.Num + "|" + tables.Name + "|" + tables.Type + "|" + tables.Bool+"#");
                int i = 0;
                foreach (Menu1 me in mens.Values)
                {
                     mysw.Write(me.DishId + "|" + me.DishName + "|" + me.DishMoney + "|" + me.CribOne + "|" + me.CribTwo + "|" + me.CribOneX + "|" + me.CribTwoX + "|" + me.Count);
                     if (i!=mens.Values.Count-1)
                     {
                         mysw.Write("!");
                     }
                     i++;
                }
                mysw.Write("#");
                i = 0;
                foreach (Caudle cd in caus.Values)
                {
                    mysw.Write(caus[i].CaudleId + "|" + caus[i].CaudleName + "|" + caus[i].CaudleMoney + "|" + caus[i].CaudleGoldenCalf + "|" + caus[i].CaudleRepertory + "|" + caus[i].Count);
                    if (i!=caus.Values.Count-1)
                    {
                        mysw.Write("!");
                    }
                    i++;
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
        }
        #endregion
        
        #region 读取桌信息
        public void ReadTxt()
        {
            FileStream myfs = new FileStream(tablePath, FileMode.OpenOrCreate);
            StreamReader mysr = new StreamReader(myfs);
            try
            {
                while (mysr.Peek()>0)
                {
                    string txt = mysr.ReadLine();
                    string[] str = txt.Split('#');
                    string tabletxt = str[0];
                    string mtxt = str[1];
                    string ctxt = str[2];
                    string[] table = tabletxt.Split('|');//拆分桌文本
                    string[] menu = mtxt.Split('!');//拆分菜文本
                    string[] caul = ctxt.Split('!');//拆分酒文本
                    tables.Num = Convert.ToInt32(table[0]);
                    tables.Name = table[1];
                    tables.Type = table[2];
                    tables.Bool = table[3];
                    for (int i = 0; i < menu.Length; i++)
                    {
                        if (menu[i].Equals(string.Empty))
                        {
                            break;
                        }
                        string []menutxt = menu[i].Split('|');
                        Menu1 m = new Menu1();
                        m.DishId = Convert.ToInt32(menutxt[0]);
                        m.DishName = menutxt[1];
                        m.DishMoney = Convert.ToDouble(menutxt[2]);
                        m.CribOne = Convert.ToInt32(menutxt[3]);
                        m.CribTwo = Convert.ToInt32(menutxt[4]);
                        m.CribOneX = Convert.ToDouble(menutxt[5]);
                        m.CribTwoX = Convert.ToDouble(menutxt[6]);
                        m.Count = Convert.ToInt32(menutxt[7]);
                        mens.Add(m.DishId, m);
                    }
                    for (int i = 0; i < caul.Length; i++)
                    {
                        if (caul[i].Equals(string.Empty))
                        {
                            break;
                        }
                        string[] cautxt = caul[i].Split('|');
                        Caudle c = new Caudle();
                        c.CaudleId = Convert.ToInt32(cautxt[0]);
                        c.CaudleName = cautxt[1];
                        c.CaudleMoney = Convert.ToDouble(cautxt[2]);
                        c.CaudleGoldenCalf = Convert.ToDouble(cautxt[3]);
                        c.CaudleRepertory = Convert.ToInt32(cautxt[4]);
                        c.Count = Convert.ToInt32(cautxt[5]);
                        caus.Add(c.CaudleId, c);
                    }
                }
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
        }
        #endregion
        #region 保存桌包房数量
        public static void AddCount(int t,int b)
        {
            FileStream myfs = new FileStream("Files\\TablesCount.txt", FileMode.Create);
            StreamWriter mysw = new StreamWriter(myfs);
            try
            {
                mysw.WriteLine(t + "|" + b);
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
        #region 读取桌包房数量
        public static int[] ReadCount()
        {
            FileStream myfs = new FileStream("Files\\TablesCount.txt",FileMode.OpenOrCreate);
            StreamReader mysr = new StreamReader(myfs);
            int[] i = new int[2];
            try
            {
                string s = mysr.ReadToEnd();
                string[] a = new string[2];
                if (s.Equals(string.Empty))
                {
                    a[0] = "8";
                    a[1] = "2";
                }
                else
                {
                    a = s.Split('|');
                }
                for (int c = 0; c < a.Length; c++)
                {
                    i[c] = Convert.ToInt32(a[c]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return i;
        }
        #endregion
    }
}
