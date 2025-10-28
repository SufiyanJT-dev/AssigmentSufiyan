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
            int NumberOne = 10;
            int Numbertwo = 30;
            
            NumberOne =NumberOne+Numbertwo;
            Numbertwo = NumberOne- Numbertwo;
            NumberOne=NumberOne- Numbertwo;
            Console.WriteLine(NumberOne+" "+Numbertwo);
        }
    }
    
}
