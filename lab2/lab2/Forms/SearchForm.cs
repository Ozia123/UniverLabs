using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
using lab2.Models;
using lab2.DataContainers;

namespace lab2.Forms {
    public partial class SearchForm : Form {
        private CultureInfo cultureInfo = CultureInfo.InvariantCulture;
        private List<SubjectModel> SubjectsList = DataContainer.Subjects;

        public SearchForm() {
            InitializeComponent();
            ShowSubjects();
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

        private IEnumerable<SubjectModel> SearchForQuery(string query) {
            return DataContainer.Subjects.Where(s =>
                cultureInfo.CompareInfo.IndexOf(s.Name, query, CompareOptions.IgnoreCase) >= 0
                || cultureInfo.CompareInfo.IndexOf(s.Specialty, query, CompareOptions.IgnoreCase) >= 0
                || cultureInfo.CompareInfo.IndexOf(s.Lecturer.Name, query, CompareOptions.IgnoreCase) >= 0
            );
        }

        private void SearchButton_Click(object sender, EventArgs e) {
            string query = SearchInput.Text;
            if (query.Equals(string.Empty)) {
                return;
            }
            SubjectsList = SearchForQuery(query).ToList();
            ShowSubjects();
        }
    }
}
