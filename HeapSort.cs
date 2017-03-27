//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Algorithms
//{
//    class HeapSort
//    {
//        public static int Parent(int i)
//        {
//            return (i - 1) / 2;
//        }

//        public static int LChild(int i)
//        {
//            return i * 2 + 1;
//        }

//        public static int RChild(int i)
//        {
//            return i * 2 + 2;
//        }

//        public static void Sort(int[] array, int count)
//        {
//            Heapify(ref array, count - 1);
          
           
//            for (int i = count - 2; i >= 0; i--)
//            {
//                int max = array[0];
//                array[0] = array[count - 1];
//                array[count - 1] = max;

//                SiftDown(ref array, ref i);
//            }
//        }
//        public static void Heapify (ref int[] array, int index)
//        {
//            while (index !=0)
//            {
//                SiftDown(ref array, ref index);
//            }
//        }
//        public static void SiftDown(ref int[] array, int start, int end)
//        {

//            while (i != 0)
//            {
//                if (array[i] <= array[i / 2 - 1])
//                {
//                    swap(ref array, i, i / 2 - 1);
//                    i = i / 2 - 1;
//                }

//                else if (array[i] < array[i / 2])
//                {
//                    swap(ref array, i, i / 2);
//                    i = i / 2;
//                }
//            }
//        }

//        public static void swap(ref int[] array, int i, int j)
//        {
//            int temp = array[i];
//            array[i] = array[j];
//            array[j] = temp;
//        }
//    }
//}
