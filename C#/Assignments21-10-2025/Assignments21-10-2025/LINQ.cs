using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments21_10_2025
{
    public  class LINQ
    {
        public LINQ()
        {
            List<string> list = new List<string>();
            list.Add("Sufiyan");
            list.Add("Rahul");
            list.Add("Adarsh");
            list.Add("Arjun");
            list.Add("Tinu");
            Console.WriteLine("Our List Is:");
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine("NAme that strat with A is");
            var NamesStartingWithA = list.Where(list => list.StartsWith("A"));
            foreach (string name in NamesStartingWithA)
            {
                Console.WriteLine(name);
            }
            var LenghtOfNameGreaterThan4=list.Where(list=>list.Length > 4);
            Console.WriteLine("name that have lenght greather than 4 is");
            foreach (string name in LenghtOfNameGreaterThan4) { Console.WriteLine(name); }
                
        }
      

    }
}
