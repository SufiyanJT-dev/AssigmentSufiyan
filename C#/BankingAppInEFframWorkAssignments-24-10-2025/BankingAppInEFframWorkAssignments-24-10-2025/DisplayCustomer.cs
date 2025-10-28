using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppInEFframWorkAssignments_24_10_2025
{
    public class DisplayCustomer
    {
        public DisplayCustomer()
        {
            var contex=new BankingAppDbContext();
            var customer = new Customer();
            var customerdisplay = contex.Customer.ToList();
            foreach (var customers in customerdisplay)

            {               
                Console.WriteLine("Full name:" + customers.FullName+" Email:"+customers.Email+" Phone Number: "+customers.PhoneNumber+" Date Of Birth: "+customers.DateOfBirth+" Address:"+customers.Address);
            }

        }
    }
}
