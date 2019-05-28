using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteroom.Models
{
    public class Crib
    {
        /// <summary>
        /// 食材ID
        /// </summary>
        public int CribId { get; set; }
        /// <summary>
        /// 食材名称
        /// </summary>
        public string CribName { get; set; }
        /// <summary>
        /// 食材价格
        /// </summary>
        public double CribMoney { get; set; }
        /// <summary>
        /// 食材库存
        /// </summary>
        public double CribRepertory { get; set; }
    }
}
