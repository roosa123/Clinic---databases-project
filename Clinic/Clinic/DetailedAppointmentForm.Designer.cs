namespace Przychodnia
{
    partial class DetailedAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedAppointmentForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.userButton = new System.Windows.Forms.ToolStripSplitButton();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientSearchBox = new System.Windows.Forms.ComboBox();
            this.patientGroupBox = new System.Windows.Forms.GroupBox();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.peselLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.appointmentTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentGroupBox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.returnButton1 = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.examinationTabPage = new System.Windows.Forms.TabPage();
            this.examinationsDataGrid = new System.Windows.Forms.DataGridView();
            this.laboratoryTabPage = new System.Windows.Forms.TabPage();
            this.laboratoryDataGrid = new System.Windows.Forms.DataGridView();
            this.diagnosisTabPage = new System.Windows.Forms.TabPage();
            this.diagnosisTextBox = new System.Windows.Forms.RichTextBox();
            this.returnButton2 = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.patientGroupBox.SuspendLayout();
            this.appointmentGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.examinationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examinationsDataGrid)).BeginInit();
            this.laboratoryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataGrid)).BeginInit();
            this.diagnosisTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip.TabIndex = 13;
            this.toolStrip.Text = "toolStrip1";
            // 
            // userButton
            // 
            this.userButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.userButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.toolStripSeparator1,
            this.wylogujToolStripMenuItem});
            this.userButton.Image = ((System.Drawing.Image)(resources.GetObject("userButton.Image")));
            this.userButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(107, 22);
            this.userButton.Text = "<<username>>";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            // 
            // patientSearchBox
            // 
            this.patientSearchBox.FormattingEnabled = true;
            this.patientSearchBox.Location = new System.Drawing.Point(9, 13);
            this.patientSearchBox.Name = "patientSearchBox";
            this.patientSearchBox.Size = new System.Drawing.Size(347, 21);
            this.patientSearchBox.TabIndex = 15;
            // 
            // patientGroupBox
            // 
            this.patientGroupBox.Controls.Add(this.newPatientButton);
            this.patientGroupBox.Controls.Add(this.patientButton);
            this.patientGroupBox.Controls.Add(this.birthdateLabel);
            this.patientGroupBox.Controls.Add(this.peselLabel);
            this.patientGroupBox.Controls.Add(this.label5);
            this.patientGroupBox.Controls.Add(this.label4);
            this.patientGroupBox.Controls.Add(this.surnameLabel);
            this.patientGroupBox.Controls.Add(this.label3);
            this.patientGroupBox.Controls.Add(this.nameLabel);
            this.patientGroupBox.Controls.Add(this.label2);
            this.patientGroupBox.Controls.Add(this.patientSearchBox);
            this.patientGroupBox.Location = new System.Drawing.Point(12, 28);
            this.patientGroupBox.Name = "patientGroupBox";
            this.patientGroupBox.Size = new System.Drawing.Size(468, 92);
            this.patientGroupBox.TabIndex = 16;
            this.patientGroupBox.TabStop = false;
            this.patientGroupBox.Text = "Pacjent";
            // 
            // newPatientButton
            // 
            this.newPatientButton.Location = new System.Drawing.Point(362, 13);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(100, 32);
            this.newPatientButton.TabIndex = 24;
            this.newPatientButton.Text = "Dodaj pacjenta";
            this.newPatientButton.UseVisualStyleBackColor = true;
            // 
            // patientButton
            // 
            this.patientButton.Location = new System.Drawing.Point(362, 51);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(100, 32);
            this.patientButton.TabIndex = 23;
            this.patientButton.Text = "Karta pacjenta";
            this.patientButton.UseVisualStyleBackColor = true;
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdateLabel.Location = new System.Drawing.Point(256, 63);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(100, 16);
            this.birthdateLabel.TabIndex = 22;
            // 
            // peselLabel
            // 
            this.peselLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.peselLabel.Location = new System.Drawing.Point(256, 37);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(100, 16);
            this.peselLabel.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Data urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "PESEL";
            // 
            // surnameLabel
            // 
            this.surnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.surnameLabel.Location = new System.Drawing.Point(65, 62);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(100, 16);
            this.surnameLabel.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nazwisko";
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Location = new System.Drawing.Point(65, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 16);
            this.nameLabel.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Imię";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lekarz";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(51, 45);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(342, 21);
            this.doctorComboBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data";
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Location = new System.Drawing.Point(51, 19);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(138, 20);
            this.appointmentDatePicker.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Godzina";
            // 
            // appointmentTimePicker
            // 
            this.appointmentTimePicker.CustomFormat = "HH:mm";
            this.appointmentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentTimePicker.Location = new System.Drawing.Point(296, 19);
            this.appointmentTimePicker.Name = "appointmentTimePicker";
            this.appointmentTimePicker.ShowUpDown = true;
            this.appointmentTimePicker.Size = new System.Drawing.Size(97, 20);
            this.appointmentTimePicker.TabIndex = 22;
            // 
            // appointmentGroupBox
            // 
            this.appointmentGroupBox.Controls.Add(this.statusLabel);
            this.appointmentGroupBox.Controls.Add(this.label8);
            this.appointmentGroupBox.Controls.Add(this.returnButton1);
            this.appointmentGroupBox.Controls.Add(this.label6);
            this.appointmentGroupBox.Controls.Add(this.registerButton);
            this.appointmentGroupBox.Controls.Add(this.appointmentTimePicker);
            this.appointmentGroupBox.Controls.Add(this.appointmentDatePicker);
            this.appointmentGroupBox.Controls.Add(this.doctorComboBox);
            this.appointmentGroupBox.Controls.Add(this.label7);
            this.appointmentGroupBox.Controls.Add(this.label1);
            this.appointmentGroupBox.Location = new System.Drawing.Point(491, 28);
            this.appointmentGroupBox.Name = "appointmentGroupBox";
            this.appointmentGroupBox.Size = new System.Drawing.Size(505, 92);
            this.appointmentGroupBox.TabIndex = 23;
            this.appointmentGroupBox.TabStop = false;
            this.appointmentGroupBox.Text = "Wizyta";
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.Location = new System.Drawing.Point(80, 69);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 16);
            this.statusLabel.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Status wizyty";
            // 
            // returnButton1
            // 
            this.returnButton1.Location = new System.Drawing.Point(399, 51);
            this.returnButton1.Name = "returnButton1";
            this.returnButton1.Size = new System.Drawing.Size(100, 32);
            this.returnButton1.TabIndex = 25;
            this.returnButton1.Text = "Powrót";
            this.returnButton1.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(399, 15);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 32);
            this.registerButton.TabIndex = 24;
            this.registerButton.Text = "Zarejestruj";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.examinationTabPage);
            this.tabControl.Controls.Add(this.laboratoryTabPage);
            this.tabControl.Controls.Add(this.diagnosisTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 126);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(872, 591);
            this.tabControl.TabIndex = 24;
            // 
            // examinationTabPage
            // 
            this.examinationTabPage.Controls.Add(this.examinationsDataGrid);
            this.examinationTabPage.Location = new System.Drawing.Point(4, 22);
            this.examinationTabPage.Name = "examinationTabPage";
            this.examinationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.examinationTabPage.Size = new System.Drawing.Size(864, 565);
            this.examinationTabPage.TabIndex = 0;
            this.examinationTabPage.Text = "Badania";
            this.examinationTabPage.UseVisualStyleBackColor = true;
            // 
            // examinationsDataGrid
            // 
            this.examinationsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examinationsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.examinationsDataGrid.Name = "examinationsDataGrid";
            this.examinationsDataGrid.Size = new System.Drawing.Size(864, 565);
            this.examinationsDataGrid.TabIndex = 0;
            // 
            // laboratoryTabPage
            // 
            this.laboratoryTabPage.Controls.Add(this.laboratoryDataGrid);
            this.laboratoryTabPage.Location = new System.Drawing.Point(4, 22);
            this.laboratoryTabPage.Name = "laboratoryTabPage";
            this.laboratoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.laboratoryTabPage.Size = new System.Drawing.Size(864, 565);
            this.laboratoryTabPage.TabIndex = 1;
            this.laboratoryTabPage.Text = "Zlecenia";
            this.laboratoryTabPage.UseVisualStyleBackColor = true;
            // 
            // laboratoryDataGrid
            // 
            this.laboratoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laboratoryDataGrid.Location = new System.Drawing.Point(0, 0);
            this.laboratoryDataGrid.Name = "laboratoryDataGrid";
            this.laboratoryDataGrid.Size = new System.Drawing.Size(864, 565);
            this.laboratoryDataGrid.TabIndex = 1;
            // 
            // diagnosisTabPage
            // 
            this.diagnosisTabPage.Controls.Add(this.diagnosisTextBox);
            this.diagnosisTabPage.Location = new System.Drawing.Point(4, 22);
            this.diagnosisTabPage.Name = "diagnosisTabPage";
            this.diagnosisTabPage.Size = new System.Drawing.Size(864, 565);
            this.diagnosisTabPage.TabIndex = 2;
            this.diagnosisTabPage.Text = "Diagnoza";
            this.diagnosisTabPage.UseVisualStyleBackColor = true;
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.Location = new System.Drawing.Point(0, 0);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(864, 565);
            this.diagnosisTextBox.TabIndex = 0;
            this.diagnosisTextBox.Text = "";
            // 
            // returnButton2
            // 
            this.returnButton2.Location = new System.Drawing.Point(890, 681);
            this.returnButton2.Name = "returnButton2";
            this.returnButton2.Size = new System.Drawing.Size(100, 32);
            this.returnButton2.TabIndex = 25;
            this.returnButton2.Text = "Powrót";
            this.returnButton2.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(890, 643);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 32);
            this.confirmButton.TabIndex = 26;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(890, 148);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 32);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(890, 186);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(100, 32);
            this.detailsButton.TabIndex = 28;
            this.detailsButton.Text = "Szczegóły";
            this.detailsButton.UseVisualStyleBackColor = true;
            // 
            // DetailedAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.returnButton2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.appointmentGroupBox);
            this.Controls.Add(this.patientGroupBox);
            this.Controls.Add(this.toolStrip);
            this.Name = "DetailedAppointmentForm";
            this.Text = "Wizyta";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.patientGroupBox.ResumeLayout(false);
            this.patientGroupBox.PerformLayout();
            this.appointmentGroupBox.ResumeLayout(false);
            this.appointmentGroupBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.examinationTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examinationsDataGrid)).EndInit();
            this.laboratoryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataGrid)).EndInit();
            this.diagnosisTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSplitButton userButton;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ComboBox patientSearchBox;             //inaccesible for doctor and for reviewing appointment
        private System.Windows.Forms.GroupBox patientGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Button newPatientButton;               //inaccesible for doctor and for reviewing appointment
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label peselLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox doctorComboBox;               //locked for reviewing appointment
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;        //locked for reviewing appointment
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker appointmentTimePicker;        //locked for reviewing appointment
        private System.Windows.Forms.GroupBox appointmentGroupBox;                //locked for doctor
        private System.Windows.Forms.Button returnButton1;                  //inaccesible for doctor
        private System.Windows.Forms.Button registerButton;                 //inaccesible for doctor and for reviewing appointment
        private System.Windows.Forms.TabControl tabControl;                 //inaccesible for registrar
        private System.Windows.Forms.TabPage examinationTabPage;
        private System.Windows.Forms.TabPage laboratoryTabPage;
        private System.Windows.Forms.TabPage diagnosisTabPage;
        private System.Windows.Forms.Button returnButton2;                  //inaccesible for registrar
        private System.Windows.Forms.Button confirmButton;                  //inaccesible for registrar
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addButton;                      //inaccesible for registrar and diagnosis tab
        private System.Windows.Forms.Button detailsButton;                  //inaccesible for registrar and diagnosis tab
        private System.Windows.Forms.DataGridView examinationsDataGrid;
        private System.Windows.Forms.DataGridView laboratoryDataGrid;
        private System.Windows.Forms.RichTextBox diagnosisTextBox;
    }
}