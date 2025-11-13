namespace Assignment;

public class GradeCalculator
{
    public void DisplayGrade()
    {
        Console.Write("Enter marks (0–100): ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 80)
            Console.WriteLine("Grade: A");
        else if (marks >= 60)
            Console.WriteLine("Grade: B");
        else if (marks >= 40)
            Console.WriteLine("Grade: C");
        else
            Console.WriteLine("Grade: Fail");
    }
}