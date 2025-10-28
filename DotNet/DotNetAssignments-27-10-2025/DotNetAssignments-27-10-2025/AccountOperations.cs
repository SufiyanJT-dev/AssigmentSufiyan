using DotNetAssignments_27_10_2025.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignments_27_10_2025
{
    public class AccountOperations
    {
        //public AccountOperations()
        //{
        //    Console.WriteLine("Enter the Customers Details");
        //    Console.Write("Full Name:");
        //    string name = Console.ReadLine();
        //    Console.Write("Email:");
        //    string Email = Console.ReadLine();
        //    Console.Write("PhoneNumber:");
        //    string Number = Console.ReadLine();
        //    Console.Write("Date Of Birth In YYYY-DD-MM:");
        //    string DateOfbrith = Console.ReadLine();
        //    Console.Write("Enter the Street:");
        //    string street = Console.ReadLine();
        //    Console.Write("Enter the City:");
        //    string City = Console.ReadLine();
        //    Console.Write("Enter the State:");
        //    string State = Console.ReadLine();
        //    Console.Write("Enter the postalcode:");
        //    int postalcode = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter the Country:");
        //    string Country = Console.ReadLine();
        //    DateOfbrith = DateOfbrith.Replace('-', ',');
        //    if (DateTime.TryParse(DateOfbrith, out DateTime dateOfbrith2))
        //    {
        //        var contex = new BankingAppDbContext();
        //        Customer customer = new Customer()
        //        {
        //            FullName = name,
        //            Email = Email,
        //            PhoneNumber = Number,
        //            DateOfBirth = dateOfbrith2,
        //            Address = new Address
        //            {
        //                Street = street,
        //                City = City,
        //                State = State,
        //                PostalCode = postalcode,
        //                Country = Country
        //            },
        //            Accounts = new List<Account>
        //            {
        //               new Account{ AccountNumber= "212A3",Balance=1000}

        //            }
        //        };
        //        contex.Customers.Add(customer);
        //        int Changeins = contex.SaveChanges();
        //        if (Changeins > 0)
        //        {
        //            Console.WriteLine("Successfull");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Failed");

        //        }
        //        Console.WriteLine("Enter the Address Details of Customer ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Enter a Vaild date");
        //    }

        //}
        public void display()
        {
            var contex = new BankingAppDbContext();
            var customer = new Customer();
            var Allemployee = contex.Customers.Include(c => c.Address).Include(c => c.Accounts).ToList();
            foreach (var item in Allemployee)
            {
                var accountinfo = item.Accounts.ToArray();
                if (item.Address == null)
                {
                    Console.WriteLine("Customer ID:" + item.Id + " Customer Name: " + item.FullName + " sAddress: not Addded  ");
                }
                else if (item.Accounts.Count <= 0)
                {
                    Console.WriteLine("Customer ID:" + item.Id + " Customer Name: " + item.FullName + "  Account : not Addded  ");
                }
                else
                {
                    foreach (var item1 in accountinfo)
                    {

                        Console.WriteLine("Customer ID:" + item.Id + " Customer Name: " + item.FullName + "Address: " + item.Address.Street + "," + item.Address.City + "," + item.Address.State + "," + item.Address.PostalCode + "," + item.Address.Country + ";" + "AccountId:" + item1.Id + "ACcount NUmber" + item1.AccountNumber);
                    }
                }

            }
        }
        public async void UpdateAddress()
        {
            try
            {
                display();

                Console.WriteLine("Enter the Customer ID ");
                int CustomerID = Convert.ToInt32(Console.ReadLine());
                var contex = new BankingAppDbContext();

                var CusAddress = contex.Customers
    .Include(c => c.Address)
    .FirstOrDefault(c => c.Id == CustomerID);

                if (CusAddress == null)
                {
                    Console.WriteLine("Customer not found!");
                    return;
                }


                Console.WriteLine("enter the new Address");

                Console.Write("Enter the Street:");
                string street = Console.ReadLine();
                Console.Write("Enter the City:");
                string City = Console.ReadLine();
                Console.Write("Enter the State:");
                string State = Console.ReadLine();
                Console.Write("Enter the postalcode:");
                int postalcode = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Country:");
                string country = Console.ReadLine();

                if (CusAddress.Address != null)
                {
                    CusAddress.Address.Street = street;
                    CusAddress.Address.City = City;
                    CusAddress.Address.State = State;
                    CusAddress.Address.PostalCode = postalcode;
                    CusAddress.Address.Country = country;
                }
                else
                {

                    CusAddress.Address = new Address
                    {
                        Street = street,
                        City = City,
                        State = State,
                        PostalCode = postalcode,
                        Country = country
                    };



                }
                int CusRow = contex.SaveChanges();
                if (CusRow > 0)
                {
                    Console.WriteLine("Succesfull");
                }





            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void AddAccount()
        {
            display();
            Console.WriteLine("Enter the Customer ID ");
            int CustomerID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Number");
            string Accountnumber = Console.ReadLine();
            var contex = new BankingAppDbContext();
            var customer = new Customer();

            var customeraccountDetails = contex.Customers.Include(c => c.Accounts).FirstOrDefault(c => c.Id == CustomerID);
            if (customeraccountDetails == null)
            {
                Console.WriteLine("Not found Customer");
                return;
            }

            customeraccountDetails.Accounts.Add(

                    new Account
                    {
                        AccountNumber = Accountnumber,
                        Balance = 0
                    });



            int rowchange = contex.SaveChanges();
            if (rowchange > 0)
            {
                Console.WriteLine("Successfull");
            }
            else
            {
                Console.WriteLine("not Succesfull");
            }
        }
        public void DeleteAccount()
        {
            display();
            Console.WriteLine("Enter the Customer ID ");
            int CustomerID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account Number");
            int AccountID = Convert.ToInt32(Console.ReadLine());
            var contex = new BankingAppDbContext();
            var Account = new Account();
            var AccountDetails = contex.Account.FirstOrDefault(c => c.Id == AccountID && c.CustomerId == CustomerID);
            if (AccountDetails == null)
            {
                Console.WriteLine("Customer not found");
                return;
            }
            contex.Account.Attach(AccountDetails);
            contex.Account.Remove(AccountDetails);
            int changes = contex.SaveChanges();
            if (changes > 0)
            {
                Console.WriteLine("Successfull");
            }
            else
            {
                Console.WriteLine("not Succesfull");
            }


        }
    }

}
