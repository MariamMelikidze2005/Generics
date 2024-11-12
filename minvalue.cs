using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    //დაწერეთ ფუნქცია რომელიც ლისტში იპოვის ობიექტის მინიმალურ მნიშვნელობას.

    public static class minvalue
    {

        public static T Findminvalue<T>(List<T> list) where T : IComparable<T>
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("List cannot be empty.");
            }
            T Min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(Min) < 0)
                {
                    Min = list[i];
                }

            }
            return Min;




        }
    }
}
