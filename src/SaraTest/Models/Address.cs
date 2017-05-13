using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraTest.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Qualifier { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
