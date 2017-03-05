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
            if (str == null || str == "")
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
        /// <summary>
        /// Checks if a string contains any of the strings passed in the IEnummerable
        /// </summary>
        /// <param name="str"></param>
        /// <param name="list"></param>
        /// <param name="caseSensitive"></param>
        /// <returns></returns>
        public static bool ContainsAny(this string str, IEnumerable<string> list, bool caseSensitive = true)
        {
            string testStr = str;
            List<string> values = list.ToList();

            if (!caseSensitive)
            {
                testStr = testStr.ToLower();
                values = values.ToLower();
            }

            foreach(var val in values)
            {
                if (testStr.Contains(val))
                    return true;
            }
            return false;
        }
    }
}
