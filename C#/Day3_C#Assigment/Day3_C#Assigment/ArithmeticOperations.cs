using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C_Assigment
{
    public class ArithmeticOperations
    {
        public ArithmeticOperations()
        {
            Console.WriteLine("Input Two Number");
            String StringNumberOne=Console.ReadLine();
            String StringNumberTwo=Console.ReadLine();
            if(int.TryParse(StringNumberOne,out int NumberOne) && int.TryParse(StringNumberTwo,out int NumberTwo))
            {
                Console.WriteLine(Add(NumberOne, NumberTwo));
                Console.WriteLine(Substration(NumberTwo, NumberOne));
                Console.WriteLine(Multipication(NumberOne,NumberTwo));
                Console.WriteLine(Divition(NumberOne,NumberTwo));
                Console.WriteLine(mod(NumberOne,NumberTwo));
                
            }
            else
            {
                Console.WriteLine("Enter a Valid input");
            }
        }
        public int Add(int NumberOne, int NumberTwo)
        {
            return NumberOne + NumberTwo;
        }
        public int Substration(int NumberOne, int NumberTwo)
        {
            return NumberOne - NumberTwo;
        }
        public int Multipication(int NumberOne, int NumberTwo)
        {
            return NumberOne * NumberTwo;
        }
        public int Divition(int NumberOne, int NumberTwo)
        {
            return NumberOne / NumberTwo;
        }
        public int mod(int NumberOne, int NumberTwo)
        {
            return NumberOne % NumberTwo;
        }
    }
}
