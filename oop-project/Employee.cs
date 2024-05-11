using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    public class Employee : Person
    {
        public bool IsAvailable { get; set; }

        public Employee(string name, string phoneNumber, bool isAvailable)
            : base(name, phoneNumber)
        {
            IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            return $"{Name} - {(IsAvailable ? "Available" : "Not Available")}";
        }
    }

}