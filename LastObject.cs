using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public static class FindLast
    {
        
        public static (T lastObject, int index) FindLastObjectWithIndex<T>(List<T> list)
        {
            if (list.Count == 0)
            {
                return (default(T), -1); 
            }

           
            T lastObject = list[list.Count - 1];
            int lastIndex = list.Count - 1;

            return (lastObject, lastIndex); 
        }
    }
}
