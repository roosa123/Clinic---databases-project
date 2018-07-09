using DataLayer;

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
            this.label1.Location = new System.Drawing.Point(79, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(121, 23);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(183, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(121, 55);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(183, 22);
            this.surnameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data urodzenia";
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Location = new System.Drawing.Point(121, 87);
            this.birthdatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(183, 22);
            this.birthdatePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "PESEL";
            // 
            // peselTextBox
            // 
            this.peselTextBox.Location = new System.Drawing.Point(459, 55);
            this.peselTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.peselTextBox.Mask = "00000000000";
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(108, 22);
            this.peselTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nr ubezpieczenia";
            // 
            // insuranceTextBox
            // 
            this.insuranceTextBox.Location = new System.Drawing.Point(459, 87);
            this.insuranceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insuranceTextBox.Mask = "000000000000";
            this.insuranceTextBox.Name = "insuranceTextBox";
            this.insuranceTextBox.Size = new System.Drawing.Size(108, 22);
            this.insuranceTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(860, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nr telefonu";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(947, 87);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneTextBox.Mask = "000-000-000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(147, 22);
            this.phoneTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
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
            this.sexComboBox.Location = new System.Drawing.Point(459, 22);
            this.sexComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(41, 24);
            this.sexComboBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(653, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Miasto";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(712, 55);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(87, 22);
            this.cityTextBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(897, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ulica";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(947, 23);
            this.streetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(147, 22);
            this.streetTextBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(876, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nr domu";
            // 
            // houseTextBox
            // 
            this.houseTextBox.Location = new System.Drawing.Point(947, 55);
            this.houseTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.houseTextBox.Mask = "000";
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(32, 22);
            this.houseTextBox.TabIndex = 19;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.Location = new System.Drawing.Point(712, 87);
            this.postcodeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postcodeTextBox.Mask = "00-000";
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(87, 22);
            this.postcodeTextBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(605, 96);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Kod pocztowy";
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
            this.personalGroupBox.Location = new System.Drawing.Point(16, 34);
            this.personalGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.personalGroupBox.Name = "personalGroupBox";
            this.personalGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.personalGroupBox.Size = new System.Drawing.Size(1312, 123);
            this.personalGroupBox.TabIndex = 25;
            this.personalGroupBox.TabStop = false;
            this.personalGroupBox.Text = "Dane osobowe";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(712, 22);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(87, 22);
            this.countryTextBox.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(671, 31);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "Kraj";
            // 
            // returnButton1
            // 
            this.returnButton1.Location = new System.Drawing.Point(1152, 70);
            this.returnButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnButton1.Name = "returnButton1";
            this.returnButton1.Size = new System.Drawing.Size(133, 39);
            this.returnButton1.TabIndex = 25;
            this.returnButton1.Text = "Powrót";
            this.returnButton1.UseVisualStyleBackColor = true;
            this.returnButton1.Click += new System.EventHandler(this.returnButton1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1152, 23);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 39);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(988, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nr lokalu";
            // 
            // apartmentTextBox
            // 
            this.apartmentTextBox.Location = new System.Drawing.Point(1061, 55);
            this.apartmentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apartmentTextBox.Mask = "000";
            this.apartmentTextBox.Name = "apartmentTextBox";
            this.apartmentTextBox.Size = new System.Drawing.Size(32, 22);
            this.apartmentTextBox.TabIndex = 21;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.appointmentsTabPage);
            this.tabControl.Controls.Add(this.examinationsTabPage);
            this.tabControl.Controls.Add(this.laboratoryTabPage);
            this.tabControl.Location = new System.Drawing.Point(16, 165);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1116, 718);
            this.tabControl.TabIndex = 26;
            // 
            // appointmentsTabPage
            // 
            this.appointmentsTabPage.Controls.Add(this.appointmentsDataGrid);
            this.appointmentsTabPage.Location = new System.Drawing.Point(4, 25);
            this.appointmentsTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentsTabPage.Name = "appointmentsTabPage";
            this.appointmentsTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentsTabPage.Size = new System.Drawing.Size(1108, 689);
            this.appointmentsTabPage.TabIndex = 0;
            this.appointmentsTabPage.Text = "Wizyty";
            this.appointmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // appointmentsDataGrid
            // 
            this.appointmentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.appointmentsDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentsDataGrid.Name = "appointmentsDataGrid";
            this.appointmentsDataGrid.Size = new System.Drawing.Size(1105, 686);
            this.appointmentsDataGrid.TabIndex = 0;
            // 
            // examinationsTabPage
            // 
            this.examinationsTabPage.Controls.Add(this.examinationsDataGrid);
            this.examinationsTabPage.Location = new System.Drawing.Point(4, 25);
            this.examinationsTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.examinationsTabPage.Name = "examinationsTabPage";
            this.examinationsTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.examinationsTabPage.Size = new System.Drawing.Size(1108, 689);
            this.examinationsTabPage.TabIndex = 1;
            this.examinationsTabPage.Text = "Badania";
            this.examinationsTabPage.UseVisualStyleBackColor = true;
            // 
            // examinationsDataGrid
            // 
            this.examinationsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examinationsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.examinationsDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.examinationsDataGrid.Name = "examinationsDataGrid";
            this.examinationsDataGrid.Size = new System.Drawing.Size(1105, 686);
            this.examinationsDataGrid.TabIndex = 1;
            // 
            // laboratoryTabPage
            // 
            this.laboratoryTabPage.Controls.Add(this.laboratoryDataGrid);
            this.laboratoryTabPage.Location = new System.Drawing.Point(4, 25);
            this.laboratoryTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laboratoryTabPage.Name = "laboratoryTabPage";
            this.laboratoryTabPage.Size = new System.Drawing.Size(1108, 689);
            this.laboratoryTabPage.TabIndex = 2;
            this.laboratoryTabPage.Text = "Zlecenia";
            this.laboratoryTabPage.UseVisualStyleBackColor = true;
            // 
            // laboratoryDataGrid
            // 
            this.laboratoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laboratoryDataGrid.Location = new System.Drawing.Point(0, 0);
            this.laboratoryDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laboratoryDataGrid.Name = "laboratoryDataGrid";
            this.laboratoryDataGrid.Size = new System.Drawing.Size(1105, 686);
            this.laboratoryDataGrid.TabIndex = 1;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(1144, 192);
            this.detailsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(185, 39);
            this.detailsButton.TabIndex = 27;
            this.detailsButton.Text = "Szczegóły";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // returnButton2
            // 
            this.returnButton2.Location = new System.Drawing.Point(1144, 838);
            this.returnButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnButton2.Name = "returnButton2";
            this.returnButton2.Size = new System.Drawing.Size(184, 39);
            this.returnButton2.TabIndex = 34;
            this.returnButton2.Text = "Powrót";
            this.returnButton2.UseVisualStyleBackColor = true;
            this.returnButton2.Click += new System.EventHandler(this.returnButton2_Click);
            // 
            // DetailedPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.returnButton2);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.personalGroupBox);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "DetailedPatientForm";
            this.Text = "Pacjent";
            this.Controls.SetChildIndex(this.personalGroupBox, 0);
            this.Controls.SetChildIndex(this.tabControl, 0);
            this.Controls.SetChildIndex(this.detailsButton, 0);
            this.Controls.SetChildIndex(this.returnButton2, 0);
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