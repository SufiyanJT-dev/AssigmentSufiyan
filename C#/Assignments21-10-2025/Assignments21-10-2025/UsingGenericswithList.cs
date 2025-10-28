using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments21_10_2025
{
    public class UsingGenericswithList
    {
        public UsingGenericswithList() {
            List<int> list = new List<int>();
            list.Add(78);
            list.Add(78);
            list.Add(92);
            list.Add(67);
            list.Add(88);
            list.Add(95);
            Console.WriteLine( list.Average());
            Console.WriteLine(list.Min());
            list.Remove(list.Min());
            list.Sort();
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
       
    }
}
