using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C_Assigment
{
    public class GetSumAndAverage
    {
        //public GetSumAndAverage() {
        //    Console.WriteLine("two numbers pls");
        //    String StringNumber1=Console.ReadLine();
        //    String StringNumber2=Console.ReadLine();
        //    if(int.TryParse(StringNumber1,))
        //}
        
        static GetSumAndAverage()
        {
            Console.WriteLine("enter two number");
            string stringNumber1 = Console.ReadLine();
            string stringNumber2 = Console.ReadLine();
            if (int.TryParse(stringNumber1, out int number1) && int.TryParse(stringNumber2, out int number2))
            {
                double sum=0;
                double avg;
               
                SumAndAvg(number1,number2,out sum,out avg);

                Console.WriteLine("Sum:" + sum + "Avg:" + avg);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
       public static void SumAndAvg(int number1,int  number2, out double sum, out double avg)
        {
            sum=0;
            avg=1;
            avg = (number1 + number2) / 2;
            sum = number1 + number2;
        }
    }
}
