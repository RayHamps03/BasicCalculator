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
            // Initialize variables
            decimal operand1;
            decimal operand2;
            string operatorSymbol;

            // Assigns operand1 if textbox is filled and operand1 is decimal
            if (!IsEmpty(operand1Textbox.Text) && IsDecimal(operand1Textbox.Text))
            {
                operand1 = Convert.ToDecimal(operand1Textbox.Text);
            }
            else
            {
                return;
            }
            // Assigns operand2 if textbox is filled and operand2 is decimal
            if (!IsEmpty(operand2Textbox.Text) && IsDecimal(operand2Textbox.Text))
            { 
                operand2 = Convert.ToDecimal(operand2Textbox.Text);
            }
            else
            {
                return;
            }
            // Assigns operator if textbox is filled and operator is valid
            if (!IsEmpty(operatorTextbox.Text) && IsValidOperator(operatorTextbox.Text))
            {
                operatorSymbol = operatorTextbox.Text;
            }
            else
            {
                return;
            }

            // Calculates the two numbers based on user input
            decimal result = Calculate(operand1, operand2, operatorSymbol);

            // Determines if zero division occurs, and displays results if it does not occur
            if (NotZeroDivisor(operand2, operatorSymbol))
            {
                MessageBox.Show("Result: " + result.ToString());
            }
            else
            {
                MessageBox.Show("Cannot divide by zero.");
            }
            
        }

        /// <summary>
        /// Performs basic arithmetic operation based on inputted operator symbol
        /// </summary>
        /// <param name="op1"></param>
        /// <param name="op2"></param>
        /// <param name="opSymbol"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Input validation to check if textboxes are empty or not. Returns true if so,
        /// and false otherwise
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool IsEmpty(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Input cannot be empty. Please provide valid values.");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Input validation for operator variable to check if it is a valid operator(+, -, /, *).
        /// Returns true if so and false otherwise
        /// </summary>
        /// <param name="opSymbol"></param>
        /// <returns></returns>
        private bool IsValidOperator(string opSymbol)
        {
            if (opSymbol == "+" || opSymbol == "-" || opSymbol == "*" || opSymbol == "/") {
                return true;
            }
            MessageBox.Show("Invalid operator. Please use +, -, *, or /.");
            return false;
        }

        /// <summary>
        /// Input validation for operands to check if it is a valid decimal value.
        /// Returns true if so and false otherwise
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool IsDecimal(string input)
        {
            if (decimal.TryParse(input, out decimal result))
            {
                return true;
            }
            MessageBox.Show("Please enter valid decimal values for both operands.");
            return false;
        }

        /// <summary>
        /// Input validation if operand2 variable is zero and operator is "/" to check
        /// if the program divides by zero. Returns true if so and false otherwise
        /// </summary>
        /// <param name="op2"></param>
        /// <param name="opSymbol"></param>
        /// <returns></returns>
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
