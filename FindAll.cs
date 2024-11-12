using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public static class FindAll
    {
        
        public static List<int> FindAllIndex<T>(List<T> list, T item)
        {
            var listofIndices = new List<int>(); 
            for (int i = 0; i < list.Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(list[i], item))
                {
                    listofIndices.Add(i);
                }
            }
            return listofIndices;
        }
    }
}
