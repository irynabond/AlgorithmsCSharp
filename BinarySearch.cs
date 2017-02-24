using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Search
    {
        public static void BinarySearch(int[] array,  int number)
        {
           
            int start = 0;
            int end = array.Length - 1;
            int middle = (end + start) / 2;

            while (start<end && number != array[middle])
            {
                if (number > array[middle])
                {
                    start = middle + 1;
                } else
                {
                    end = middle - 1;
                }
                middle = (end + start) / 2;
            }

            if (number == array[middle])
            {
                Console.WriteLine("Found at index " + middle);
            } else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
