using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C_Assigment
{
    public class CompareNumbers
    {
        public CompareNumbers(int a, int b) {
            Console.WriteLine("Realtion Operaters");
            if (a == b)
            {
                Console.WriteLine("both ar equal");
            }
            if (a > b)
            {
                Console.WriteLine("A is >B");
            }
            if (a < b) {
                Console.WriteLine("B is >A");
            }
            if (a != b) {
                Console.WriteLine("A !equal to b");
            }
            Console.WriteLine("Logical Operaters");
                if (a > 10 && b > 10) {
                    Console.WriteLine("Both A and B are > 10");
                }
                if (a < 10 && b < 10) {
                    Console.WriteLine("Both A and B are <10");

                }
                if (a < 10 || b < 10)
                {
                    Console.WriteLine("either A or B is < 10 or both <10 ");
                }
                if (a != b)
                {
                    Console.WriteLine("a !=b");
                }
            }
        }
    }

