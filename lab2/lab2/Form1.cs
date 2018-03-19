using System;
using System.Windows.Forms;
using lab2.Forms;
using lab2.Models;
using lab2.DataContainers;
using System.Collections.Generic;
using System.Linq;

namespace lab2 {
    public partial class Form1 : Form {
        private List<SubjectModel> SubjectsList = DataContainer.Subjects;

        public Form1() {
            InitializeComponent();
            ShowSubjects();
        }

        private void onOpen() {
            SubjectsList = DataContainer.Subjects;
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
            Subjects.Rows.Clear();
            Subjects.Refresh();
            foreach (var subject in SubjectsList) {
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm openForm = new OpenForm(() => onOpen());
            openForm.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Saved!");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveForm saveForm = new SaveForm();
            saveForm.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e) {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e) {
            SubjectsList = SubjectsList.OrderBy(s => s.Name).ToList();
            ShowSubjects();
        }

        private void subjectDescendingToolStripMenuItem_Click(object sender, EventArgs e) {
            SubjectsList = SubjectsList.OrderByDescending(s => s.Name).ToList();
            ShowSubjects();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e) {
            SubjectsList = SubjectsList.OrderBy(s => s.Course).ToList();
            ShowSubjects();
        }

        private void courseDescendingToolStripMenuItem_Click(object sender, EventArgs e) {
            SubjectsList = SubjectsList.OrderByDescending(s => s.Course).ToList();
            ShowSubjects();
        }

        private void termToolStripMenuItem_Click(object sender, EventArgs e) {
            SubjectsList = SubjectsList.OrderBy(s => s.Term).ToList();
            ShowSubjects();
        }

        private void termDescendingToolStripMenuItem_Click(object sender, EventArgs e) {
            SubjectsList = SubjectsList.OrderByDescending(s => s.Term).ToList();
            ShowSubjects();
        }
    }
}