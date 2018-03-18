namespace lab2 {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.LecturerNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PulpitNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LectureHallInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateOfBirthInput = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneNumberInput = new System.Windows.Forms.MaskedTextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Lecturers = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pulpit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureHall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Lecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create a new lecturer";
            // 
            // LecturerNameInput
            // 
            this.LecturerNameInput.Location = new System.Drawing.Point(17, 59);
            this.LecturerNameInput.Name = "LecturerNameInput";
            this.LecturerNameInput.Size = new System.Drawing.Size(209, 20);
            this.LecturerNameInput.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lecturer Name";
            // 
            // PulpitNameInput
            // 
            this.PulpitNameInput.Location = new System.Drawing.Point(17, 102);
            this.PulpitNameInput.Name = "PulpitNameInput";
            this.PulpitNameInput.Size = new System.Drawing.Size(209, 20);
            this.PulpitNameInput.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pulpit Name";
            // 
            // LectureHallInput
            // 
            this.LectureHallInput.Location = new System.Drawing.Point(17, 147);
            this.LectureHallInput.Name = "LectureHallInput";
            this.LectureHallInput.Size = new System.Drawing.Size(209, 20);
            this.LectureHallInput.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lecture hall";
            // 
            // DateOfBirthInput
            // 
            this.DateOfBirthInput.Location = new System.Drawing.Point(17, 192);
            this.DateOfBirthInput.Name = "DateOfBirthInput";
            this.DateOfBirthInput.Size = new System.Drawing.Size(209, 20);
            this.DateOfBirthInput.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone number";
            // 
            // PhoneNumberInput
            // 
            this.PhoneNumberInput.Location = new System.Drawing.Point(17, 239);
            this.PhoneNumberInput.Mask = "+375 (00) 000-00-00";
            this.PhoneNumberInput.Name = "PhoneNumberInput";
            this.PhoneNumberInput.Size = new System.Drawing.Size(209, 20);
            this.PhoneNumberInput.TabIndex = 17;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(620, 274);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 18;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(701, 274);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Lecturers
            // 
            this.Lecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lecturers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Pulpit,
            this.LectureHall,
            this.DateOfBirth,
            this.PhoneNumber});
            this.Lecturers.Location = new System.Drawing.Point(232, 12);
            this.Lecturers.Name = "Lecturers";
            this.Lecturers.ReadOnly = true;
            this.Lecturers.Size = new System.Drawing.Size(544, 247);
            this.Lecturers.TabIndex = 20;
            // 
            // Name
            // 
            this.Name.HeaderText = "Lecturer Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Pulpit
            // 
            this.Pulpit.HeaderText = "Pulpit Name";
            this.Pulpit.Name = "Pulpit";
            this.Pulpit.ReadOnly = true;
            // 
            // LectureHall
            // 
            this.LectureHall.HeaderText = "Lecture Hall";
            this.LectureHall.Name = "LectureHall";
            this.LectureHall.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(17, 274);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(209, 23);
            this.AddButton.TabIndex = 21;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 311);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Lecturers);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PhoneNumberInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateOfBirthInput);
            this.Controls.Add(this.LectureHallInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PulpitNameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LecturerNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Lecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LecturerNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PulpitNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LectureHallInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateOfBirthInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox PhoneNumberInput;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView Lecturers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pulpit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureHall;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.Button AddButton;
    }
}