using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppInEFframWorkAssignments_24_10_2025
{
    public class UpdateAccount
    {
        public UpdateAccount()
        {
            var context = new BankingAppDbContext();
            var Customers = new Customer();
            Console.WriteLine("Enter the Id of Customber to be Updated");
            int Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the of Customber's new Address ");

            string Address = Console.ReadLine();

            var updateCustomer = context.Customer.FirstOrDefault( c => c.Id == Id);
            if (updateCustomer != null) {
                updateCustomer.Address=Address;

               
                int updatdeedroe=context.SaveChanges();
                if (updatdeedroe > 0)
                {
                    Console.WriteLine("Successfully Updated");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Customer does not exist");
            }

            
        }
    }
}
