using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task12Calculator
{
    public partial class CalculatorForm : Form
    {
        private Calculator calculator;

        public CalculatorForm()
        {
            InitializeComponent();
            calculator = new Calculator();
            //ResultLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calculator, "Result"));
            //Binding binding = new Binding("Text", this.calculator, "Result");
            //binding.Format += (sender, e) => e.Value = $"O: {e.Value}";
            //ResultLabel.DataBindings.Add(binding);
            // TODO data binding для отображения результатов вычисления
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterNumber(1);
        }

        private void OnButton2Click(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterNumber(2);
        }

        private void OnButton3Click(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterNumber(3);
        }

        private void OnButton4Click(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterNumber(4);
        }

        private void OnButton5Click(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterNumber(5);
        }

        private void OnButton6Click(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterNumber(6);
        }

        private void OnButton7Click(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterNumber(7);
        }

        private void OnButton8Click(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterNumber(8);
        }

        private void OnButton9Click(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterNumber(9);
        }

        private void OnButton0Click(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterNumber(0);
        }

        private void OnButtonClearClick(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.Clear();
        }

        private void OnButtonEqualsClick(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.Equals();
        }

        private void OnButtonPlusClick(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterOperation(Calculator.Operation.Plus);
        }

        private void OnButtonMinusClick(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterOperation(Calculator.Operation.Minus);
        }

        private void OnButtonMultiplyClick(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterOperation(Calculator.Operation.Multiply);
        }

        private void OnButtonDivideClick(object sender, EventArgs e)
        {
            ResultLabel.Text = calculator.EnterOperation(Calculator.Operation.Divide);
        }
    }
}
