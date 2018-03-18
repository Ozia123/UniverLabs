using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab2.DataContainers;
using lab2.Models;

namespace lab2 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
            ShowLecturers();
        }

        private void ShowLecturers() {
            foreach (var lecturer in DataContainer.Lecturers) {
                AddLecturerToTable(lecturer);
            }
        }

        private LecturerModel GetLecturerModelFromInputs() {
            return new LecturerModel {
                Name = this.LecturerNameInput.Text,
                Pulpit = this.PulpitNameInput.Text,
                LectureHall = this.LectureHallInput.Text,
                DateOfBirth = this.DateOfBirthInput.Value,
                PhoneNumber = this.PhoneNumberInput.Text
            };
        }

        private LecturerModel GetLecturerModelFromRow(DataGridViewRow row) {
            return new LecturerModel {
                Name = (string)row.Cells[0].Value,
                Pulpit = (string)row.Cells[1].Value,
                LectureHall = (string)row.Cells[2].Value,
                DateOfBirth = (DateTime)row.Cells[3].Value,
                PhoneNumber = (string)row.Cells[4].Value
            };
        }

        private bool isValidModel(LecturerModel model) {
            return !model.Name.Equals(string.Empty)
                && !model.Pulpit.Equals(string.Empty)
                && !model.LectureHall.Equals(string.Empty)
                && !model.PhoneNumber.Equals(string.Empty);
        }

        private void AddLecturerToTable(LecturerModel model) {
            int rowNum = Lecturers.Rows.Add();
            Lecturers.Rows[rowNum].Cells[0].Value = model.Name;
            Lecturers.Rows[rowNum].Cells[1].Value = model.Pulpit;
            Lecturers.Rows[rowNum].Cells[2].Value = model.LectureHall;
            Lecturers.Rows[rowNum].Cells[3].Value = model.DateOfBirth;
            Lecturers.Rows[rowNum].Cells[4].Value = model.PhoneNumber;
        }

        private void AddButton_Click(object sender, EventArgs e) {
            LecturerModel model = GetLecturerModelFromInputs();
            if (isValidModel(model)) {
                DataContainer.Lecturers.Add(model);
                DataContainer.SerializeLecturers();
                AddLecturerToTable(model);
            }
        }

        private void OkButton_Click(object sender, EventArgs e) {
            var selectedRows = Lecturers.SelectedRows;
            LecturerModel model = GetLecturerModelFromRow(selectedRows[0]);
            DataContainer.LecturerModel = model;
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}