namespace MathUtilities
{
    public class Mathss
    {
        public void IsEven(int NumberVariable)
        {
            if (NumberVariable % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
        public void IsPrime(int NumberVariable)
        {
            if (NumberVariable <= 1)
            {
                Console.WriteLine("Not A Prime");
            }
            else if (NumberVariable == 2)
            {
                Console.WriteLine("it is a prime Number");
            }
            else
            {
                for (int i = 2; i < Math.Sqrt(NumberVariable); i++)
                {
                    if (NumberVariable % i == 0)
                    {
                        Console.WriteLine("Not a prime");
                        return;
                    }
                    Console.WriteLine("it is a Prime");
                }

            }
        }
        public void Factorial(int NumberVariable)
        {
            int fact = 1;
            for(int i = 1; i <= NumberVariable; i++)
            {
                fact=fact*i;
            }
            Console.WriteLine("Factorial of number is :" +fact);

        }
    }
}
