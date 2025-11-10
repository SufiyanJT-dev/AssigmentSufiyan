using System;

namespace Day3_C_Assignment
{
    public class ArrayMaxAndMin
    {
        public ArrayMaxAndMin()
        {
            Console.WriteLine("Enter the number of elements in the array:");
            string stringLength = Console.ReadLine();

            if (int.TryParse(stringLength, out int length) && length > 0)
            {
                int[] arr = new int[length];
                Console.WriteLine("Enter the numbers:");

                for (int i = 0; i < length; i++)
                {
                    string stringValue = Console.ReadLine();
                    if (int.TryParse(stringValue, out int num))
                    {
                        arr[i] = num;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, defaulting to 0");
                        arr[i] = 0;
                    }
                }

                MinAndMax(arr, out int max, out int min);
                Console.WriteLine($"Max: {max}, Min: {min}");
            }
            else
            {
                Console.WriteLine("Invalid length");
            }
        }

        public static void MinAndMax(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }
        }
    }
}
