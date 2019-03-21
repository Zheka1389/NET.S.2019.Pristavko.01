using System;
using System.Linq;

namespace NET.S._2019.Pristavko._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masOne = new int[] { 1, 4, 3, 6, 5, 5, 4 };
            int[] masTwo = new int[] { 45, 4, 3543, 346, 0, 91245, -5674 };
            int[] masThree = new int[] { 176, 44, 53, -66, 53, 5, -64 };
            int[] masFour = new int[] { 9, 4, 365, 6009, -34635, 5, -345344 };
            Console.WriteLine("Quick Sort method");
            QuickSort(masOne, 0, masOne.Length - 1);
            foreach (var item in masOne)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            QuickSort(masTwo, 0, masTwo.Length - 1);
            foreach (var item in masTwo)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            QuickSort(masThree, 0, masThree.Length - 1);
            foreach (var item in masThree)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            QuickSort(masFour, 0, masFour.Length - 1);
            foreach (var item in masFour)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            masOne = MergeSort(new int[] { 1, 4, 3, 6, 5, 5, 4 });
            masTwo = MergeSort(new int[] { 45, 4, 3543, 346, 0, 91245, -5674 });
            masThree = MergeSort(new int[] { 176, 44, 53, -66, 53, 5, -64 });
            masFour = MergeSort(new int[] { 9, 4, 365, 6009, -34635, 5, -345344 });
            Console.WriteLine("\nMerge Sort method");
            foreach (var item in masOne)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in masTwo)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in masThree)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in masFour)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        //<summary>Partition array</summary>
        static int Partition(int[] array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= array[end])
                {
                    int temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }

        //<summary>Method Quick sort</summary>
        static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(array, start, end);
            QuickSort(array, start, pivot - 1);
            QuickSort(array, pivot + 1, end);
        }

        //<summary>Merge Sort Method</summary>
        static int[] MergeSort(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }

            int middle = array.Length / 2;
            return Merge(MergeSort(array.Take(middle).ToArray()), MergeSort(array.Skip(middle).ToArray()));
        }

        //<summary>Merge array</summary>
        static int[] Merge(int[] arr1, int[] arr2)
        {
            int ptr1 = 0, ptr2 = 0;
            int[] merged = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < merged.Length; ++i)
            {
                if (ptr1 < arr1.Length && ptr2 < arr2.Length)
                {
                    merged[i] = arr1[ptr1] > arr2[ptr2] ? arr2[ptr2++] : arr1[ptr1++];
                }
                else
                {
                    merged[i] = ptr2 < arr2.Length ? arr2[ptr2++] : arr1[ptr1++];
                }
            }
            return merged;
        }
    }
}
