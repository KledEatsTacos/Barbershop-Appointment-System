using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    public class Customer : Person
    {
        public string CustomerId { get; set; }

        public Customer(string name, string phoneNumber)
            : base(name, phoneNumber)
        {
        }

        public override string ToString()
        {
            return $"{Name} - {PhoneNumber}";
        }
    }
}
