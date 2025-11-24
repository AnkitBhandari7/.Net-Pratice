namespace Week_4;

public class Calculator
{
    // Void method → does not return anything
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // Method with return type (int)
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    } 
}