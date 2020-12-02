using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter length of array: ");
            int lengthArray = int.Parse(Console.ReadLine());

            int[] array = new int[lengthArray];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Please enter element number {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            Console.WriteLine();
            Console.WriteLine("Please find array formed in ascending order:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {array[i]}");
            }
            
            Console.Write("Please enter the value of the element in the array to be searched: ");
            int elementToSearch = int.Parse(Console.ReadLine());

            int resultIndex = binarySearch(array, elementToSearch);
            if (resultIndex == -1)
            {
                Console.WriteLine("Element is not present in the array");
            }
            else
            {
                Console.WriteLine($"Element found at index {resultIndex}");
            }
        }

        public static int binarySearch(int[] array, int x)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] == x)
                {
                    return middle;
                }

                if (x > array[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }
    }
}
