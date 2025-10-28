using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppInEFframWorkAssignments_24_10_2025
{
    public class deleteAcc
    {
        public deleteAcc()
        {
            var context = new BankingAppDbContext();
            var Customers = new Customer();
            Console.WriteLine("Enter the Id of Customber to be Updated");
            int Id = Convert.ToInt32(Console.ReadLine());
            

            var DeleteCustomer = context.Customer.FirstOrDefault(c => c.Id == Id);
            if (DeleteCustomer != null)
            {
               
                context.Customer.Remove(DeleteCustomer);

                int Deleredeedroe = context.SaveChanges();
                if (Deleredeedroe > 0)
                {
                    Console.WriteLine("Successfully deleted");
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
