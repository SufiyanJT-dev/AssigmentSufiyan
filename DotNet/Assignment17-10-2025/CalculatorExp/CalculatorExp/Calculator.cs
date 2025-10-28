using System;

namespace CalculatorExp
{
    internal class Calculator
    {
        public  Calculator()
        {
            double number1 = 0, number2 = 0;
            int operation = 0;

            try
            {
                Console.Write("Enter first number: ");
                number1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                number2 = double.Parse(Console.ReadLine());


                Console.WriteLine("Select the operation to perform:");
                Console.WriteLine("1. Add\n2. Subtract\n3. Multiply\n4. Divide");

                operation = int.Parse(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case 1:
                        result = Add(number1, number2);
                        break;
                    case 2:
                        result = Sub(number1, number2);
                        break;
                    case 3:
                        result = Mul(number1, number2);
                        break;
                    case 4:
                        result = Div(number1, number2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected.");
                        return;
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input. Please enter Number values.");
                Console.WriteLine($"[Log] FormatException: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(" Cannot divide by zero.");
                Console.WriteLine($"[Log] DivideByZeroException: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(" Number too large ");
                Console.WriteLine($"[Log] OverflowException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"[Log] Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Calculator session ended.\n");
            }
        }

        private double Add(double a, double b)
        {
            return (a + b);
        }

        private double Sub(double a, double b)
        {
            return (a - b);
        }

        private double Mul(double a, double b)
        {
            return (a * b);
        }

        private double Div(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Second number (divisor) is zero.");
            return a / b;
        }
    }


}