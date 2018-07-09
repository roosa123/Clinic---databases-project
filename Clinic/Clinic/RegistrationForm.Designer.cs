namespace Przychodnia
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.peselTextBox = new System.Windows.Forms.MaskedTextBox();
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patientsDataGrid = new System.Windows.Forms.DataGridView();
            this.appointmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.searchAppointmentButton = new System.Windows.Forms.Button();
            this.doctorComboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.patientGroupBox = new System.Windows.Forms.GroupBox();
            this.registerGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.appointmentTimePicker = new System.Windows.Forms.DateTimePicker();
            this.detailsButton = new System.Windows.Forms.Button();
            this.appointmentsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGrid)).BeginInit();
            this.patientGroupBox.SuspendLayout();
            this.registerGroupBox.SuspendLayout();
            this.appointmentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Imię";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(47, 32);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(183, 22);
            this.nameTextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "PESEL";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(356, 32);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(183, 22);
            this.surnameTextBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nazwisko";
            // 
            // peselTextBox
            // 
            this.peselTextBox.Location = new System.Drawing.Point(660, 32);
            this.peselTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.peselTextBox.Mask = "00000000000";
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(108, 22);
            this.peselTextBox.TabIndex = 31;
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.Location = new System.Drawing.Point(815, 23);
            this.searchPatientButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(133, 39);
            this.searchPatientButton.TabIndex = 32;
            this.searchPatientButton.Text = "Szukaj";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            this.searchPatientButton.Click += new System.EventHandler(this.searchPatientButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(340, 91);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(133, 39);
            this.registerButton.TabIndex = 24;
            this.registerButton.Text = "Zarejestruj";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Location = new System.Drawing.Point(68, 26);
            this.appointmentDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(183, 22);
            this.appointmentDatePicker.TabIndex = 20;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(68, 58);
            this.doctorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(404, 24);
            this.doctorComboBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lekarz";
            // 
            // patientsDataGrid
            // 
            this.patientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGrid.Location = new System.Drawing.Point(8, 78);
            this.patientsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.patientsDataGrid.Name = "patientsDataGrid";
            this.patientsDataGrid.Size = new System.Drawing.Size(799, 282);
            this.patientsDataGrid.TabIndex = 34;
            // 
            // appointmentsDataGrid
            // 
            this.appointmentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGrid.Location = new System.Drawing.Point(12, 63);
            this.appointmentsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentsDataGrid.Name = "appointmentsDataGrid";
            this.appointmentsDataGrid.Size = new System.Drawing.Size(1147, 404);
            this.appointmentsDataGrid.TabIndex = 36;
            // 
            // newPatientButton
            // 
            this.newPatientButton.Location = new System.Drawing.Point(815, 78);
            this.newPatientButton.Margin = new System.Windows.Forms.Padding(4);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(133, 39);
            this.newPatientButton.TabIndex = 37;
            this.newPatientButton.Text = "Dodaj pacjenta";
            this.newPatientButton.UseVisualStyleBackColor = true;
            this.newPatientButton.Click += new System.EventHandler(this.newPatientButton_Click);
            // 
            // patientButton
            // 
            this.patientButton.Location = new System.Drawing.Point(815, 124);
            this.patientButton.Margin = new System.Windows.Forms.Padding(4);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(133, 39);
            this.patientButton.TabIndex = 38;
            this.patientButton.Text = "Edytuj dane";
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1167, 63);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 39);
            this.cancelButton.TabIndex = 40;
            this.cancelButton.Text = "Anuluj wizytę";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // searchAppointmentButton
            // 
            this.searchAppointmentButton.Location = new System.Drawing.Point(1025, 16);
            this.searchAppointmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchAppointmentButton.Name = "searchAppointmentButton";
            this.searchAppointmentButton.Size = new System.Drawing.Size(133, 39);
            this.searchAppointmentButton.TabIndex = 47;
            this.searchAppointmentButton.Text = "Szukaj";
            this.searchAppointmentButton.UseVisualStyleBackColor = true;
            this.searchAppointmentButton.Click += new System.EventHandler(this.searchAppointmentButton_Click);
            // 
            // doctorComboBox1
            // 
            this.doctorComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox1.FormattingEnabled = true;
            this.doctorComboBox1.Location = new System.Drawing.Point(605, 25);
            this.doctorComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.doctorComboBox1.Name = "doctorComboBox1";
            this.doctorComboBox1.Size = new System.Drawing.Size(404, 24);
            this.doctorComboBox1.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Lekarz";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(56, 25);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.ShowCheckBox = true;
            this.fromDateTimePicker.Size = new System.Drawing.Size(208, 22);
            this.fromDateTimePicker.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "-",
            "Zarejestrowana",
            "Rozpoczęta",
            "Wykonana",
            "Anulowana"});
            this.statusComboBox.Location = new System.Drawing.Point(373, 25);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(133, 24);
            this.statusComboBox.TabIndex = 41;
            // 
            // patientGroupBox
            // 
            this.patientGroupBox.Controls.Add(this.registerGroupBox);
            this.patientGroupBox.Controls.Add(this.detailsButton);
            this.patientGroupBox.Controls.Add(this.searchPatientButton);
            this.patientGroupBox.Controls.Add(this.peselTextBox);
            this.patientGroupBox.Controls.Add(this.label2);
            this.patientGroupBox.Controls.Add(this.surnameTextBox);
            this.patientGroupBox.Controls.Add(this.label4);
            this.patientGroupBox.Controls.Add(this.nameTextBox);
            this.patientGroupBox.Controls.Add(this.label1);
            this.patientGroupBox.Controls.Add(this.patientsDataGrid);
            this.patientGroupBox.Controls.Add(this.newPatientButton);
            this.patientGroupBox.Controls.Add(this.patientButton);
            this.patientGroupBox.Location = new System.Drawing.Point(20, 34);
            this.patientGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.patientGroupBox.Name = "patientGroupBox";
            this.patientGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.patientGroupBox.Size = new System.Drawing.Size(1308, 367);
            this.patientGroupBox.TabIndex = 48;
            this.patientGroupBox.TabStop = false;
            this.patientGroupBox.Text = "Pacjenci";
            // 
            // registerGroupBox
            // 
            this.registerGroupBox.Controls.Add(this.doctorComboBox);
            this.registerGroupBox.Controls.Add(this.label7);
            this.registerGroupBox.Controls.Add(this.label6);
            this.registerGroupBox.Controls.Add(this.appointmentDatePicker);
            this.registerGroupBox.Controls.Add(this.registerButton);
            this.registerGroupBox.Controls.Add(this.label3);
            this.registerGroupBox.Controls.Add(this.appointmentTimePicker);
            this.registerGroupBox.Location = new System.Drawing.Point(815, 217);
            this.registerGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.registerGroupBox.Name = "registerGroupBox";
            this.registerGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.registerGroupBox.Size = new System.Drawing.Size(484, 143);
            this.registerGroupBox.TabIndex = 49;
            this.registerGroupBox.TabStop = false;
            this.registerGroupBox.Text = "Nowa wizyta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Godzina";
            // 
            // appointmentTimePicker
            // 
            this.appointmentTimePicker.CustomFormat = "HH:mm";
            this.appointmentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentTimePicker.Location = new System.Drawing.Point(344, 26);
            this.appointmentTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentTimePicker.Name = "appointmentTimePicker";
            this.appointmentTimePicker.ShowUpDown = true;
            this.appointmentTimePicker.Size = new System.Drawing.Size(128, 22);
            this.appointmentTimePicker.TabIndex = 22;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(815, 170);
            this.detailsButton.Margin = new System.Windows.Forms.Padding(4);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(133, 39);
            this.detailsButton.TabIndex = 39;
            this.detailsButton.Text = "Przeglądaj dane";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // appointmentsGroupBox
            // 
            this.appointmentsGroupBox.Controls.Add(this.cancelButton);
            this.appointmentsGroupBox.Controls.Add(this.searchAppointmentButton);
            this.appointmentsGroupBox.Controls.Add(this.appointmentsDataGrid);
            this.appointmentsGroupBox.Controls.Add(this.doctorComboBox1);
            this.appointmentsGroupBox.Controls.Add(this.label5);
            this.appointmentsGroupBox.Controls.Add(this.fromDateTimePicker);
            this.appointmentsGroupBox.Controls.Add(this.label8);
            this.appointmentsGroupBox.Controls.Add(this.label9);
            this.appointmentsGroupBox.Controls.Add(this.statusComboBox);
            this.appointmentsGroupBox.Location = new System.Drawing.Point(20, 409);
            this.appointmentsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentsGroupBox.Name = "appointmentsGroupBox";
            this.appointmentsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.appointmentsGroupBox.Size = new System.Drawing.Size(1308, 474);
            this.appointmentsGroupBox.TabIndex = 49;
            this.appointmentsGroupBox.TabStop = false;
            this.appointmentsGroupBox.Text = "Wizyty";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.appointmentsGroupBox);
            this.Controls.Add(this.patientGroupBox);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegistrationForm";
            this.Text = "Rejestracja";
            this.Controls.SetChildIndex(this.patientGroupBox, 0);
            this.Controls.SetChildIndex(this.appointmentsGroupBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGrid)).EndInit();
            this.patientGroupBox.ResumeLayout(false);
            this.patientGroupBox.PerformLayout();
            this.registerGroupBox.ResumeLayout(false);
            this.registerGroupBox.PerformLayout();
            this.appointmentsGroupBox.ResumeLayout(false);
            this.appointmentsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox peselTextBox;
        private System.Windows.Forms.Button searchPatientButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView patientsDataGrid;
        private System.Windows.Forms.DataGridView appointmentsDataGrid;
        private System.Windows.Forms.Button newPatientButton;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button searchAppointmentButton;
        private System.Windows.Forms.ComboBox doctorComboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.GroupBox patientGroupBox;
        private System.Windows.Forms.GroupBox appointmentsGroupBox;
        private System.Windows.Forms.DateTimePicker appointmentTimePicker;
        private System.Windows.Forms.GroupBox registerGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button detailsButton;
    }
}