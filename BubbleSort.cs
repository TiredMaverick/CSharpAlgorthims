using System;

namespace StartAlgor
{
    internal class BubbleSort
    {
        public static void Main()
        {
            
            int[] arr = { 1, 5, 4, 2, 3, };
            Console.WriteLine("Sorted array");
            Bubble_Sort(arr);
            
        }

        public static void Bubble_Sort(int[] arr)
        {
            //loop to sort numbers in array
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //swaps our numbers
                        int Copy = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = Copy;
                    }
                }
            }
            //prints the array to the console
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
