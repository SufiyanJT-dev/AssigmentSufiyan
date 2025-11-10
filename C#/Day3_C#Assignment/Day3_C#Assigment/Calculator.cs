using System;

namespace Day3_C_Assignment
{
    public class Calculator
    {
        public Calculator()
        {
            int flag = 1;

            while (flag == 1)
            {
                Console.WriteLine("\nChoose an Operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    flag = 0;
                    Console.WriteLine("Exiting Calculator...");
                    break;
                }

                Console.WriteLine("Enter two numbers:");
                string stringNumber1 = Console.ReadLine();
                string stringNumber2 = Console.ReadLine();

                if (int.TryParse(stringNumber1, out int number1) && int.TryParse(stringNumber2, out int number2))
                {
                    int res = 0;

                    switch (choice)
                    {
                        case "1":
                            res = Add(number1, number2);
                            break;
                        case "2":
                            res = Sub(number1, number2);
                            break;
                        case "3":
                            res = Mul(number1, number2);
                            break;
                        case "4":
                            res = Div(number1, number2);
                            break;
                        default:
                            Console.WriteLine("Invalid choice! Please select 1–5.");
                            continue;
                    }

                    Console.WriteLine("Result = " + res);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }
            }
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
            return a / b;
        }
    }
}
