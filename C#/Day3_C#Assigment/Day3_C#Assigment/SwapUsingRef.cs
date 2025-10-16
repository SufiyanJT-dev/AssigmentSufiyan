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
            string StringNumber1=Console.ReadLine();
            string StringNumber2=Console.ReadLine();
            if (int.TryParse(StringNumber1, out int Number1) && int.TryParse(StringNumber2, out int Number2)) {
                Console.WriteLine("Number one = "+Number1+"Number two"+Number2);
                SwapNumber(ref Number1, ref Number2);
                Console.WriteLine("After using Ref Keyword Number one = " + Number1 + "Number two" + Number2);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        public void SwapNumber(ref int Number1,ref int Number2) { 
            int temp=Number1;
            Number1 = Number2;
            Number2 = temp;
            
        }
    }
}
