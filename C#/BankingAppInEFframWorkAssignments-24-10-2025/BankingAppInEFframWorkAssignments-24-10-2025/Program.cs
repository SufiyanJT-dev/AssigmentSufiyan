//// See https://aka.ms/new-console-template for more information
//using BankingAppInEFframWorkAssignments_24_10_2025;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using System;

//Console.WriteLine("Hello, World!");
//var context = new BankingAppDbContext();
//var Customers = new List<Customer>
//{
//  new Customer {

//    FullName = "Maria Gonzalez",
//    Email = "maria.gonzalez@gmail.com",
//    PhoneNumber = "-1601",
//    DateOfBirth = new DateTime(1990,08,25),
//    Address = "45 Calle Mayor, Madrid, Spain",
//    CreatedDate = new DateTime(2025 - 02 - 15)
//  },

//  new Customer {

//      FullName = "Liam O’Connor",
//    Email = "liam.oconnor@outlook.com",
//    PhoneNumber = "-907779",
//    DateOfBirth = new DateTime(1985-11-03),
//    Address = "89 Abbey Rd, London, UK",
//    CreatedDate = new DateTime(2025-03-10)
//        },
//  new Customer{
//        FullName = "Sophia Müller",
//    Email = "sophia.mueller@gmail.com",
//    PhoneNumber = "-2345780",
//    DateOfBirth = new DateTime(1992-07-18),
//    Address = "22 Berliner Str, Berlin, Germany",
//    CreatedDate = new DateTime(2025-04-05)
//  },
//  new Customer
//  {
//            FullName = "Ethan Brown",
//    Email = "ethan.brown@yahoo.com",
//    PhoneNumber = "-1374",
//    DateOfBirth = new DateTime(1989-02-14),
//    Address = "17 King St, Sydney, Australia",
//    CreatedDate = new DateTime(2025-04-05)

//  }
//    };
//context.Customer.AddRange(Customers);
//context.SaveChanges();
using BankingAppInEFframWorkAssignments_24_10_2025;
DisplayCustomer displayCustomer = new DisplayCustomer();