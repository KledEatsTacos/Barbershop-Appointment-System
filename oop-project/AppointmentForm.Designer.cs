namespace oop_project
{
    partial class AppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerPhoneNumber = new System.Windows.Forms.Label();
            this.customerPhoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.specialistComboBox = new System.Windows.Forms.ComboBox();
            this.hairSpecialistComboBox = new System.Windows.Forms.Label();
            this.servicesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Location = new System.Drawing.Point(186, 40);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(153, 22);
            this.customerNameTextbox.TabIndex = 0;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(73, 43);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(107, 16);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // customerPhoneNumber
            // 
            this.customerPhoneNumber.AutoSize = true;
            this.customerPhoneNumber.Location = new System.Drawing.Point(73, 89);
            this.customerPhoneNumber.Name = "customerPhoneNumber";
            this.customerPhoneNumber.Size = new System.Drawing.Size(100, 16);
            this.customerPhoneNumber.TabIndex = 2;
            this.customerPhoneNumber.Text = "Phone Number:";
            // 
            // customerPhoneNumberTextbox
            // 
            this.customerPhoneNumberTextbox.Location = new System.Drawing.Point(186, 86);
            this.customerPhoneNumberTextbox.Name = "customerPhoneNumberTextbox";
            this.customerPhoneNumberTextbox.Size = new System.Drawing.Size(153, 22);
            this.customerPhoneNumberTextbox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(303, 375);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(154, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(264, 325);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(71, 16);
            this.totalCostLabel.TabIndex = 5;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Location = new System.Drawing.Point(381, 322);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalCostTextBox.TabIndex = 6;
            // 
            // specialistComboBox
            // 
            this.specialistComboBox.FormattingEnabled = true;
            this.specialistComboBox.Location = new System.Drawing.Point(186, 131);
            this.specialistComboBox.Name = "specialistComboBox";
            this.specialistComboBox.Size = new System.Drawing.Size(153, 24);
            this.specialistComboBox.TabIndex = 7;
            // 
            // hairSpecialistComboBox
            // 
            this.hairSpecialistComboBox.AutoSize = true;
            this.hairSpecialistComboBox.Location = new System.Drawing.Point(73, 131);
            this.hairSpecialistComboBox.Name = "hairSpecialistComboBox";
            this.hairSpecialistComboBox.Size = new System.Drawing.Size(97, 16);
            this.hairSpecialistComboBox.TabIndex = 8;
            this.hairSpecialistComboBox.Text = "Hair Specialist:";
            // 
            // servicesCheckedListBox
            // 
            this.servicesCheckedListBox.FormattingEnabled = true;
            this.servicesCheckedListBox.Location = new System.Drawing.Point(235, 185);
            this.servicesCheckedListBox.Name = "servicesCheckedListBox";
            this.servicesCheckedListBox.Size = new System.Drawing.Size(283, 106);
            this.servicesCheckedListBox.TabIndex = 9;
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Location = new System.Drawing.Point(364, 43);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(117, 16);
            this.appointmentDateLabel.TabIndex = 10;
            this.appointmentDateLabel.Text = "Appointment Date:";
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Location = new System.Drawing.Point(487, 40);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(251, 22);
            this.appointmentDatePicker.TabIndex = 11;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 483);
            this.Controls.Add(this.appointmentDatePicker);
            this.Controls.Add(this.appointmentDateLabel);
            this.Controls.Add(this.servicesCheckedListBox);
            this.Controls.Add(this.hairSpecialistComboBox);
            this.Controls.Add(this.specialistComboBox);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.customerPhoneNumberTextbox);
            this.Controls.Add(this.customerPhoneNumber);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameTextbox);
            this.Name = "AppointmentForm";
            this.Text = "New Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerPhoneNumber;
        private System.Windows.Forms.TextBox customerPhoneNumberTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.ComboBox specialistComboBox;
        private System.Windows.Forms.Label hairSpecialistComboBox;
        private System.Windows.Forms.CheckedListBox servicesCheckedListBox;
        private System.Windows.Forms.Label appointmentDateLabel;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
    }
}