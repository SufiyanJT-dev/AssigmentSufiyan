using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C_Assigment
{
    public partial class SwapNumber
    {
        public SwapNumber()
        {
            int numberOne = 10;
            int numbertwo = 30;
            
            numberOne =numberOne+numbertwo;
            numbertwo = numberOne - numbertwo;
            numberOne =numberOne -  numbertwo;
            Console.WriteLine(numberOne +" "+numbertwo);
        }
    }
    
}
