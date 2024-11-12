using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public static class listHelper2
    {
        public static int FindLastIndex<T>(List<T> list, T item)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                if (EqualityComparer<T>.Default.Equals(item, list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
