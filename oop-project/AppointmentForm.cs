using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_project
{
    public partial class AppointmentForm : Form
    {

        private List<Employee> employees;
        private List<Service> services;
        public static List<Appointment> Appointments = new List<Appointment>();

        private Appointment appointmentToEdit;

        private List<Service> GetSelectedServices()
        {
            var selectedServices = new List<Service>();

            foreach (var item in servicesCheckedListBox.CheckedItems)
            {
                var itemText = item.ToString();
                var serviceName = itemText.Substring(0, itemText.LastIndexOf(" - $"));

                var service = services.Find(s => s.Name.Equals(serviceName, StringComparison.Ordinal));
                if (service != null)
                {
                    selectedServices.Add(service);
                }
            }
            return selectedServices;
        }

        //constructor for new appointment
        public AppointmentForm(List<Employee> availableEmployees, List<Service> availableServices)
        {
            InitializeComponent();
            employees = availableEmployees;
            services = availableServices;
            InitializeSpecialistComboBox();
            InitializeServicesCheckedListBox();
        }

        //constructor for editing an appointment
        public AppointmentForm(List<Employee> employees, List<Service> services, Appointment appointmentToEdit)
        {
            InitializeComponent();
            this.employees = employees;
            this.services = services;
            this.appointmentToEdit = appointmentToEdit;


            InitializeSpecialistComboBox();
            InitializeServicesCheckedListBox();
            PreFillAppointmentDetails();
        }

        private void PreFillAppointmentDetails()
        {
            if (appointmentToEdit != null)
            {
                //prefill text boxes
                customerNameTextbox.Text = appointmentToEdit.CustomerName;
                customerPhoneNumberTextbox.Text = appointmentToEdit.CustomerPhoneNumber;
                appointmentDatePicker.Value = appointmentToEdit.AppointmentDate;

                //preselect specialist in the thingy for specialists
                specialistComboBox.DataSource = employees;
                specialistComboBox.DisplayMember = "Name";
                specialistComboBox.ValueMember = "Name";
                specialistComboBox.SelectedItem = employees.FirstOrDefault(emp => emp.Name == appointmentToEdit.Specialist.Name);

                //precheck services
                foreach (var service in appointmentToEdit.SelectedServices)
                {
                    for (int i = 0; i < servicesCheckedListBox.Items.Count; i++)
                    {
                        var itemText = servicesCheckedListBox.Items[i].ToString();
                        var serviceName = itemText.Substring(0, itemText.LastIndexOf(" - $"));
                        if (service.Name.Equals(serviceName, StringComparison.Ordinal))
                        {
                            servicesCheckedListBox.SetItemChecked(i, true);
                            break;
                        }
                    }
                }

                //calculate total cost

                decimal totalCost = appointmentToEdit.SelectedServices.Sum(s => s.Price);
                totalCostTextBox.Text = totalCost.ToString("C");
            }
        }

        //only displays available employees by the way  
        private void InitializeSpecialistComboBox()
        {
            var availableEmployees = employees.Where(emp => emp.IsAvailable).ToList();

            specialistComboBox.DisplayMember = "Name";
            specialistComboBox.ValueMember = "Name";
            specialistComboBox.DataSource = availableEmployees;

            if (appointmentToEdit != null)
            {
                specialistComboBox.SelectedItem = availableEmployees.FirstOrDefault(emp => emp.Name == appointmentToEdit.Specialist.Name);
            }
        }

        //displays service and price
        private void InitializeServicesCheckedListBox()
        {
            servicesCheckedListBox.Items.Clear();

            foreach (var service in services)
            {
                string displayText = $"{service.Name} - ${service.Price}";
                servicesCheckedListBox.Items.Add(displayText, false);
            }
            servicesCheckedListBox.ItemCheck += ServicesCheckedListBox_ItemCheck;
        }


        //calculates the total cost of the services chosen
        private decimal CalculateTotalCost(int? changingItemIndex = null, CheckState? newState = null)
        {
            decimal totalCost = 0;

            for (int i = 0; i < servicesCheckedListBox.Items.Count; i++)
            {
                bool isChecked = servicesCheckedListBox.GetItemChecked(i);
                if (changingItemIndex.HasValue && i == changingItemIndex.Value)
                {
                    isChecked = newState == CheckState.Checked;
                }

                if (isChecked)
                {
                    var itemText = servicesCheckedListBox.Items[i].ToString();
                    var serviceName = itemText.Substring(0, itemText.LastIndexOf(" - $"));
                    var service = services.Find(s => s.Name.Equals(serviceName, StringComparison.Ordinal));
                    if (service != null)
                    {
                        totalCost += service.Price;
                    }
                }
            }

            return totalCost;
        }


        private void ServicesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (this.IsHandleCreated)
            {
                BeginInvoke((Action)(() =>
                {
                    if (servicesCheckedListBox != null && totalCostTextBox != null)
                    {
                        decimal totalCost = CalculateTotalCost(e.Index, e.NewValue);
                        totalCostTextBox.Text = totalCost.ToString("C");
                    }
                }));
            }
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            //this part is for new appointments.

            if (GetSelectedServices().Count == 0)
            {
                MessageBox.Show("Please select at least one service.");
                return;
            }

            if (specialistComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a specialist.");
                return;
            }

            if (string.IsNullOrWhiteSpace(customerNameTextbox.Text))
            {
                MessageBox.Show("Please enter a customer name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(customerPhoneNumberTextbox.Text))
            {
                MessageBox.Show("Please enter a customer phone number.");
                return;
            }

            if (appointmentDatePicker.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Please select a valid date.");
                return;
            }

            List<Service> selectedServices = GetSelectedServices();
            Employee selectedSpecialist = specialistComboBox.SelectedItem as Employee;
            DateTime selectedDate = appointmentDatePicker.Value;
            string customerName = customerNameTextbox.Text;
            string customerPhoneNumber = customerPhoneNumberTextbox.Text;
            decimal totalCost = CalculateTotalCost();

            if (appointmentToEdit != null)
            {
                var index = Appointments.FindIndex(a => a.Id == appointmentToEdit.Id);

                if (index != -1)
                {
                    Appointments[index] = new Appointment(selectedServices, selectedSpecialist, selectedDate, customerName, customerPhoneNumber, totalCost);
                    MessageBox.Show("Appointment updated successfully!");
                }
            }
            else
            {

                Appointment newAppointment = new Appointment(selectedServices, selectedSpecialist, selectedDate, customerName, customerPhoneNumber, totalCost);
                Appointments.Add(newAppointment);
                MessageBox.Show("Appointment added successfully!");
            }

            ((Form1)this.Owner)?.UpdateAppointmentsListView();
            this.DialogResult = DialogResult.OK;

            AppointmentFileManager.SaveAppointmentsToFile(AppointmentForm.Appointments, services, employees);
        }
    }
}