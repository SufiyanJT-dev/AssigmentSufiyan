using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppInEFframWorkAssignments_24_10_2025
{
    public class AddAccount
    {
        public AddAccount()
        {
            Console.WriteLine("Enter the Number Of Employees to Be Added");
            int CountIdis=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < CountIdis; i++)
            {
                Console.WriteLine("Enter the Full Name Of the Employee");
                string Fullname = Console.ReadLine();
                Console.WriteLine("Enter the Email Of the Employee");
                string Email = Console.ReadLine();
                Console.WriteLine("Enter the Phone NUmber");
                string PhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter the Date of Birth in YYYY-MM-DD");

                string stringDateOfBirth = Console.ReadLine();
                stringDateOfBirth = stringDateOfBirth.Replace('-', ',');
                if (DateTime.TryParse(stringDateOfBirth, out DateTime dateOfBirth))
                {


                    Console.WriteLine("Enter the Address");
                    string Address = Console.ReadLine();
                    DateTime CreatedDate = DateTime.Now;

                    var Contex = new BankingAppDbContext();
                    Customer customer = new Customer()
                    {
                        FullName = Fullname,
                        Email = Email,
                        PhoneNumber = PhoneNumber,
                        DateOfBirth = dateOfBirth,
                        Address = Address,
                        CreatedDate = CreatedDate,
                    };
                    Contex.Customer.Add(customer);
                    int rowchange = Contex.SaveChanges();
                    if (rowchange > 0)
                    {
                        Console.WriteLine("successfully");
                    }
                    else
                    {
                        Console.WriteLine("Check Again");
                    }

                }
                else
                {
                    Console.WriteLine("Enter a valid date");
                }
            }
        }

    }
}

