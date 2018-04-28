namespace Przychodnia
{
    partial class ExaminationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patientLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.examinationLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nazwa badania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Imię i nazwisko pacjenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Lekarz wykonujący badanie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Data wykonaia badania";
            // 
            // patientLabel
            // 
            this.patientLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.patientLabel.Location = new System.Drawing.Point(157, 101);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(250, 20);
            this.patientLabel.TabIndex = 31;
            // 
            // doctorLabel
            // 
            this.doctorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doctorLabel.Location = new System.Drawing.Point(157, 130);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(250, 20);
            this.doctorLabel.TabIndex = 32;
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateLabel.Location = new System.Drawing.Point(157, 161);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(250, 20);
            this.dateLabel.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Wynik";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(15, 217);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(981, 462);
            this.resultTextBox.TabIndex = 35;
            this.resultTextBox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(790, 685);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 32);
            this.saveButton.TabIndex = 36;
            this.saveButton.Text = "Wykonaj";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(896, 685);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(100, 32);
            this.returnButton.TabIndex = 37;
            this.returnButton.Text = "Powrót";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // examinationLabel
            // 
            this.examinationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.examinationLabel.Location = new System.Drawing.Point(157, 41);
            this.examinationLabel.Name = "examinationLabel";
            this.examinationLabel.Size = new System.Drawing.Size(250, 20);
            this.examinationLabel.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Kod badania";
            // 
            // codeLabel
            // 
            this.codeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.codeLabel.Location = new System.Drawing.Point(157, 71);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(76, 20);
            this.codeLabel.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "ID badania";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(317, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 42;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(413, 41);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 50);
            this.searchButton.TabIndex = 43;
            this.searchButton.Text = "Wyszukaj badanie";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ExaminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.examinationLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExaminationForm";
            this.Text = "Badanie fizykalne";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.patientLabel, 0);
            this.Controls.SetChildIndex(this.doctorLabel, 0);
            this.Controls.SetChildIndex(this.dateLabel, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.resultTextBox, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.returnButton, 0);
            this.Controls.SetChildIndex(this.examinationLabel, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.codeLabel, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.searchButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox resultTextBox;                 //locked for reviewing examination
        private System.Windows.Forms.Button saveButton;                         //inaccesible for reviewing examination
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label examinationLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button searchButton;
    }
}