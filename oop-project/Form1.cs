using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_project
{

    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            //when the form loads the program reads the file and updates the listview
            AppointmentForm.Appointments = AppointmentFileManager.LoadAppointmentsFromFile(services, employees);
            UpdateAppointmentsListView();
        }

        private List<Employee> employees;
        private List<Service> services;
        public Form1()
        {
            InitializeComponent();
            InitializeEmployees();
            InitializeServices();
        }

        //random phone numbers
        private void InitializeEmployees()
        {
            employees = new List<Employee>
            {
                new Employee("John Doe", "0551xxxxxxx", true),
                new Employee("Jane Doe", "0552xxxxxxx", false),
                new Employee("John Smith", "0553xxxxxxx", false),
                new Employee("Jane Smith", "0554xxxxxxx", true)
            };
        }

        //typical services in a really expensive new york barbershop
        private void InitializeServices()
        {
            services = new List<Service>
            {
                new Service("Trimmer Haircut", 65),
                new Service("Scissors Haircut", 80),
                new Service("Beard Trim", 40),
                new Service("Hair Coloring", 150),
                new Service("Consultation", 100)
            };
        }





        //shows employees and phone number and availability
        private void employeesButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var employee in employees)
            {
                string availabilityStatus = employee.IsAvailable ? "Available" : "Not Available";
                sb.AppendLine($"{employee.Name} - {employee.PhoneNumber} - {availabilityStatus}");
            }
            MessageBox.Show(sb.ToString(), "Hair Specialists");
        }

        //displays available services and their prices
        private void servicesButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("Available Services:\n");
            foreach (var service in services)
            {
                sb.AppendLine(service.ToString());
            }
            MessageBox.Show(sb.ToString(), "Services:");
        }

        //opens new form to make appointment
        private void newAppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm(employees.Where(employee => employee.IsAvailable).ToList(), services);
            appointmentForm.Owner = this;
            DialogResult result = appointmentForm.ShowDialog();
        }

        //stuff to display the appointments
        private void InitializeAppointmentsListView()
        {
            appointmentsListView.View = View.Details;
            appointmentsListView.Columns.Add("Customer", -2, HorizontalAlignment.Left);
            appointmentsListView.Columns.Add("Phone", -2, HorizontalAlignment.Left);
            appointmentsListView.Columns.Add("Date", -2, HorizontalAlignment.Left);
            appointmentsListView.Columns.Add("Services", -2, HorizontalAlignment.Left);
            appointmentsListView.Columns.Add("Price", -2, HorizontalAlignment.Left);
            appointmentsListView.Columns.Add("Specialist", -2, HorizontalAlignment.Left);
        }

        public void UpdateAppointmentsListView()
        {
            appointmentsListView.Items.Clear();

            foreach (var appointment in AppointmentForm.Appointments)
            {
                var services = string.Join(", ", appointment.SelectedServices.Select(s => s.Name));
                var row = new string[] {
                    appointment.CustomerName,
                    appointment.CustomerPhoneNumber,
                    appointment.AppointmentDate.ToShortDateString(),
                    services,
                    appointment.TotalCost.ToString("C"),
                    appointment.Specialist.Name
                };
                var listViewItem = new ListViewItem(row);
                appointmentsListView.Items.Add(listViewItem);
            }
        }

        //user chooses an appointment from the list and simply clicks the button to delete
        private void deleteAppointmentButton_Click(object sender, EventArgs e)
        {
            if (appointmentsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an appointment to delete.");
                return;
                
            }

            var selectedItem = appointmentsListView.SelectedItems[0];
            string customerName = selectedItem.SubItems[0].Text;
            string appointmentDateStr = selectedItem.SubItems[2].Text;
            DateTime appointmentDate = DateTime.Parse(appointmentDateStr);

            var appointmentToDelete = AppointmentForm.Appointments.FirstOrDefault(a => a.CustomerName == customerName && a.AppointmentDate.ToShortDateString() == appointmentDate.ToShortDateString());


            AppointmentForm.Appointments.Remove(appointmentToDelete);

            UpdateAppointmentsListView();
            AppointmentFileManager.SaveAppointmentsToFile(AppointmentForm.Appointments, services, employees);
        }

        private void editAppointmentButton_Click(object sender, EventArgs e)
        {
            if (appointmentsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an appointment to edit.");
                return;
            }

            var selectedItem = appointmentsListView.SelectedItems[0];
            string customerName = selectedItem.SubItems[0].Text;
            string appointmentDateStr = selectedItem.SubItems[2].Text;
            DateTime appointmentDate = DateTime.Parse(appointmentDateStr);

            var appointmentToEdit = AppointmentForm.Appointments.FirstOrDefault(a => a.CustomerName == customerName && a.AppointmentDate.ToShortDateString() == appointmentDate.ToShortDateString());

            if (appointmentToEdit != null)
            {
                List<Employee> availableEmployees = employees.Where(emp => emp.IsAvailable).ToList();
                AppointmentForm appointmentForm = new AppointmentForm(availableEmployees, services, appointmentToEdit);
                appointmentForm.Owner = this;
                DialogResult result = appointmentForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    UpdateAppointmentsListView();
                }
            }
            else
            {
                MessageBox.Show("Appointment not found.");
            }
        }

    }
}
