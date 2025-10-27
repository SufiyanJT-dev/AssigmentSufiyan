using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C_Assigment
{
    public class Calculator
    {
        public Calculator()
        {
            int flage = 1;
            while (flage == 1)
            {
                Console.WriteLine("Choose a Operation \n 1.Addition\t\t\n 2.Substation\t\t\n 3.Multipication\t\t\n 4.Divition\t\t\n 5.Exit");
                String Choice = Console.ReadLine();
                int Res=0;
                Console.WriteLine("Enter Two Numbers pls");
                string StringNumber1 = Console.ReadLine();
                String StringNumber2 = Console.ReadLine();
                if (int.TryParse(StringNumber1, out int Number1) && int.TryParse(StringNumber2, out int Number2))
                {
                    switch (Choice)
                    {
                        case "1":
                            Res=Add(Number1, Number2);
                            break;
                        case "2":
                            Res = Sub(Number1, Number2);
                            break;
                        case "3":
                            Res = Mul(Number1, Number2);
                            break;
                        case "4":
                            Div(Number1, Number2);
                            break;
                        case "5":
                            flage = 0;
                            break;
                        default:
                            Console.WriteLine("Enter a Valid Numbers");
                            break;

                    }
                    Console.WriteLine("Ans= " + Res);

                }

            }
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }


    }
}
