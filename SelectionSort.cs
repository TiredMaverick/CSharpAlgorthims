using System;
using System.Collections.Generic;
using System.Text;

namespace StartAlgor
{
    internal class SelectionSort
    {

        public static void Main()
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            int[] arr = { 60, 22, 25, 12, 10, 1 };
            Console.WriteLine("Sorted array");
            sort(arr);
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }
        static void sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int Lowest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[Lowest])
                    {
                        Lowest = j;
                    }
                    int copy = arr[Lowest];
                    arr[Lowest] = arr[i];
                    arr[i] = copy;
                }
            }
            for (int i = 0; i < arr.Length; ++i)
            { 
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
