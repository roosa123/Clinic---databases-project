using DataLayer;

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
            this.patientGroupBox = new System.Windows.Forms.GroupBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.appointmentGroupBox = new System.Windows.Forms.GroupBox();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.descriptionTabPage = new System.Windows.Forms.TabPage();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.diagnosisTabPage = new System.Windows.Forms.TabPage();
            this.diagnosisTextBox = new System.Windows.Forms.RichTextBox();
            this.examinationTabPage = new System.Windows.Forms.TabPage();
            this.examinationDetailsButton = new System.Windows.Forms.Button();
            this.addExaminationButton = new System.Windows.Forms.Button();
            this.examinationsDataGrid = new System.Windows.Forms.DataGridView();
            this.laboratoryTabPage = new System.Windows.Forms.TabPage();
            this.laboratoryDetailsButton = new System.Windows.Forms.Button();
            this.addLaboratoryButton = new System.Windows.Forms.Button();
            this.laboratoryDataGrid = new System.Windows.Forms.DataGridView();
            this.returnButton2 = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.patientGroupBox.SuspendLayout();
            this.appointmentGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.descriptionTabPage.SuspendLayout();
            this.diagnosisTabPage.SuspendLayout();
            this.examinationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examinationsDataGrid)).BeginInit();
            this.laboratoryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // patientGroupBox
            // 
            this.patientGroupBox.Controls.Add(this.patientButton);
            this.patientGroupBox.Controls.Add(this.birthdateLabel);
            this.patientGroupBox.Controls.Add(this.peselLabel);
            this.patientGroupBox.Controls.Add(this.label5);
            this.patientGroupBox.Controls.Add(this.label4);
            this.patientGroupBox.Controls.Add(this.surnameLabel);
            this.patientGroupBox.Controls.Add(this.label3);
            this.patientGroupBox.Controls.Add(this.nameLabel);
            this.patientGroupBox.Controls.Add(this.label2);
            this.patientGroupBox.Location = new System.Drawing.Point(16, 34);
            this.patientGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientGroupBox.Name = "patientGroupBox";
            this.patientGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientGroupBox.Size = new System.Drawing.Size(624, 108);
            this.patientGroupBox.TabIndex = 16;
            this.patientGroupBox.TabStop = false;
            this.patientGroupBox.Text = "Pacjent";
            // 
            // patientButton
            // 
            this.patientButton.Location = new System.Drawing.Point(483, 32);
            this.patientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(133, 39);
            this.patientButton.TabIndex = 23;
            this.patientButton.Text = "Karta pacjenta";
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdateLabel.Location = new System.Drawing.Point(341, 57);
            this.birthdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(133, 20);
            this.birthdateLabel.TabIndex = 22;
            // 
            // peselLabel
            // 
            this.peselLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.peselLabel.Location = new System.Drawing.Point(341, 25);
            this.peselLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(133, 20);
            this.peselLabel.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Data urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "PESEL";
            // 
            // surnameLabel
            // 
            this.surnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.surnameLabel.Location = new System.Drawing.Point(87, 55);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(133, 20);
            this.surnameLabel.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nazwisko";
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Location = new System.Drawing.Point(87, 25);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(133, 20);
            this.nameLabel.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Imię";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lekarz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Godzina";
            // 
            // appointmentGroupBox
            // 
            this.appointmentGroupBox.Controls.Add(this.doctorLabel);
            this.appointmentGroupBox.Controls.Add(this.timeLabel);
            this.appointmentGroupBox.Controls.Add(this.dateLabel);
            this.appointmentGroupBox.Controls.Add(this.label12);
            this.appointmentGroupBox.Controls.Add(this.label11);
            this.appointmentGroupBox.Controls.Add(this.label10);
            this.appointmentGroupBox.Controls.Add(this.label9);
            this.appointmentGroupBox.Controls.Add(this.statusLabel);
            this.appointmentGroupBox.Controls.Add(this.label8);
            this.appointmentGroupBox.Controls.Add(this.label6);
            this.appointmentGroupBox.Controls.Add(this.label7);
            this.appointmentGroupBox.Controls.Add(this.label1);
            this.appointmentGroupBox.Location = new System.Drawing.Point(655, 34);
            this.appointmentGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentGroupBox.Name = "appointmentGroupBox";
            this.appointmentGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentGroupBox.Size = new System.Drawing.Size(673, 108);
            this.appointmentGroupBox.TabIndex = 23;
            this.appointmentGroupBox.TabStop = false;
            this.appointmentGroupBox.Text = "Wizyta";
            // 
            // doctorLabel
            // 
            this.doctorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doctorLabel.Location = new System.Drawing.Point(123, 47);
            this.doctorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(543, 20);
            this.doctorLabel.TabIndex = 34;
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Location = new System.Drawing.Point(333, 18);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(133, 20);
            this.timeLabel.TabIndex = 33;
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateLabel.Location = new System.Drawing.Point(123, 18);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(133, 20);
            this.dateLabel.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(404, 74);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 20);
            this.label12.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(123, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 20);
            this.label11.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Osoba rejestrująca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Data rejestracji";
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.Location = new System.Drawing.Point(532, 18);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(133, 20);
            this.statusLabel.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Status";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.descriptionTabPage);
            this.tabControl.Controls.Add(this.diagnosisTabPage);
            this.tabControl.Controls.Add(this.examinationTabPage);
            this.tabControl.Controls.Add(this.laboratoryTabPage);
            this.tabControl.Location = new System.Drawing.Point(16, 164);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1312, 665);
            this.tabControl.TabIndex = 24;
            // 
            // descriptionTabPage
            // 
            this.descriptionTabPage.Controls.Add(this.descriptionTextBox);
            this.descriptionTabPage.Location = new System.Drawing.Point(4, 25);
            this.descriptionTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTabPage.Name = "descriptionTabPage";
            this.descriptionTabPage.Size = new System.Drawing.Size(1304, 636);
            this.descriptionTabPage.TabIndex = 3;
            this.descriptionTabPage.Text = "Opis";
            this.descriptionTabPage.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 0);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(1305, 628);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.Text = "";
            // 
            // diagnosisTabPage
            // 
            this.diagnosisTabPage.Controls.Add(this.diagnosisTextBox);
            this.diagnosisTabPage.Location = new System.Drawing.Point(4, 25);
            this.diagnosisTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diagnosisTabPage.Name = "diagnosisTabPage";
            this.diagnosisTabPage.Size = new System.Drawing.Size(1304, 636);
            this.diagnosisTabPage.TabIndex = 2;
            this.diagnosisTabPage.Text = "Diagnoza";
            this.diagnosisTabPage.UseVisualStyleBackColor = true;
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.Location = new System.Drawing.Point(0, 0);
            this.diagnosisTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(1300, 628);
            this.diagnosisTextBox.TabIndex = 0;
            this.diagnosisTextBox.Text = "";
            // 
            // examinationTabPage
            // 
            this.examinationTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.examinationTabPage.Controls.Add(this.examinationDetailsButton);
            this.examinationTabPage.Controls.Add(this.addExaminationButton);
            this.examinationTabPage.Controls.Add(this.examinationsDataGrid);
            this.examinationTabPage.Location = new System.Drawing.Point(4, 25);
            this.examinationTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.examinationTabPage.Name = "examinationTabPage";
            this.examinationTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.examinationTabPage.Size = new System.Drawing.Size(1304, 636);
            this.examinationTabPage.TabIndex = 0;
            this.examinationTabPage.Text = "Badania fizykalne";
            // 
            // examinationDetailsButton
            // 
            this.examinationDetailsButton.Location = new System.Drawing.Point(1160, 54);
            this.examinationDetailsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.examinationDetailsButton.Name = "examinationDetailsButton";
            this.examinationDetailsButton.Size = new System.Drawing.Size(133, 39);
            this.examinationDetailsButton.TabIndex = 30;
            this.examinationDetailsButton.Text = "Szczegóły";
            this.examinationDetailsButton.UseVisualStyleBackColor = true;
            this.examinationDetailsButton.Click += new System.EventHandler(this.examinationDetailsButton_Click);
            // 
            // addExaminationButton
            // 
            this.addExaminationButton.Location = new System.Drawing.Point(1160, 7);
            this.addExaminationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addExaminationButton.Name = "addExaminationButton";
            this.addExaminationButton.Size = new System.Drawing.Size(133, 39);
            this.addExaminationButton.TabIndex = 29;
            this.addExaminationButton.Text = "Dodaj";
            this.addExaminationButton.UseVisualStyleBackColor = true;
            this.addExaminationButton.Click += new System.EventHandler(this.addExaminationButton_Click);
            // 
            // examinationsDataGrid
            // 
            this.examinationsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examinationsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.examinationsDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.examinationsDataGrid.Name = "examinationsDataGrid";
            this.examinationsDataGrid.Size = new System.Drawing.Size(1152, 629);
            this.examinationsDataGrid.TabIndex = 0;
            // 
            // laboratoryTabPage
            // 
            this.laboratoryTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.laboratoryTabPage.Controls.Add(this.laboratoryDetailsButton);
            this.laboratoryTabPage.Controls.Add(this.addLaboratoryButton);
            this.laboratoryTabPage.Controls.Add(this.laboratoryDataGrid);
            this.laboratoryTabPage.Location = new System.Drawing.Point(4, 25);
            this.laboratoryTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laboratoryTabPage.Name = "laboratoryTabPage";
            this.laboratoryTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laboratoryTabPage.Size = new System.Drawing.Size(1304, 636);
            this.laboratoryTabPage.TabIndex = 1;
            this.laboratoryTabPage.Text = "Badania laboratoryjne";
            // 
            // laboratoryDetailsButton
            // 
            this.laboratoryDetailsButton.Location = new System.Drawing.Point(1160, 54);
            this.laboratoryDetailsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laboratoryDetailsButton.Name = "laboratoryDetailsButton";
            this.laboratoryDetailsButton.Size = new System.Drawing.Size(133, 39);
            this.laboratoryDetailsButton.TabIndex = 30;
            this.laboratoryDetailsButton.Text = "Szczegóły";
            this.laboratoryDetailsButton.UseVisualStyleBackColor = true;
            this.laboratoryDetailsButton.Click += new System.EventHandler(this.laboratoryDetailsButton_Click);
            // 
            // addLaboratoryButton
            // 
            this.addLaboratoryButton.Location = new System.Drawing.Point(1160, 7);
            this.addLaboratoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addLaboratoryButton.Name = "addLaboratoryButton";
            this.addLaboratoryButton.Size = new System.Drawing.Size(133, 39);
            this.addLaboratoryButton.TabIndex = 29;
            this.addLaboratoryButton.Text = "Dodaj";
            this.addLaboratoryButton.UseVisualStyleBackColor = true;
            this.addLaboratoryButton.Click += new System.EventHandler(this.addLaboratoryButton_Click);
            // 
            // laboratoryDataGrid
            // 
            this.laboratoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laboratoryDataGrid.Location = new System.Drawing.Point(0, 0);
            this.laboratoryDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laboratoryDataGrid.Name = "laboratoryDataGrid";
            this.laboratoryDataGrid.Size = new System.Drawing.Size(1152, 629);
            this.laboratoryDataGrid.TabIndex = 1;
            // 
            // returnButton2
            // 
            this.returnButton2.Location = new System.Drawing.Point(1187, 836);
            this.returnButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnButton2.Name = "returnButton2";
            this.returnButton2.Size = new System.Drawing.Size(133, 39);
            this.returnButton2.TabIndex = 25;
            this.returnButton2.Text = "Powrót";
            this.returnButton2.UseVisualStyleBackColor = true;
            this.returnButton2.Click += new System.EventHandler(this.returnButton2_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(904, 836);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(133, 39);
            this.confirmButton.TabIndex = 26;
            this.confirmButton.Text = "Zakończ";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1045, 836);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 39);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DetailedAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.returnButton2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.appointmentGroupBox);
            this.Controls.Add(this.patientGroupBox);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "DetailedAppointmentForm";
            this.Text = "Wizyta";
            this.Controls.SetChildIndex(this.patientGroupBox, 0);
            this.Controls.SetChildIndex(this.appointmentGroupBox, 0);
            this.Controls.SetChildIndex(this.tabControl, 0);
            this.Controls.SetChildIndex(this.returnButton2, 0);
            this.Controls.SetChildIndex(this.confirmButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.patientGroupBox.ResumeLayout(false);
            this.patientGroupBox.PerformLayout();
            this.appointmentGroupBox.ResumeLayout(false);
            this.appointmentGroupBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.descriptionTabPage.ResumeLayout(false);
            this.diagnosisTabPage.ResumeLayout(false);
            this.examinationTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examinationsDataGrid)).EndInit();
            this.laboratoryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox patientGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label peselLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox appointmentGroupBox;                //locked for doctor
        private System.Windows.Forms.TabControl tabControl;                 //inaccesible for registrar
        private System.Windows.Forms.TabPage examinationTabPage;
        private System.Windows.Forms.TabPage laboratoryTabPage;
        private System.Windows.Forms.TabPage diagnosisTabPage;
        private System.Windows.Forms.Button returnButton2;                  //inaccesible for registrar
        private System.Windows.Forms.Button confirmButton;                  //inaccesible for registrar
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView examinationsDataGrid;
        private System.Windows.Forms.DataGridView laboratoryDataGrid;
        private System.Windows.Forms.RichTextBox diagnosisTextBox;
        private System.Windows.Forms.TabPage descriptionTabPage;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button examinationDetailsButton;
        private System.Windows.Forms.Button addExaminationButton;
        private System.Windows.Forms.Button laboratoryDetailsButton;
        private System.Windows.Forms.Button addLaboratoryButton;
        private System.Windows.Forms.Button cancelButton;
       
    }
}