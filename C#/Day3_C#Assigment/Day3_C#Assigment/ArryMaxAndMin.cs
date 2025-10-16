using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C_Assigment
{
    public class ArryMaxAndMin
    {
        public ArryMaxAndMin() {
            int [] arr;
            int Length;
            int Max;
            int Min;
            Console.WriteLine("Enter the total Numbers In array:");
            String StringLenth=Console.ReadLine();
            
            if(int.TryParse(StringLenth, out Length))
            {
                arr = new int[Length];
                Console.WriteLine("Enter the  Numbers to array:");
                for (int i = 0; i < Length; i++)
                {
                    String Stringi = Console.ReadLine();
                    if(int.TryParse (Stringi, out int num))
                    {
                        arr[i] = num;
                    }
                    else
                    {
                        arr[i] = 0;
                    }
                   
                }
                MinAndMax(arr, out Max, out Min);
                Console.WriteLine("Max:"+Max+"Min:"+Min);

            }
            else
            {
                Console.WriteLine("Invalid Lenth");
            }
             
        }
        public static void MinAndMax(int [] Arr,out int Max,out int Min)
        {
            Max=Arr[0];
            Min=Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] > Max)
                {
                    Max = Arr[i]; 
                }
                if (Arr[i] < Min) { 
                Min=Arr[i];
                 }
            }
        }

    }
}
