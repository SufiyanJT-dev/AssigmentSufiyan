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
            string StringNumber1 = Console.ReadLine();
            string StringNumber2 = Console.ReadLine();
            if (int.TryParse(StringNumber1, out int Number1) && int.TryParse(StringNumber2, out int Number2))
            {
                double Sum=0;
                double Avg;
               
                SumAndAvg(Number1,Number2,out Sum,out Avg);

                Console.WriteLine("Sum:" + Sum + "Avg:" + Avg);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
       public static void SumAndAvg(int Number1,int  Number2, out double Sum, out double Avg)
        {
            Sum=0;
            Avg=1;
            Avg = (Number1 + Number2) / 2;
            Sum = Number1 + Number2;
        }
    }
}
