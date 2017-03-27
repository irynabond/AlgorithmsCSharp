using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    static class HeapInsert
    {
        public static int[] arr = new int[10];
        public static int curPos = 1;
        public static void Insert(int value)
        {
            arr[curPos] = value;

            int parent = curPos / 2;

            while (parent != 0)
            {
                if (arr[curPos] > arr[parent])
                {
                    int temp = arr[curPos];
                    arr[curPos] = arr[parent];
                    arr[parent] = temp;
                    parent = parent / 2;
       
                }
            }
            curPos += 1;
        }
    }
}
