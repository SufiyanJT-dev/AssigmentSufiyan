using System;
namespace Day3_C_Assignment
{
    public class ArithmeticOperations
    {
        public ArithmeticOperations()
        {
            Console.WriteLine("Input two numbers:");
            string stringNumberOne = Console.ReadLine();
            string stringNumberTwo = Console.ReadLine();

            if (int.TryParse(stringNumberOne, out int numberOne) && int.TryParse(stringNumberTwo, out int numberTwo))
            {
                Console.WriteLine(Add(numberOne, numberTwo));
                Console.WriteLine(Subtraction(numberOne, numberTwo));
                Console.WriteLine(Multiplication(numberOne, numberTwo));
                Console.WriteLine(Division(numberOne, numberTwo));
                Console.WriteLine(Mod(numberOne, numberTwo));
            }
            else
            {
                Console.WriteLine("Enter valid numeric inputs.");
            }
        }

        public int Add(int numberOne, int numberTwo) => numberOne + numberTwo;

        public int Subtraction(int numberOne, int numberTwo) => numberOne - numberTwo;

        public int Multiplication(int numberOne, int numberTwo) => numberOne * numberTwo;

        public int Division(int numberOne, int numberTwo)
        {
            if (numberTwo == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
            return numberOne / numberTwo;
        }

        public int Mod(int numberOne, int numberTwo)
        {
            if (numberTwo == 0)
            {
                Console.WriteLine("Modulus by zero is not allowed.");
                return 0;
            }
            return numberOne % numberTwo;
        }
    }
}
