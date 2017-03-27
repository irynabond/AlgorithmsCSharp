using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //MergeSort algorithm = new MergeSort();
            int[] arr = { 9, 4, 8, 3, 1, 2, 5 };
            //algorithm.mergesort(array, 0, 4);

            //CloneLinkedList.CloneListRandomPointer(); 

            //PreOrderTreeTraversal.PreOrderTraversal();      
            //InOrderTreeTraversal.InOrderTraversal();
            //StringPermutation.PrintPermutations();
            //  Search.BinarySearch(array, 6);
            //Strings.RemoveDuplicate("hello");
            //CycleLinkedList.IsCircular();
            //HeapSort.Sort(array, 5);
            //HeapInsert.Insert(3);
            //HeapInsert.Insert(5);
            //HeapInsert.Insert(6);
            Solution.quickSort(arr, 0, 6);
        }
    }
}
