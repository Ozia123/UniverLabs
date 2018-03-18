using System;
using System.Windows.Forms;
using lab2.Models;
using lab2.DataContainers;

namespace lab2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            ShowSubjects();
        }

        private SubjectModel GetSubjectModelFromInputs() {
            return new SubjectModel {
                Name = SubjectInput.Text,
                Term = (int)TermInput.Value,
                Course = (int)CourseInput.Value,
                Specialty = SpecialtyInput.Text,
                NumberOfLections = (int)NumberOfLectionsInput.Value,
                NumberOfLabs = (int)NumberOfLabsInput.Value,
                NumberOfStudents = (int)NumberOfStudentsInput.Value
            };
        }

        private void AddSubjectToTable(SubjectModel model) {
            int rowNum = Subjects.Rows.Add();
            Subjects.Rows[rowNum].Cells[0].Value = model.Name;
            Subjects.Rows[rowNum].Cells[1].Value = model.Course;
            Subjects.Rows[rowNum].Cells[2].Value = model.Term;
            Subjects.Rows[rowNum].Cells[3].Value = model.Specialty;
            Subjects.Rows[rowNum].Cells[4].Value = model.NumberOfLections;
            Subjects.Rows[rowNum].Cells[5].Value = model.NumberOfLabs;
            Subjects.Rows[rowNum].Cells[6].Value = model.NumberOfStudents;
            Subjects.Rows[rowNum].Cells[7].Value = model.Lecturer.Name;
        }

        private void ShowSubjects() {
            foreach (var subject in DataContainer.Subjects) {
                AddSubjectToTable(subject);
            }
        }

        private bool isValidModel(SubjectModel model) {
            return !model.Name.Equals(string.Empty)
                && !model.Specialty.Equals(string.Empty)
                && model.Lecturer != null;
        }

        private void AddLecturerButton_Click(object sender, EventArgs e) {
            Form2 LecturerForm = new Form2();
            LecturerForm.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            SubjectModel model = GetSubjectModelFromInputs();
            model.Lecturer = DataContainer.LecturerModel;
            if (isValidModel(model)) {
                DataContainer.Subjects.Add(model);
                DataContainer.SerializeSubjects();
                AddSubjectToTable(model);
            }
        }
    }
}
