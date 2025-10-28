using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppInEFframWorkAssignments_24_10_2025
{
    public class BankingAppDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=Assignment;user id=sa;password=Sufiyan@123; TrustServerCertificate=True;");
            
        }

    }   
}
