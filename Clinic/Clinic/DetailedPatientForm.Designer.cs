namespace Przychodnia
{
    partial class DetailedPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedPatientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.peselTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.insuranceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.houseTextBox = new System.Windows.Forms.MaskedTextBox();
            this.postcodeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.userButton = new System.Windows.Forms.ToolStripSplitButton();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalGroupBox = new System.Windows.Forms.GroupBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.returnButton1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.apartmentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.appointmentsTabPage = new System.Windows.Forms.TabPage();
            this.appointmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.examinationsTabPage = new System.Windows.Forms.TabPage();
            this.examinationsDataGrid = new System.Windows.Forms.DataGridView();
            this.laboratoryTabPage = new System.Windows.Forms.TabPage();
            this.laboratoryDataGrid = new System.Windows.Forms.DataGridView();
            this.detailsButton = new System.Windows.Forms.Button();
            this.returnButton2 = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.personalGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.appointmentsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGrid)).BeginInit();
            this.examinationsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examinationsDataGrid)).BeginInit();
            this.laboratoryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(91, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(138, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(91, 45);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(138, 20);
            this.surnameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data urodzenia";
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Location = new System.Drawing.Point(91, 71);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(138, 20);
            this.birthdatePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PESEL";
            // 
            // peselTextBox
            // 
            this.peselTextBox.Location = new System.Drawing.Point(344, 45);
            this.peselTextBox.Mask = "00000000000";
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(82, 20);
            this.peselTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nr ubezpieczenia";
            // 
            // insuranceTextBox
            // 
            this.insuranceTextBox.Location = new System.Drawing.Point(344, 71);
            this.insuranceTextBox.Mask = "000000000000";
            this.insuranceTextBox.Name = "insuranceTextBox";
            this.insuranceTextBox.Size = new System.Drawing.Size(82, 20);
            this.insuranceTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nr telefonu";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(710, 71);
            this.phoneTextBox.Mask = "000-000-000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(111, 20);
            this.phoneTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Płeć";
            // 
            // sexComboBox
            // 
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "M",
            "K"});
            this.sexComboBox.Location = new System.Drawing.Point(344, 18);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(32, 21);
            this.sexComboBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Miasto";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(534, 45);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(66, 20);
            this.cityTextBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(673, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ulica";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(710, 19);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(111, 20);
            this.streetTextBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(657, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nr domu";
            // 
            // houseTextBox
            // 
            this.houseTextBox.Location = new System.Drawing.Point(710, 45);
            this.houseTextBox.Mask = "000";
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(25, 20);
            this.houseTextBox.TabIndex = 19;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.Location = new System.Drawing.Point(534, 71);
            this.postcodeTextBox.Mask = "00-000";
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(66, 20);
            this.postcodeTextBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(454, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Kod pocztowy";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip.TabIndex = 24;
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
            // personalGroupBox
            // 
            this.personalGroupBox.Controls.Add(this.countryTextBox);
            this.personalGroupBox.Controls.Add(this.label16);
            this.personalGroupBox.Controls.Add(this.returnButton1);
            this.personalGroupBox.Controls.Add(this.saveButton);
            this.personalGroupBox.Controls.Add(this.label1);
            this.personalGroupBox.Controls.Add(this.nameTextBox);
            this.personalGroupBox.Controls.Add(this.label11);
            this.personalGroupBox.Controls.Add(this.apartmentTextBox);
            this.personalGroupBox.Controls.Add(this.label10);
            this.personalGroupBox.Controls.Add(this.postcodeTextBox);
            this.personalGroupBox.Controls.Add(this.label9);
            this.personalGroupBox.Controls.Add(this.label6);
            this.personalGroupBox.Controls.Add(this.phoneTextBox);
            this.personalGroupBox.Controls.Add(this.houseTextBox);
            this.personalGroupBox.Controls.Add(this.label12);
            this.personalGroupBox.Controls.Add(this.label3);
            this.personalGroupBox.Controls.Add(this.label8);
            this.personalGroupBox.Controls.Add(this.label7);
            this.personalGroupBox.Controls.Add(this.label4);
            this.personalGroupBox.Controls.Add(this.label5);
            this.personalGroupBox.Controls.Add(this.surnameTextBox);
            this.personalGroupBox.Controls.Add(this.streetTextBox);
            this.personalGroupBox.Controls.Add(this.label2);
            this.personalGroupBox.Controls.Add(this.birthdatePicker);
            this.personalGroupBox.Controls.Add(this.sexComboBox);
            this.personalGroupBox.Controls.Add(this.peselTextBox);
            this.personalGroupBox.Controls.Add(this.cityTextBox);
            this.personalGroupBox.Controls.Add(this.insuranceTextBox);
            this.personalGroupBox.Location = new System.Drawing.Point(12, 28);
            this.personalGroupBox.Name = "personalGroupBox";
            this.personalGroupBox.Size = new System.Drawing.Size(984, 100);
            this.personalGroupBox.TabIndex = 25;
            this.personalGroupBox.TabStop = false;
            this.personalGroupBox.Text = "Dane osobowe";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(534, 18);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(66, 20);
            this.countryTextBox.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(503, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Kraj";
            // 
            // returnButton1
            // 
            this.returnButton1.Location = new System.Drawing.Point(864, 57);
            this.returnButton1.Name = "returnButton1";
            this.returnButton1.Size = new System.Drawing.Size(100, 32);
            this.returnButton1.TabIndex = 25;
            this.returnButton1.Text = "Powrót";
            this.returnButton1.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(864, 19);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 32);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(741, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nr lokalu";
            // 
            // apartmentTextBox
            // 
            this.apartmentTextBox.Location = new System.Drawing.Point(796, 45);
            this.apartmentTextBox.Mask = "000";
            this.apartmentTextBox.Name = "apartmentTextBox";
            this.apartmentTextBox.Size = new System.Drawing.Size(25, 20);
            this.apartmentTextBox.TabIndex = 21;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.appointmentsTabPage);
            this.tabControl.Controls.Add(this.examinationsTabPage);
            this.tabControl.Controls.Add(this.laboratoryTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 134);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(837, 583);
            this.tabControl.TabIndex = 26;
            // 
            // appointmentsTabPage
            // 
            this.appointmentsTabPage.Controls.Add(this.appointmentsDataGrid);
            this.appointmentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.appointmentsTabPage.Name = "appointmentsTabPage";
            this.appointmentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentsTabPage.Size = new System.Drawing.Size(829, 557);
            this.appointmentsTabPage.TabIndex = 0;
            this.appointmentsTabPage.Text = "Wizyty";
            this.appointmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // appointmentsDataGrid
            // 
            this.appointmentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.appointmentsDataGrid.Name = "appointmentsDataGrid";
            this.appointmentsDataGrid.Size = new System.Drawing.Size(829, 557);
            this.appointmentsDataGrid.TabIndex = 0;
            // 
            // examinationsTabPage
            // 
            this.examinationsTabPage.Controls.Add(this.examinationsDataGrid);
            this.examinationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.examinationsTabPage.Name = "examinationsTabPage";
            this.examinationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.examinationsTabPage.Size = new System.Drawing.Size(829, 557);
            this.examinationsTabPage.TabIndex = 1;
            this.examinationsTabPage.Text = "Badania";
            this.examinationsTabPage.UseVisualStyleBackColor = true;
            // 
            // examinationsDataGrid
            // 
            this.examinationsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examinationsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.examinationsDataGrid.Name = "examinationsDataGrid";
            this.examinationsDataGrid.Size = new System.Drawing.Size(829, 557);
            this.examinationsDataGrid.TabIndex = 1;
            // 
            // laboratoryTabPage
            // 
            this.laboratoryTabPage.Controls.Add(this.laboratoryDataGrid);
            this.laboratoryTabPage.Location = new System.Drawing.Point(4, 22);
            this.laboratoryTabPage.Name = "laboratoryTabPage";
            this.laboratoryTabPage.Size = new System.Drawing.Size(829, 557);
            this.laboratoryTabPage.TabIndex = 2;
            this.laboratoryTabPage.Text = "Zlecenia";
            this.laboratoryTabPage.UseVisualStyleBackColor = true;
            // 
            // laboratoryDataGrid
            // 
            this.laboratoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laboratoryDataGrid.Location = new System.Drawing.Point(0, 0);
            this.laboratoryDataGrid.Name = "laboratoryDataGrid";
            this.laboratoryDataGrid.Size = new System.Drawing.Size(829, 557);
            this.laboratoryDataGrid.TabIndex = 1;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(858, 156);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(139, 32);
            this.detailsButton.TabIndex = 27;
            this.detailsButton.Text = "Szczegóły";
            this.detailsButton.UseVisualStyleBackColor = true;
            // 
            // returnButton2
            // 
            this.returnButton2.Location = new System.Drawing.Point(858, 681);
            this.returnButton2.Name = "returnButton2";
            this.returnButton2.Size = new System.Drawing.Size(138, 32);
            this.returnButton2.TabIndex = 34;
            this.returnButton2.Text = "Powrót";
            this.returnButton2.UseVisualStyleBackColor = true;
            // 
            // DetailedPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.returnButton2);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.personalGroupBox);
            this.Controls.Add(this.toolStrip);
            this.Name = "DetailedPatientForm";
            this.Text = "Pacjent";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.personalGroupBox.ResumeLayout(false);
            this.personalGroupBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.appointmentsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGrid)).EndInit();
            this.examinationsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examinationsDataGrid)).EndInit();
            this.laboratoryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox peselTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox insuranceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox houseTextBox;
        private System.Windows.Forms.MaskedTextBox postcodeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSplitButton userButton;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.GroupBox personalGroupBox;                     //locked for doctor
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox apartmentTextBox;
        private System.Windows.Forms.Button returnButton1;                          //inaccesible for doctor
        private System.Windows.Forms.Button saveButton;                             //inaccesible for doctor
        private System.Windows.Forms.TabControl tabControl;                         //inaccesible for registrar
        private System.Windows.Forms.TabPage appointmentsTabPage;
        private System.Windows.Forms.TabPage examinationsTabPage;
        private System.Windows.Forms.TabPage laboratoryTabPage;
        private System.Windows.Forms.Button detailsButton;                          //inaccesible for registrar
        private System.Windows.Forms.DataGridView appointmentsDataGrid;
        private System.Windows.Forms.DataGridView examinationsDataGrid;
        private System.Windows.Forms.DataGridView laboratoryDataGrid;
        private System.Windows.Forms.Button returnButton2;                          //inaccesible for registrar
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label label16;
    }
}