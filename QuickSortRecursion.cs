using System;
using System.Collections.Generic;
using System.Text;

namespace StartAlgor
{
    internal class QuickSortRecursion
    {
        public static void Main()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5, 6, 2, 11 };
            quickSort(arr, 0, arr.Length - 1);
            Console.Write("Sorted array: ");
            printArray(arr, arr.Length);
        }
        static void swap(int[] arr, int i, int j)
        {
            int copy = arr[i];
            arr[i] = arr[j];
            arr[j] = copy;
        }
        static int Sort(int[] arr, int low, int high)
        {
            int change = arr[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < change)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }
        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Sort(arr, low, high);
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
        static void printArray(int[] arr, int Length)
        {
            for (int i = 0; i < Length; i++)
            {      
                Console.Write(arr[i] + " ");
             }
            Console.WriteLine();
        }
    }
}
