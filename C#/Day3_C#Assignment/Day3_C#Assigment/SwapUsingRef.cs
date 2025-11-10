using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C_Assigment
{
    public class SwapUsingRef
    {
        public SwapUsingRef() {
            Console.WriteLine("Enter two number ");
            string stringNumber1=Console.ReadLine();
            string stringNumber2=Console.ReadLine();
            if (int.TryParse(stringNumber1, out int number1) && int.TryParse(stringNumber2, out int number2)) {
                Console.WriteLine("Number one = "+number1+"Number two"+number2);
                SwapNumber(ref number1, ref number2);
                Console.WriteLine("After using Ref Keyword Number one = " + number1 + "Number two" + number2);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        public void SwapNumber(ref int number1,ref int number2) { 
            int temp=number1;
            number1 = number2;
            number2 = temp;
            
        }
    }
}
