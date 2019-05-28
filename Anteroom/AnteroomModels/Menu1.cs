using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteroom.Models
{
    public class Menu1
    {
        /// <summary>
        /// 菜品编号
        /// </summary>
        public int DishId { get; set; }
        /// <summary>
        /// 菜品名称
        /// </summary>
        public string DishName { get; set; }
        /// <summary>
        /// 菜品价格
        /// </summary>
        public double DishMoney { get; set; }
        /// <summary>
        /// 食材·1
        /// </summary>
        public int CribOne { get; set; }
        /// <summary>
        /// 食材·2
        /// </summary>
        public int CribTwo { get; set; }
        /// <summary>
        /// 食材1所需多少斤
        /// </summary>
        public double CribOneX { get; set; }
        /// <summary>
        /// 食材2所需多少斤
        /// </summary>
        public double CribTwoX { get; set; }
        /// <summary>
        /// 已点数量
        /// </summary>
        public int Count { get; set; }
    }
}
