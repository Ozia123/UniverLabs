using lab1.Helpers;
using System;
using System.Windows.Forms;
using lab1.Strategies;

namespace lab1 {
    public partial class Form1 : Form {
        private readonly StrategiesRepository strategyRepository;

        public Form1() {
            strategyRepository = new StrategiesRepository();
            InitializeComponent();
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            button1.Enabled = !textBox1.Text.Equals(string.Empty);
        }

        private void button1_Click(object sender, EventArgs e) {
            string operation = textBox1.Text;

            foreach (var strategy in strategyRepository.Strategies) {
                if (strategy.IsValidOperation(operation)) {
                    output.Text = ExecuteStrategyWithResult(strategy, operation);
                    return;
                }
            }
        }

        private string ExecuteStrategyWithResult(Strategy strategy, string operation) {
            strategy.Execute(operation);
            return strategy.GetResult();
        }
    }
}