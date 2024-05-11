using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    public class Appointment
    {
        private static int nextId = 1;

        public int Id { get; private set; } 
        public List<Service> SelectedServices { get; set; }
        public Employee Specialist { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public decimal TotalCost { get; set; }

        public Appointment(List<Service> selectedServices, Employee specialist, DateTime appointmentDate, string customerName, string customerPhoneNumber, decimal totalCost)
        {
            Id = nextId++; 
            SelectedServices = selectedServices;
            Specialist = specialist;
            AppointmentDate = appointmentDate;
            CustomerName = customerName;
            CustomerPhoneNumber = customerPhoneNumber;
            TotalCost = selectedServices.Sum(service => service.Price);
        }

        public void Update(List<Service> selectedServices, Employee specialist, DateTime appointmentDate, string customerName, string customerPhoneNumber, decimal totalCost)
        {
            SelectedServices = selectedServices;
            Specialist = specialist;
            AppointmentDate = appointmentDate;
            CustomerName = customerName;
            CustomerPhoneNumber = customerPhoneNumber;
            TotalCost = selectedServices.Sum(service => service.Price);
        }
    }
}
