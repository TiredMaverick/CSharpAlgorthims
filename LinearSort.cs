using System;

namespace StartAlgor
{
    internal class LinearSort
    {
        public static void Main()
        {

            int[] arr = { 7, 3, 6, 10, 40, 20, 5, 1};
            int pos = 40; //wanted number to search for
            int Index = search(arr, pos);
            if (Index == -1)
            {
                Console.WriteLine("The element is not present in array");
            }
            else
            {
                Console.WriteLine(" The element is present at index " + Index);
            }

        }
        public static int search(int[] arr, int x)
        {
            //loop to search for wanted number and what its index is
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
