using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan.Share
{
    public static  class Extension
    {
        /// <summary>
        /// chuyển từ chuỗi -> số nguyên
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }
        /// <summary>
        /// biến đổi từ chuỗ sang số nguyên
        /// </summary>
        /// <param name="value"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool ToInt(this string value, out int i )
        {
            return int.TryParse(value, out i);
        }
        /// <summary>
        /// biến đổi chuỗi Y,y,true sang true
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ToBool(this string value)
        {
            var v = value.ToLower();
            if (v == "y" || v == "true") return true;
            return false;
        }
        /// <summary>false thành Yes/no hoặc có/không
        /// biến đổi true/
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format"> y/n hoặc c/k</param>
        /// <returns></returns>
        public static string ToString(this bool value, string format)
        {
            if (format == "y/n")
            {
                return value ? "yes" : "no";
            }
            if (format == "c/k")
            {
                return value ? "có" : "không";
            }
            return value? "true" : "false";
        }
    }
}
