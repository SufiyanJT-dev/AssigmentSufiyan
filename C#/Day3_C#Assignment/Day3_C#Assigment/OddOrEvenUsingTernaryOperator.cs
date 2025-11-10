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
            string stringNumberOne = Console.ReadLine();
            if (int.TryParse(stringNumberOne, out int number))
            {
               string result= (number % 2 == 0) ? "Even Number": "Odd Number"; 
               Console.WriteLine(result);

                
            }
            else
            {
                Console.WriteLine("Enter A valid Number");
            }
        } 

    }
    
}
