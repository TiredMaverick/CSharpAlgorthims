using System;

namespace StartAlgor
{
    internal class BinarySearch
    {
        public static void Main()
        {

            int[] arr = { 2, 3, 4, 10, 20, 40, 45, 50, 100 };
            int wanted = 50; //wanted number that our code must search for
            int index = Search(arr, wanted);
            if (index == -1)
            {
                Console.WriteLine("Element not present");
            }
            else
            {
                Console.WriteLine("Element found at index " + index);
            }
        }
        //Search for index of what our wanted number is
        static int Search(int[] arr, int x)
        {
            //lowest number in array
            int low = 0;
            //hightest number in array
            int high = arr.Length - 1;
            while (low <= high)
            {
                //Middle number in array
                int mid = low + (high - low) / 2;
                //conditions for our index postion of wanted number
                if (arr[mid] == x)
                {
                    return mid;
                }
                else if (arr[mid] < x)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}
