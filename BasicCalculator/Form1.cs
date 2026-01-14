namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal operand1;
            decimal operand2;
            string operatorSymbol;


            if (!IsEmpty(operand1Textbox.Text) && IsDecimal(operand1Textbox.Text))
            {
                operand1 = Convert.ToDecimal(operand1Textbox.Text);
            }
            else
            {
                return;
            }

            if (!IsEmpty(operand2Textbox.Text) && IsDecimal(operand2Textbox.Text))
            { 
                operand2 = Convert.ToDecimal(operand2Textbox.Text);
            }
            else
            {
                return;
            }

            if (!IsEmpty(operatorTextbox.Text) && IsValidOperator(operatorTextbox.Text))
            {
                operatorSymbol = operatorTextbox.Text;
            }
            else
            {
                return;
            }

            decimal result = Calculate(operand1, operand2, operatorSymbol);

            if (NotZeroDivisor(operand2, operatorSymbol))
            {
                MessageBox.Show("Result: " + result.ToString());
            }
            else
            {
                MessageBox.Show("Cannot divide by zero.");
            }
            
        }

        private decimal Calculate(decimal op1, decimal op2, string opSymbol)
        {
            if (opSymbol == "+")
            {
                return op1 + op2;
            }
            else if (opSymbol == "-")
            {
                return op1 - op2;
            }
            else if (opSymbol == "*")
            {
                return op1 * op2;
            }
            else if (opSymbol == "/")
            {
                if (op2 == 0 && opSymbol == "/")
                {
                    return 0;
                }
                return op1 / op2;
            }
            return 0;

        }

        private bool IsEmpty(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Input cannot be empty. Please provide valid values.");
                return true;
            }
            return false;
        }

        private bool IsValidOperator(string opSymbol)
        {
            if (opSymbol == "+" || opSymbol == "-" || opSymbol == "*" || opSymbol == "/") {
                return true;
            }
            MessageBox.Show("Invalid operator. Please use +, -, *, or /.");
            return false;
        }

        private bool IsDecimal(string input)
        {
            if (decimal.TryParse(input, out decimal result))
            {
                return true;
            }
            MessageBox.Show("Please enter valid decimal values for both operands.");
            return false;
        }

        private bool NotZeroDivisor(decimal op2, string opSymbol)
        {
            if (op2 == 0 && opSymbol == "/")
            {
                return false;
            }
            return true;
        }
    }
}
