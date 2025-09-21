namespace ArithmeticOperationsApp.Operations
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;

        public string Divide(double a, double b)
        {
            if (b == 0)
                return "Error: Division by zero is not allowed!";
            return (a / b).ToString();
        }
    }
}