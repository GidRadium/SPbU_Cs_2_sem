namespace Task12Calculator;

public partial class CalculatorForm : Form
{
    private Calculator calculator;

    public CalculatorForm()
    {
        InitializeComponent();
        calculator = new Calculator();
    }

    private void OnNumberButtonClick(object sender, EventArgs e)
    {
        var tag = (string)((System.Windows.Forms.Button)sender).Tag;
        this.ResultLabel.Text = calculator.EnterNumber(Int32.Parse(tag));
    }
    
    private void OnButtonClearClick(object sender, EventArgs e)
        => this.ResultLabel.Text = calculator.Clear();

    private void OnButtonEqualsClick(object sender, EventArgs e)
        => this.ResultLabel.Text = calculator.Equals();

    private void OnButtonPlusClick(object sender, EventArgs e)
        => this.ResultLabel.Text = calculator.EnterOperation(Calculator.Operation.Plus);

    private void OnButtonMinusClick(object sender, EventArgs e)
        => this.ResultLabel.Text = calculator.EnterOperation(Calculator.Operation.Minus);

    private void OnButtonMultiplyClick(object sender, EventArgs e)
        => this.ResultLabel.Text = calculator.EnterOperation(Calculator.Operation.Multiply);

    private void OnButtonDivideClick(object sender, EventArgs e)
        => this.ResultLabel.Text = calculator.EnterOperation(Calculator.Operation.Divide);
}
