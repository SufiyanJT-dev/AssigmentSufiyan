using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignments_27_10_2025.Models
{
    public class Address
    {
        public int id {  get; set; }
        [MaxLength(100)] public string Street { get; set; }
        [MaxLength(100)]  public string City { get; set; }
        [MaxLength(100)]  public string State { get; set; }
        [MaxLength(100)]  public int PostalCode { get; set; }
        [MaxLength(100)] public string Country { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
