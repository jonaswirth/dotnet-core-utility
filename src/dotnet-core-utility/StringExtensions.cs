using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_utility
{
    public static class StringExtensions
    {
        /// <summary>
        /// Checks if a string is empty or null
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string str)
        {
            if (str == null || str.Trim() == "")
                return true;
            return false;
        }
        /// <summary>
        /// Checks if a string is empty, null or consists only of whitespaces
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullOrWhitespace(this string str)
        {
            if (str.Trim().IsNullOrEmpty())
                return true;
            return false;
        }
    }
}
