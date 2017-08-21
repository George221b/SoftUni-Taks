using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomList
{
    public static class Sorter<T>
    {
        public static List<string> Sort(List<string> customListList)
        {
            return customListList.OrderBy(x => x).ToList();
        }
    }
}
