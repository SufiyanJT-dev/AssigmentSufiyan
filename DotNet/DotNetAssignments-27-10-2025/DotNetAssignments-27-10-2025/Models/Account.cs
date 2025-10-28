using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignments_27_10_2025.Models
{
    public class Account
    {

        public int Id { get; set; }
        [Required][MaxLength(30)] public string AccountNumber { get; set; }
        public int Balance { get; set; } = 0;
        public int CustomerId {  get; set; }
        public Customer Customer { get; set; }
    }

}
