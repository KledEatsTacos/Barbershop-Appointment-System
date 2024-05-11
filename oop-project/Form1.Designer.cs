namespace oop_project
{
    partial class Form1
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
            this.appointmentsLabel = new System.Windows.Forms.Label();
            this.employeesButton = new System.Windows.Forms.Button();
            this.servicesButton = new System.Windows.Forms.Button();
            this.newAppointmentButton = new System.Windows.Forms.Button();
            this.editAppointmentButton = new System.Windows.Forms.Button();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentsListView = new System.Windows.Forms.ListView();
            this.customerNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servicesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specialistHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // appointmentsLabel
            // 
            this.appointmentsLabel.AutoSize = true;
            this.appointmentsLabel.Location = new System.Drawing.Point(65, 21);
            this.appointmentsLabel.Name = "appointmentsLabel";
            this.appointmentsLabel.Size = new System.Drawing.Size(92, 16);
            this.appointmentsLabel.TabIndex = 1;
            this.appointmentsLabel.Text = "Appointments:";
            // 
            // employeesButton
            // 
            this.employeesButton.Location = new System.Drawing.Point(691, 513);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(162, 29);
            this.employeesButton.TabIndex = 2;
            this.employeesButton.Text = "Employees";
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // servicesButton
            // 
            this.servicesButton.Location = new System.Drawing.Point(859, 513);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(162, 29);
            this.servicesButton.TabIndex = 3;
            this.servicesButton.Text = "Services";
            this.servicesButton.UseVisualStyleBackColor = true;
            this.servicesButton.Click += new System.EventHandler(this.servicesButton_Click);
            // 
            // newAppointmentButton
            // 
            this.newAppointmentButton.Location = new System.Drawing.Point(85, 515);
            this.newAppointmentButton.Name = "newAppointmentButton";
            this.newAppointmentButton.Size = new System.Drawing.Size(196, 27);
            this.newAppointmentButton.TabIndex = 4;
            this.newAppointmentButton.Text = "New Appointment";
            this.newAppointmentButton.UseVisualStyleBackColor = true;
            this.newAppointmentButton.Click += new System.EventHandler(this.newAppointmentButton_Click);
            // 
            // editAppointmentButton
            // 
            this.editAppointmentButton.Location = new System.Drawing.Point(489, 514);
            this.editAppointmentButton.Name = "editAppointmentButton";
            this.editAppointmentButton.Size = new System.Drawing.Size(196, 28);
            this.editAppointmentButton.TabIndex = 5;
            this.editAppointmentButton.Text = "Edit Appointment";
            this.editAppointmentButton.UseVisualStyleBackColor = true;
            this.editAppointmentButton.Click += new System.EventHandler(this.editAppointmentButton_Click);
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.Location = new System.Drawing.Point(287, 515);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(196, 27);
            this.deleteAppointmentButton.TabIndex = 6;
            this.deleteAppointmentButton.Text = "Delete Appointment";
            this.deleteAppointmentButton.UseVisualStyleBackColor = true;
            this.deleteAppointmentButton.Click += new System.EventHandler(this.deleteAppointmentButton_Click);
            // 
            // appointmentsListView
            // 
            this.appointmentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customerNameHeader,
            this.phoneNumberHeader,
            this.dateHeader,
            this.servicesHeader,
            this.priceHeader,
            this.specialistHeader});
            this.appointmentsListView.FullRowSelect = true;
            this.appointmentsListView.HideSelection = false;
            this.appointmentsListView.Location = new System.Drawing.Point(118, 87);
            this.appointmentsListView.Name = "appointmentsListView";
            this.appointmentsListView.Size = new System.Drawing.Size(845, 378);
            this.appointmentsListView.TabIndex = 7;
            this.appointmentsListView.UseCompatibleStateImageBehavior = false;
            this.appointmentsListView.View = System.Windows.Forms.View.Details;
            // 
            // customerNameHeader
            // 
            this.customerNameHeader.Text = "Customer Name";
            this.customerNameHeader.Width = 140;
            // 
            // phoneNumberHeader
            // 
            this.phoneNumberHeader.Text = "Phone";
            this.phoneNumberHeader.Width = 100;
            // 
            // dateHeader
            // 
            this.dateHeader.Text = "Date";
            this.dateHeader.Width = 90;
            // 
            // servicesHeader
            // 
            this.servicesHeader.Text = "Services";
            this.servicesHeader.Width = 150;
            // 
            // priceHeader
            // 
            this.priceHeader.Text = "Price";
            this.priceHeader.Width = 45;
            // 
            // specialistHeader
            // 
            this.specialistHeader.Text = "Specialist";
            this.specialistHeader.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 603);
            this.Controls.Add(this.appointmentsListView);
            this.Controls.Add(this.deleteAppointmentButton);
            this.Controls.Add(this.editAppointmentButton);
            this.Controls.Add(this.newAppointmentButton);
            this.Controls.Add(this.servicesButton);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.appointmentsLabel);
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label appointmentsLabel;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Button servicesButton;
        private System.Windows.Forms.Button newAppointmentButton;
        private System.Windows.Forms.Button editAppointmentButton;
        private System.Windows.Forms.Button deleteAppointmentButton;
        private System.Windows.Forms.ListView appointmentsListView;
        private System.Windows.Forms.ColumnHeader customerNameHeader;
        private System.Windows.Forms.ColumnHeader phoneNumberHeader;
        private System.Windows.Forms.ColumnHeader dateHeader;
        private System.Windows.Forms.ColumnHeader servicesHeader;
        private System.Windows.Forms.ColumnHeader priceHeader;
        private System.Windows.Forms.ColumnHeader specialistHeader;
    }
}

