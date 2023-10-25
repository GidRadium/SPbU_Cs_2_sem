namespace Task12Calculator
{
    internal class Calculator
    {
        public enum State
        {
            SettingOperand1,
            SettingOperand2,
            AfterEquals
        }

        public enum Operation
        {
            Plus,
            Minus,
            Multiply,
            Divide
        }

        private double operand1;
        private double operand2;
        private string operandBuffer;
        private Operation operationBetweenOperands;
        private State state;
        public string Result { get; set; }

        public string EnterNumber(int number)
        {
            switch (this.state)
            {
                case State.SettingOperand1:
                case State.SettingOperand2:
                    this.operandBuffer += number.ToString();
                    this.Result += number.ToString();
                    break;
                case State.AfterEquals:
                    this.operandBuffer = number.ToString();
                    this.Result = number.ToString();
                    this.state = State.SettingOperand1;
                    break;
            }

            return this.Result;
        }

        private double Calculate(double value1, double value2, Operation operation)
        {
            switch (operation)
            {
                case Operation.Plus:
                    return value1 + value2;
                case Operation.Minus:
                    return value1 - value2;
                case Operation.Multiply:
                    return value1 * value2;
                case Operation.Divide:
                    return value1 / value2;
                default: 
                    return 0;
            }
        }

        private string OperationToString(Operation operation)
        {
            switch (operation)
            {
                case Operation.Plus:
                    return "+";
                case Operation.Minus:
                    return "-";
                case Operation.Multiply:
                    return "*";
                case Operation.Divide:
                    return "/";
                default:
                    return " ";
            }
        }

        public string EnterOperation(Operation operation)
        {
            if (operandBuffer.Length == 0 && this.state != State.AfterEquals)
                return this.Result;

            State tempState = this.state;
            switch (tempState)
            {
                case State.SettingOperand1:
                    this.operand1 = double.Parse(this.operandBuffer);
                    this.operandBuffer = "";
                    this.operationBetweenOperands = operation;
                    this.state = State.SettingOperand2;
                    this.Result += $" {this.OperationToString(operation)} ";
                    break;
                case State.SettingOperand2:
                    this.operand2 = double.Parse(this.operandBuffer);
                    this.operandBuffer = "";
                    // TODO check divide by 0
                    double result = this.Calculate(operand1, operand2, this.operationBetweenOperands);
                    this.operationBetweenOperands = operation;
                    this.operand1 = result;
                    this.Result = $"{this.operand1} {this.OperationToString(operation)} ";
                    break;
                case State.AfterEquals:
                    this.operationBetweenOperands = operation;
                    this.state = State.SettingOperand2;
                    this.Result += $" {this.OperationToString(operation)} ";
                    break;
            }
            return this.Result;
        }

        public string Clear()
        {
            this.operandBuffer = "";
            this.Result = "";
            this.state = State.SettingOperand1;
            return this.Result;
        }

        public string Equals()
        {
            this.operand2 = double.Parse(this.operandBuffer);
            this.operandBuffer = "";
            double result = this.Calculate(operand1, operand2, this.operationBetweenOperands);
            this.operand1 = result;
            this.Result = this.operand1.ToString();
            this.state = State.AfterEquals;
            return this.Result;
        }
    }
}
