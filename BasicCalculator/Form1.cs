namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal operand1 = Convert.ToDecimal(operand1Textbox.Text);
            decimal operand2 = Convert.ToDecimal(operand2Textbox.Text);
            string operatorSymbol = operatorTextbox.Text;

            decimal result = Calculate(operand1, operand2, operatorSymbol);

            MessageBox.Show("Result: " + result.ToString());
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
                return op1 / op2;
            }
            return 0;

        }
    }
}
