﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DAL;
using Restaurant.Models;
using System.Windows.Forms;

namespace Restaurant.BLL
{
    public class AdminManager
    {
        AdminService admins = new AdminService();
        #region 保存账号密码到本地
        /// <summary>
        /// 保存账号密码到本地
        /// </summary>
        /// <param name="ad"></param>
        /// <returns></returns>
        public bool AddAdminTxt(List<Admin> ad) 
        {
            return admins.AddAdminTxt(ad);
        }
        #endregion
        #region 返回所有账号集合
        /// <summary>
        /// 返回所有账号集合
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Admin> GetAllUser()
        {
            return admins.GetAllUser();
        }
        #endregion
        #region 检查账号密码是否存在
        /// <summary>
        /// 检查账号密码是否存在
        /// </summary>
        /// <param name="ad"></param>
        /// <returns></returns>
        public bool CheckAdmin(Admin ad)
        {
            return admins.CheckAdmin(ad);
        }
        #endregion



        #region 查询所有用户账号ID
        public List<Admin> GetAllLoginId()
        {
            List<Admin> list = admins.GetAllAdmin();
            return list;
        }
        #endregion
        #region 修改选择的账号密码
        public int UpdatePwd(Admin ad)
        {
            int no = 0;
            no = admins.UpdateAdmin(ad);
            return no;
        }
        #endregion
    }
}
