using System;

namespace MergeSort
{
    internal class MergeSort
    {
        public static void Main(String[] args)
        {
            int[] arr = { 20, 10, 15, 5, 25, 1 };
            MergeSort sorting = new MergeSort();
            sorting.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted array");
            printArray(arr);
        }
        void merge(int[] arr, int l, int m, int r)
        {
            int subSize1 = m - l + 1;
            int subSize2 = r - m;
            int[] Temp1 = new int[subSize1];
            int[] Temp2 = new int[subSize2];
            int i, j;
            for (i = 0; i < subSize1; ++i)
            {
                Temp1[i] = arr[l + i];
            }
            for (j = 0; j < subSize2; ++j)
            {
                Temp2[j] = arr[m + 1 + j];
            }
            i = 0;
            j = 0;
            int k = l;
            while (i < subSize1 && j < subSize2)
            {
                if (Temp1[i] <= Temp2[j])
                {
                    arr[k] = Temp1[i];
                    i++;
                }
                else
                {
                    arr[k] = Temp2[j];
                    j++;
                }
                k++;
            }
            while (i < subSize1)
            {
                arr[k] = Temp1[i];
                i++;
                k++;
            }
            while (j < subSize2)
            {
                arr[k] = Temp2[j];
                j++;
                k++;
            }
        }
        void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                sort(arr, l, m);
                sort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
