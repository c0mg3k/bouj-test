using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraTest.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Address> Locations { get; set; }
        public decimal Rating { get; set; }
        public string ImageUrl { get; set; }
    }
}
