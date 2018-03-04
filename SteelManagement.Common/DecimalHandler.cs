using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelManagement.Common
{
    public class DecimalHandler
    {
        /// <summary>
        /// 失败返回0
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal Parse(string str)
        {
            try
            {
                return decimal.Parse(str);
            }
            catch (Exception)
            {
                return decimal.Zero;
                throw;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="digit">小数点位数</param>
        /// <returns></returns>
        public static string DecimalToString(Decimal d, int digit)
        {
            return Math.Round(d, digit).ToString();
        }

        /// <summary>
        /// 自适应去掉尾部的0
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string DecimalToString(Decimal d)
        {
            string str = d.ToString();
            str = str.TrimEnd('0'); //移除所有尾部0
            if (str.EndsWith("."))
                return str.TrimEnd('.');
            return str;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="digit">小数点位数</param>
        /// <returns></returns>
        public static decimal Round(Decimal d, int digit)
        {
            return Math.Round(d, digit);
        }
    }
}
