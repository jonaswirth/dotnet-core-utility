using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_utility
{
    public static class ListExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<string> ToLower(this List<string> list)
        {
            List<string> returnList = new List<string>();
            for(int i = 0; i < list.Count; i++)
            {
                returnList.Add(list.ElementAt(i).ToLower());
            }
            return returnList;
        }
        /// <summary>
        /// Returns a specific page of a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static List<T> GetPageOfList<T>(this IEnumerable<T> list, int pageIndex, int pageSize)
        {
            int startIndex = (pageIndex - 1) * pageSize;
            return list.Range(startIndex, pageSize * pageIndex);
        }
        /// <summary>
        /// Returns a range of an IEnummerable as list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static List<T> Range<T>(this IEnumerable<T> list, int start, int end)
        {
            int count = end - start;
            return list.ToList<T>().GetRange(start, count);
        }
    }
}
