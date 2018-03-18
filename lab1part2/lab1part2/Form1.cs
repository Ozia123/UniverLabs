using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace lab1part2 {
    public partial class Form1 : Form {
        private Random rand = new Random();
        private List<int> collection = new List<int>();

        public Form1() {
            InitializeComponent();
        }

        private int GetCollectionSize() {
            int size = 0;
            try {
                size = Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException) {
                return 0;
            }
            return size;
        }

        private void SetCollection(int size) {
            collection = new List<int>();
            for (int i = 0; i < size; i++) {
                collection.Add(rand.Next(0, 200));
            }
        }

        private void PrintCollection() {
            StringBuilder builder = new StringBuilder();
            foreach (var el in collection) {
                builder.Append(el + "\n");
            }
            richTextBox1.Text = builder.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            int size = GetCollectionSize();
            SetCollection(size);
            PrintCollection();
        }

        private void button2_Click(object sender, EventArgs e) {
            collection = collection.OrderBy(i => i).ToList();
            PrintCollection();
        }

        private void button3_Click(object sender, EventArgs e) {
            collection = collection.OrderByDescending(i => i).ToList();
            PrintCollection();
        }

        private void button4_Click(object sender, EventArgs e) {
            if (collection.Count == 0) {
                return;
            }
            int min = collection.Min(i => i);
            MessageBox.Show(this, "Min element is: " + min);
        }

        private void button5_Click(object sender, EventArgs e) {
            if (collection.Count == 0) {
                return;
            }
            int max = collection.Max(i => i);
            MessageBox.Show(this, "Max element is: " + max);
        }

        private void button6_Click(object sender, EventArgs e) {
            if (collection.Count == 0) {
                return;
            }
            int sum = collection.Sum(i => i);
            MessageBox.Show(this, "Sum is: " + sum);
        }
    }
}