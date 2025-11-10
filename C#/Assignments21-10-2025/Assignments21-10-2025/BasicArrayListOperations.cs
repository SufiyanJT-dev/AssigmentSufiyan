using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments21_10_2025
{
    public partial class BasicArrayListOperations
    {
        public BasicArrayListOperations()
        {
            ArrayList array = new ArrayList();
            array.Add("Sufiyan");
            array.Add("Rahul");
            array.Add("Arjun");
            array.Add("Adarsh");
            array.Add("Tinu");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            array.RemoveAt(1);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            array.Insert(2, "Bimal");
            for(int i=0; i<array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
       
    }
}
