// See https://aka.ms/new-console-template for more information
using System;
using ArithmeticOperationsApp.Operations;
using ArithmeticOperationsApp.Helpers;

namespace ArithmeticOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Console-Based Arithmetic Operations ===\n");

            double num1 = InputHelper.GetNumber("Enter the first number: ");
            double num2 = InputHelper.GetNumber("Enter the second number: ");

            Calculator calc = new Calculator();

            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"Addition:       {calc.Add(num1, num2)}");
            Console.WriteLine($"Subtraction:    {calc.Subtract(num1, num2)}");
            Console.WriteLine($"Multiplication: {calc.Multiply(num1, num2)}");
            Console.WriteLine($"Division:       {calc.Divide(num1, num2)}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
