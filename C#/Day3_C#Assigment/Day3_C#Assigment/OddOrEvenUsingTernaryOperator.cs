using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C_Assigment
{
    public class OddOrEvenUsingTernaryOperator
    {
        public OddOrEvenUsingTernaryOperator()
        {
            Console.WriteLine("Input  Number");
            String StringNumberOne = Console.ReadLine();
            if (int.TryParse(StringNumberOne, out int Number))
            {
               string Result= (Number % 2 == 0) ? "Even Number": "Odd Number"; 
               Console.WriteLine(Result);

                
            }
            else
            {
                Console.WriteLine("Enter A valid Number");
            }
        } 

    }
    
}
