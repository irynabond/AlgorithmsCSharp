using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    static class StringPermutation
    {
        public static void Permutations(char[] arr, int start, int end)
        {
            int j;

            if (start == end)
            {
                Console.WriteLine(arr);
            }
            else
            {
                for (j = start; j <= end; j++)
                {
                    swap(ref arr[start], ref arr[j]);
                    Permutations(arr, start + 1, end);
                    swap(ref arr[start], ref arr[j]);
                }
            }
        }

        public static void swap(ref char a, ref char b)
        {
            char temp;
            temp = a;
            a = b;
            b = temp;
        }
        public static void PrintPermutations()
        {
            string str = "ABC";
            char[] arr = str.ToCharArray();
            Permutations(arr, 0, 2);
        }
    }
}
