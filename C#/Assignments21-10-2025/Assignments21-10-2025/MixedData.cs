using System.Collections;

namespace Assignments21_10_2025
{  
      public class MixedData
        {
            public  MixedData()
            {
                ArrayList arr = new ArrayList();
                arr.Add("John");
                arr.Add(25);
                arr.Add(75.5);
                arr.Add(true);
                for (int i = 0; i < arr.Count; i++)
                {
                    Console.WriteLine(arr[i] + " " + arr[i].GetType());
                }
            }
        }
       
    }
