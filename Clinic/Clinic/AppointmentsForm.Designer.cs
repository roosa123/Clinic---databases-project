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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentsForm));
            this.appointmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.appointmentDetailsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.userButton = new System.Windows.Forms.ToolStripSplitButton();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGrid)).BeginInit();
            this.toolStrip.SuspendLayout();
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
            // 
            // appointmentDetailsButton
            // 
            this.appointmentDetailsButton.Location = new System.Drawing.Point(878, 138);
            this.appointmentDetailsButton.Name = "appointmentDetailsButton";
            this.appointmentDetailsButton.Size = new System.Drawing.Size(100, 32);
            this.appointmentDetailsButton.TabIndex = 10;
            this.appointmentDetailsButton.Text = "Pokaż";
            this.appointmentDetailsButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(878, 176);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 32);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip.TabIndex = 12;
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
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(878, 42);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 32);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(878, 672);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(100, 32);
            this.returnButton.TabIndex = 14;
            this.returnButton.Text = "Powrót";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.cancelButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGrid)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
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
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSplitButton userButton;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button returnButton;
    }
}