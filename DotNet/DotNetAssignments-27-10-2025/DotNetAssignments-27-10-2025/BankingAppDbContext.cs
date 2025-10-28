using DotNetAssignments_27_10_2025.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignments_27_10_2025
{
    public class BankingAppDbContext:DbContext
    {
        public DbSet<Models.Customer> Customers {  get; set; }
        public DbSet<Models.Address> Address { get; set; }
        public DbSet<Models.Account> Account { get; set; }
      
       
        string Constring = "Server=Localhost;database=Banking;User id=sa;Password=Sufiyan@123;TrustServerCertificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Account>().HasIndex(AN => AN.AccountNumber).IsUnique();
        }
    }
}
