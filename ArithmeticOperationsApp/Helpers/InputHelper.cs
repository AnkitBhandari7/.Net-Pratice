using System;

namespace ArithmeticOperationsApp.Helpers
{
    public static class InputHelper
    {
        public static double GetNumber(string message)
        {
            double number;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (double.TryParse(input, out number))
                    return number;

                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
    }
}