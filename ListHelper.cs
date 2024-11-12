using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework
{
    public static class ListHelper
    {
        public static int FindFirstIndex<T>(List<T> list, T item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(list[i], item))
                {
                    return i;
                }
            }
            return -1; 
        }
    }

}
