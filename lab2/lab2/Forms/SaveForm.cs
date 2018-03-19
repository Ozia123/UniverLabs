using System;
using System.Windows.Forms;
using lab2.DataContainers;

namespace lab2.Forms {
    public partial class SaveForm : Form {
        public SaveForm() {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            string FileName = FileNameInput.Text;
            DataContainer.SaveAs(FileName);
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
