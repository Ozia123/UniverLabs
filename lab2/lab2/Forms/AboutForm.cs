using System;
using System.Windows.Forms;

namespace lab2.Forms {
    public partial class AboutForm : Form {
        public AboutForm() {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
