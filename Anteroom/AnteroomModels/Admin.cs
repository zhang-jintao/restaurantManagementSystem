using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteroom.Models
{
    public class Admin
    {
        private string loginId;
        /// <summary>
        /// 登录账号
        /// </summary>
        public string LoginId
        {
            get { return loginId; }
            set { loginId = value; }
        }
        private string loginPwd;
        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd
        {
            get { return loginPwd; }
            set { loginPwd = value; }
        }
        private int personnelLevel;
        /// <summary>
        /// 员工等级Id
        /// </summary>
        public int PersonnelLevel
        {
            get { return personnelLevel; }
            set { personnelLevel = value; }
        }

    }
}
