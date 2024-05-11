using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oop_project
{
    public static class AppointmentFileManager
    {
        private static string filePath = "appointments.txt";

        public static void SaveAppointmentsToFile(List<Appointment> appointments, List<Service> services, List<Employee> employees)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var appointment in appointments)
            {
                sb.AppendLine($"{appointment.CustomerName}|{appointment.CustomerPhoneNumber}|{appointment.AppointmentDate}|{string.Join(",", appointment.SelectedServices.Select(s => s.Name))}|{appointment.Specialist.Name}|{appointment.TotalCost}");
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        public static List<Appointment> LoadAppointmentsFromFile(List<Service> services, List<Employee> employees)
        {
            List<Appointment> appointments = new List<Appointment>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 6)
                    {
                        var customerName = parts[0];
                        var customerPhoneNumber = parts[1];

                        if (DateTime.TryParse(parts[2], out var appointmentDate) && decimal.TryParse(parts[5], out var totalCost))
                        {
                            var serviceNames = parts[3].Split(',');
                            var specialistName = parts[4];

                            var selectedServices = new List<Service>();
                            foreach (var name in serviceNames)
                            {
                                var service = services.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                                if (service != null)
                                {
                                    selectedServices.Add(service);
                                }
                            }

                            var specialist = employees.FirstOrDefault(e => e.Name.Equals(specialistName, StringComparison.OrdinalIgnoreCase));

                            if (specialist != null)
                            {
                                var appointment = new Appointment(selectedServices, specialist, appointmentDate, customerName, customerPhoneNumber, totalCost);
                                appointments.Add(appointment);
                            }
                        }
                    }
                }
            }

            return appointments;
        }
    }
}
