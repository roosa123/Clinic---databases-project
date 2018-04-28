namespace Przychodnia
{
    partial class AppointmentsForm
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
            this.appointmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.appointmentDetailsButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsDataGrid
            // 
            this.appointmentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGrid.Location = new System.Drawing.Point(33, 100);
            this.appointmentsDataGrid.Name = "appointmentsDataGrid";
            this.appointmentsDataGrid.Size = new System.Drawing.Size(839, 604);
            this.appointmentsDataGrid.TabIndex = 0;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "-",
            "Zarejestrowana",
            "Wykonana",
            "Anulowana"});
            this.statusComboBox.Location = new System.Drawing.Point(304, 52);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(101, 21);
            this.statusComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(66, 53);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.ShowCheckBox = true;
            this.fromDateTimePicker.Size = new System.Drawing.Size(157, 20);
            this.fromDateTimePicker.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lekarz";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(497, 53);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(350, 21);
            this.doctorComboBox.TabIndex = 8;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(878, 100);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(100, 32);
            this.executeButton.TabIndex = 9;
            this.executeButton.Text = "Obsłuż";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // appointmentDetailsButton
            // 
            this.appointmentDetailsButton.Location = new System.Drawing.Point(878, 138);
            this.appointmentDetailsButton.Name = "appointmentDetailsButton";
            this.appointmentDetailsButton.Size = new System.Drawing.Size(100, 32);
            this.appointmentDetailsButton.TabIndex = 10;
            this.appointmentDetailsButton.Text = "Pokaż";
            this.appointmentDetailsButton.UseVisualStyleBackColor = true;
            this.appointmentDetailsButton.Click += new System.EventHandler(this.appointmentDetailsButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(878, 42);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 32);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.appointmentDetailsButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.appointmentsDataGrid);
            this.Name = "AppointmentsForm";
            this.Text = "Wizyty";
            this.Controls.SetChildIndex(this.appointmentsDataGrid, 0);
            this.Controls.SetChildIndex(this.statusComboBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.fromDateTimePicker, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.doctorComboBox, 0);
            this.Controls.SetChildIndex(this.executeButton, 0);
            this.Controls.SetChildIndex(this.appointmentDetailsButton, 0);
            this.Controls.SetChildIndex(this.searchButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentsDataGrid;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox doctorComboBox;                    //locked for doctor
        private System.Windows.Forms.Button executeButton;                      //inaccesible for doctor
        private System.Windows.Forms.Button appointmentDetailsButton;
        private System.Windows.Forms.Button searchButton;
    }
}