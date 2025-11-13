// See https://aka.ms/new-console-template for more information

using System;
using Assignment;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Question 1 ===");
        Variables q1 = new Variables();
        q1.DisplayInfo();

        Console.WriteLine("\n=== Question 2 ===");
        Operators q2 = new Operators();
        q2.PerformOperations();

        Console.WriteLine("\n=== Question 3 ===");
        EvenOdd q3 = new EvenOdd();
        q3.CheckEvenOdd();

        Console.WriteLine("\n=== Question 4 ===");
        LargestNumber q4 = new LargestNumber();
        q4.FindLargest();

        Console.WriteLine("\n=== Question 5 ===");
        AgeChecker q5 = new AgeChecker();
        q5.CheckVotingEligibility();

        Console.WriteLine("\n=== Question 6 ===");
        GradeCalculator q6 = new GradeCalculator();
        q6.DisplayGrade();

        Console.WriteLine("\n=== Question 7 ===");
        SumOfNaturalNumbers q7 = new SumOfNaturalNumbers();
        q7.CalculateSum();

        Console.WriteLine("\n=== Question 8 ===");
        MultiplicationTable q8 = new MultiplicationTable();
        q8.DisplayTable();

        Console.WriteLine("\n=== Question 9 ===");
        Factorial q9 = new Factorial();
        q9.CalculateFactorial();

        Console.WriteLine("\n=== Question 10 ===");
        ReverseNumber q10 = new ReverseNumber();
        q10.Reverse();

        Console.WriteLine("\n=== Question 11 ===");
        Fibonacci q11 = new Fibonacci();
        q11.PrintFibonacci();
    }
}
