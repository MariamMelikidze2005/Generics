using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    // ფუნქცია რომელიც იპოვის ყველა ობიექტს და დააბრუნებს მათ ინდექსებს
    internal class AllObject
    {
        public static (List<int> indices, List<T> objects) FindAllObjectsWithIndex<T>(List<T> list, T item)
        {
            var listOfIndices = new List<int>();
            var listOfObjects = new List<T>();

            for (int i = 0; i < list.Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(list[i], item))
                {
                    listOfIndices.Add(i);
                    listOfObjects.Add(list[i]);
                }
            }

            return (listOfIndices, listOfObjects); 
        }
    }
}
