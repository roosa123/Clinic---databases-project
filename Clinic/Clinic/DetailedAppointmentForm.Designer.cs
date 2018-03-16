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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.examinationTabPage = new System.Windows.Forms.TabPage();
            this.examinationsDataGrid = new System.Windows.Forms.DataGridView();
            this.laboratoryTabPage = new System.Windows.Forms.TabPage();
            this.laboratoryDataGrid = new System.Windows.Forms.DataGridView();
            this.descriptionTabPage = new System.Windows.Forms.TabPage();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.diagnosisTabPage = new System.Windows.Forms.TabPage();
            this.diagnosisTextBox = new System.Windows.Forms.RichTextBox();
            this.returnButton2 = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.examinationDetailsButton = new System.Windows.Forms.Button();
            this.addExaminationButton = new System.Windows.Forms.Button();
            this.laboratoryDetailsButton = new System.Windows.Forms.Button();
            this.addLaboratoryButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.patientGroupBox.SuspendLayout();
            this.appointmentGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.examinationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examinationsDataGrid)).BeginInit();
            this.laboratoryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataGrid)).BeginInit();
            this.descriptionTabPage.SuspendLayout();
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
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
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
            this.patientGroupBox.Location = new System.Drawing.Point(12, 28);
            this.patientGroupBox.Name = "patientGroupBox";
            this.patientGroupBox.Size = new System.Drawing.Size(468, 88);
            this.patientGroupBox.TabIndex = 16;
            this.patientGroupBox.TabStop = false;
            this.patientGroupBox.Text = "Pacjent";
            // 
            // patientButton
            // 
            this.patientButton.Location = new System.Drawing.Point(362, 26);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(100, 32);
            this.patientButton.TabIndex = 23;
            this.patientButton.Text = "Karta pacjenta";
            this.patientButton.UseVisualStyleBackColor = true;
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdateLabel.Location = new System.Drawing.Point(256, 46);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(100, 16);
            this.birthdateLabel.TabIndex = 22;
            // 
            // peselLabel
            // 
            this.peselLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.peselLabel.Location = new System.Drawing.Point(256, 20);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(100, 16);
            this.peselLabel.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Data urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "PESEL";
            // 
            // surnameLabel
            // 
            this.surnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.surnameLabel.Location = new System.Drawing.Point(65, 45);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(100, 16);
            this.surnameLabel.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nazwisko";
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Location = new System.Drawing.Point(65, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 16);
            this.nameLabel.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Imię";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lekarz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
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
            this.appointmentGroupBox.Location = new System.Drawing.Point(491, 28);
            this.appointmentGroupBox.Name = "appointmentGroupBox";
            this.appointmentGroupBox.Size = new System.Drawing.Size(505, 88);
            this.appointmentGroupBox.TabIndex = 23;
            this.appointmentGroupBox.TabStop = false;
            this.appointmentGroupBox.Text = "Wizyta";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(303, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 16);
            this.label12.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(92, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Osoba rejestrująca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Data rejestracji";
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.Location = new System.Drawing.Point(399, 15);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 16);
            this.statusLabel.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Status";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.descriptionTabPage);
            this.tabControl.Controls.Add(this.diagnosisTabPage);
            this.tabControl.Controls.Add(this.examinationTabPage);
            this.tabControl.Controls.Add(this.laboratoryTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 133);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 540);
            this.tabControl.TabIndex = 24;
            // 
            // examinationTabPage
            // 
            this.examinationTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.examinationTabPage.Controls.Add(this.examinationDetailsButton);
            this.examinationTabPage.Controls.Add(this.addExaminationButton);
            this.examinationTabPage.Controls.Add(this.examinationsDataGrid);
            this.examinationTabPage.Location = new System.Drawing.Point(4, 22);
            this.examinationTabPage.Name = "examinationTabPage";
            this.examinationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.examinationTabPage.Size = new System.Drawing.Size(976, 514);
            this.examinationTabPage.TabIndex = 0;
            this.examinationTabPage.Text = "Badania fizykalne";
            // 
            // examinationsDataGrid
            // 
            this.examinationsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examinationsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.examinationsDataGrid.Name = "examinationsDataGrid";
            this.examinationsDataGrid.Size = new System.Drawing.Size(864, 511);
            this.examinationsDataGrid.TabIndex = 0;
            // 
            // laboratoryTabPage
            // 
            this.laboratoryTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.laboratoryTabPage.Controls.Add(this.laboratoryDetailsButton);
            this.laboratoryTabPage.Controls.Add(this.addLaboratoryButton);
            this.laboratoryTabPage.Controls.Add(this.laboratoryDataGrid);
            this.laboratoryTabPage.Location = new System.Drawing.Point(4, 22);
            this.laboratoryTabPage.Name = "laboratoryTabPage";
            this.laboratoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.laboratoryTabPage.Size = new System.Drawing.Size(976, 514);
            this.laboratoryTabPage.TabIndex = 1;
            this.laboratoryTabPage.Text = "Badania laboratoryjne";
            // 
            // laboratoryDataGrid
            // 
            this.laboratoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laboratoryDataGrid.Location = new System.Drawing.Point(0, 0);
            this.laboratoryDataGrid.Name = "laboratoryDataGrid";
            this.laboratoryDataGrid.Size = new System.Drawing.Size(864, 511);
            this.laboratoryDataGrid.TabIndex = 1;
            // 
            // descriptionTabPage
            // 
            this.descriptionTabPage.Controls.Add(this.descriptionTextBox);
            this.descriptionTabPage.Location = new System.Drawing.Point(4, 22);
            this.descriptionTabPage.Name = "descriptionTabPage";
            this.descriptionTabPage.Size = new System.Drawing.Size(976, 514);
            this.descriptionTabPage.TabIndex = 3;
            this.descriptionTabPage.Text = "Opis";
            this.descriptionTabPage.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 0);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(980, 511);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.Text = "";
            // 
            // diagnosisTabPage
            // 
            this.diagnosisTabPage.Controls.Add(this.diagnosisTextBox);
            this.diagnosisTabPage.Location = new System.Drawing.Point(4, 22);
            this.diagnosisTabPage.Name = "diagnosisTabPage";
            this.diagnosisTabPage.Size = new System.Drawing.Size(976, 514);
            this.diagnosisTabPage.TabIndex = 2;
            this.diagnosisTabPage.Text = "Diagnoza";
            this.diagnosisTabPage.UseVisualStyleBackColor = true;
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.Location = new System.Drawing.Point(0, 0);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(976, 511);
            this.diagnosisTextBox.TabIndex = 0;
            this.diagnosisTextBox.Text = "";
            // 
            // returnButton2
            // 
            this.returnButton2.Location = new System.Drawing.Point(890, 679);
            this.returnButton2.Name = "returnButton2";
            this.returnButton2.Size = new System.Drawing.Size(100, 32);
            this.returnButton2.TabIndex = 25;
            this.returnButton2.Text = "Powrót";
            this.returnButton2.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(678, 679);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 32);
            this.confirmButton.TabIndex = 26;
            this.confirmButton.Text = "Zakończ";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateLabel.Location = new System.Drawing.Point(92, 15);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(100, 16);
            this.dateLabel.TabIndex = 32;
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Location = new System.Drawing.Point(250, 15);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 16);
            this.timeLabel.TabIndex = 33;
            // 
            // doctorLabel
            // 
            this.doctorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doctorLabel.Location = new System.Drawing.Point(92, 38);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(407, 16);
            this.doctorLabel.TabIndex = 34;
            // 
            // examinationDetailsButton
            // 
            this.examinationDetailsButton.Location = new System.Drawing.Point(870, 44);
            this.examinationDetailsButton.Name = "examinationDetailsButton";
            this.examinationDetailsButton.Size = new System.Drawing.Size(100, 32);
            this.examinationDetailsButton.TabIndex = 30;
            this.examinationDetailsButton.Text = "Szczegóły";
            this.examinationDetailsButton.UseVisualStyleBackColor = true;
            // 
            // addExaminationButton
            // 
            this.addExaminationButton.Location = new System.Drawing.Point(870, 6);
            this.addExaminationButton.Name = "addExaminationButton";
            this.addExaminationButton.Size = new System.Drawing.Size(100, 32);
            this.addExaminationButton.TabIndex = 29;
            this.addExaminationButton.Text = "Dodaj";
            this.addExaminationButton.UseVisualStyleBackColor = true;
            // 
            // laboratoryDetailsButton
            // 
            this.laboratoryDetailsButton.Location = new System.Drawing.Point(870, 44);
            this.laboratoryDetailsButton.Name = "laboratoryDetailsButton";
            this.laboratoryDetailsButton.Size = new System.Drawing.Size(100, 32);
            this.laboratoryDetailsButton.TabIndex = 30;
            this.laboratoryDetailsButton.Text = "Szczegóły";
            this.laboratoryDetailsButton.UseVisualStyleBackColor = true;
            // 
            // addLaboratoryButton
            // 
            this.addLaboratoryButton.Location = new System.Drawing.Point(870, 6);
            this.addLaboratoryButton.Name = "addLaboratoryButton";
            this.addLaboratoryButton.Size = new System.Drawing.Size(100, 32);
            this.addLaboratoryButton.TabIndex = 29;
            this.addLaboratoryButton.Text = "Dodaj";
            this.addLaboratoryButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(784, 679);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 32);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // DetailedAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
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
            this.descriptionTabPage.ResumeLayout(false);
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