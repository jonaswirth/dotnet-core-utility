using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_utility
{
    public static class ListExtensions
    {
        public static List<string> ToLower(this List<string> list)
        {
            List<string> returnList = new List<string>();
            for(int i = 0; i < list.Count; i++)
            {
                returnList.Add(list.ElementAt(i).ToLower());
            }
            return returnList;
        }
    }
}
