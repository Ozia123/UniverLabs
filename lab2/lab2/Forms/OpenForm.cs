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

namespace lab2.Forms {
    public partial class OpenForm : Form {
        public Action onOpenAction = null;

        public OpenForm(Action onOpenAction) {
            InitializeComponent();
            this.onOpenAction = onOpenAction;
        }

        private void OpenButton_Click(object sender, EventArgs e) {
            string FileName = FileNameInput.Text;
            DataContainer.Open(FileName);
            onOpenAction();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
