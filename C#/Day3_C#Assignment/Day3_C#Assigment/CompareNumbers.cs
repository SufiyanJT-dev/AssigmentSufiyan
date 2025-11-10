using System;

namespace Day3_C_Assignment
{
    public class CompareNumbers
    {
        public CompareNumbers(int a, int b)
        {
            Console.WriteLine("Relation Operators:");

            if (a == b)
            {
                Console.WriteLine("Both are equal.");
            }
            if (a > b)
            {
                Console.WriteLine("A is greater than B.");
            }
            if (a < b)
            {
                Console.WriteLine("B is greater than A.");
            }
            if (a != b)
            {
                Console.WriteLine("A is not equal to B.");
            }

            Console.WriteLine("\nLogical Operators:");

            if (a > 10 && b > 10)
            {
                Console.WriteLine("Both A and B are greater than 10.");
            }
            if (a < 10 && b < 10)
            {
                Console.WriteLine("Both A and B are less than 10.");
            }
            if (a < 10 || b < 10)
            {
                Console.WriteLine("Either A or B or both are less than 10.");
            }
        }
    }
}
