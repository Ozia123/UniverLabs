namespace lab2 {
    partial class Form1 {
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
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectInput = new System.Windows.Forms.TextBox();
            this.CourseInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TermInput = new System.Windows.Forms.NumericUpDown();
            this.SpecialtyInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumberOfLabsInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NumberOfLectionsInput = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NumberOfStudentsInput = new System.Windows.Forms.NumericUpDown();
            this.AddLecturerButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Subjects = new System.Windows.Forms.DataGridView();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Labs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Students = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CourseInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TermInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLabsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLectionsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfStudentsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Subjects)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Name";
            // 
            // SubjectInput
            // 
            this.SubjectInput.Location = new System.Drawing.Point(17, 59);
            this.SubjectInput.Name = "SubjectInput";
            this.SubjectInput.Size = new System.Drawing.Size(209, 20);
            this.SubjectInput.TabIndex = 2;
            // 
            // CourseInput
            // 
            this.CourseInput.Location = new System.Drawing.Point(17, 105);
            this.CourseInput.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CourseInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CourseInput.Name = "CourseInput";
            this.CourseInput.Size = new System.Drawing.Size(92, 20);
            this.CourseInput.TabIndex = 3;
            this.CourseInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Term";
            // 
            // TermInput
            // 
            this.TermInput.Location = new System.Drawing.Point(134, 105);
            this.TermInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TermInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TermInput.Name = "TermInput";
            this.TermInput.Size = new System.Drawing.Size(92, 20);
            this.TermInput.TabIndex = 5;
            this.TermInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SpecialtyInput
            // 
            this.SpecialtyInput.Location = new System.Drawing.Point(17, 154);
            this.SpecialtyInput.Name = "SpecialtyInput";
            this.SpecialtyInput.Size = new System.Drawing.Size(209, 20);
            this.SpecialtyInput.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Specialty Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of labs";
            // 
            // NumberOfLabsInput
            // 
            this.NumberOfLabsInput.Location = new System.Drawing.Point(134, 204);
            this.NumberOfLabsInput.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumberOfLabsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfLabsInput.Name = "NumberOfLabsInput";
            this.NumberOfLabsInput.Size = new System.Drawing.Size(92, 20);
            this.NumberOfLabsInput.TabIndex = 11;
            this.NumberOfLabsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Number of lections";
            // 
            // NumberOfLectionsInput
            // 
            this.NumberOfLectionsInput.Location = new System.Drawing.Point(17, 204);
            this.NumberOfLectionsInput.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumberOfLectionsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfLectionsInput.Name = "NumberOfLectionsInput";
            this.NumberOfLectionsInput.Size = new System.Drawing.Size(92, 20);
            this.NumberOfLectionsInput.TabIndex = 9;
            this.NumberOfLectionsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Number of students";
            // 
            // NumberOfStudentsInput
            // 
            this.NumberOfStudentsInput.Location = new System.Drawing.Point(17, 253);
            this.NumberOfStudentsInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumberOfStudentsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfStudentsInput.Name = "NumberOfStudentsInput";
            this.NumberOfStudentsInput.Size = new System.Drawing.Size(209, 20);
            this.NumberOfStudentsInput.TabIndex = 13;
            this.NumberOfStudentsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddLecturerButton
            // 
            this.AddLecturerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AddLecturerButton.Location = new System.Drawing.Point(58, 289);
            this.AddLecturerButton.Name = "AddLecturerButton";
            this.AddLecturerButton.Size = new System.Drawing.Size(87, 23);
            this.AddLecturerButton.TabIndex = 15;
            this.AddLecturerButton.Text = "Add Lecturer";
            this.AddLecturerButton.UseVisualStyleBackColor = true;
            this.AddLecturerButton.Click += new System.EventHandler(this.AddLecturerButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(151, 289);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Subjects
            // 
            this.Subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Subjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectName,
            this.Course,
            this.Term,
            this.Specialty,
            this.Lections,
            this.Labs,
            this.Students,
            this.Lector});
            this.Subjects.Location = new System.Drawing.Point(232, 12);
            this.Subjects.Name = "Subjects";
            this.Subjects.ReadOnly = true;
            this.Subjects.Size = new System.Drawing.Size(641, 300);
            this.Subjects.TabIndex = 17;
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "Subject";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Term
            // 
            this.Term.HeaderText = "Term";
            this.Term.Name = "Term";
            this.Term.ReadOnly = true;
            // 
            // Specialty
            // 
            this.Specialty.HeaderText = "Specialty";
            this.Specialty.Name = "Specialty";
            this.Specialty.ReadOnly = true;
            // 
            // Lections
            // 
            this.Lections.HeaderText = "Lections";
            this.Lections.Name = "Lections";
            this.Lections.ReadOnly = true;
            // 
            // Labs
            // 
            this.Labs.HeaderText = "Labs";
            this.Labs.Name = "Labs";
            this.Labs.ReadOnly = true;
            // 
            // Students
            // 
            this.Students.HeaderText = "Students";
            this.Students.Name = "Students";
            this.Students.ReadOnly = true;
            // 
            // Lector
            // 
            this.Lector.HeaderText = "Lector";
            this.Lector.Name = "Lector";
            this.Lector.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 329);
            this.Controls.Add(this.Subjects);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddLecturerButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumberOfStudentsInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumberOfLabsInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberOfLectionsInput);
            this.Controls.Add(this.SpecialtyInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TermInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CourseInput);
            this.Controls.Add(this.SubjectInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CourseInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TermInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLabsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLectionsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfStudentsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Subjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SubjectInput;
        private System.Windows.Forms.NumericUpDown CourseInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TermInput;
        private System.Windows.Forms.TextBox SpecialtyInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumberOfLabsInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumberOfLectionsInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NumberOfStudentsInput;
        private System.Windows.Forms.Button AddLecturerButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView Subjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Labs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Students;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lector;
    }
}

