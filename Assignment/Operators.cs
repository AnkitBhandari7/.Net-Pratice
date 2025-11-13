namespace Assignment;

public class Operators
{
    public void PerformOperations()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum = {a + b}");
        Console.WriteLine($"Difference = {a - b}");
        Console.WriteLine($"Product = {a * b}");
        Console.WriteLine($"Quotient = {(double)a / b}");
    }
}