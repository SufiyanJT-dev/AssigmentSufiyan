namespace MathUtilities
{
    public class Mathss
    {
        public void IsEven(int numberVariable)
        {
            if (numberVariable % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
        public void IsPrime(int numberVariable)
        {
            if (numberVariable <= 1)
            {
                Console.WriteLine("Not A Prime");
            }
            else if (numberVariable == 2)
            {
                Console.WriteLine("it is a prime Number");
            }
            else
            {
                for (int i = 2; i < Math.Sqrt(numberVariable); i++)
                {
                    if (numberVariable % i == 0)
                    {
                        Console.WriteLine("Not a prime");
                        return;
                    }
                    Console.WriteLine("it is a Prime");
                }

            }
        }
        public void Factorial(int numberVariable)
        {
            int fact = 1;
            for(int i = 1; i <= numberVariable; i++)
            {
                fact=fact*i;
            }
            Console.WriteLine("Factorial of number is :" +fact);

        }
    }
}
