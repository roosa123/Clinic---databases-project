namespace Przychodnia
{
    partial class LaboratoryForm
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
            this.executeButton = new System.Windows.Forms.Button();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.examinationsDataGrid = new System.Windows.Forms.DataGridView();
            this.showButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.examinationsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(896, 100);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(100, 32);
            this.executeButton.TabIndex = 23;
            this.executeButton.Text = "Obsłuż";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(66, 51);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.ShowCheckBox = true;
            this.fromDateTimePicker.Size = new System.Drawing.Size(159, 20);
            this.fromDateTimePicker.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "-",
            "Zlecone",
            "Wykonane",
            "Anulowane",
            "Zatwierdzone"});
            this.statusComboBox.Location = new System.Drawing.Point(291, 50);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(101, 21);
            this.statusComboBox.TabIndex = 14;
            // 
            // examinationsDataGrid
            // 
            this.examinationsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examinationsDataGrid.Location = new System.Drawing.Point(33, 100);
            this.examinationsDataGrid.Name = "examinationsDataGrid";
            this.examinationsDataGrid.Size = new System.Drawing.Size(857, 604);
            this.examinationsDataGrid.TabIndex = 13;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(896, 138);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(100, 32);
            this.showButton.TabIndex = 26;
            this.showButton.Text = "Pokaż";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(435, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 32);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // LaboratoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.examinationsDataGrid);
            this.Name = "LaboratoryForm";
            this.Text = "Laboratorium";
            this.Controls.SetChildIndex(this.examinationsDataGrid, 0);
            this.Controls.SetChildIndex(this.statusComboBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.fromDateTimePicker, 0);
            this.Controls.SetChildIndex(this.executeButton, 0);
            this.Controls.SetChildIndex(this.showButton, 0);
            this.Controls.SetChildIndex(this.searchButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.examinationsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DataGridView examinationsDataGrid;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button searchButton;
    }
}