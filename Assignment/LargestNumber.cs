namespace Assignment;

public class LargestNumber
{
    public void FindLargest()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a >= b && a >= c)
            Console.WriteLine($"{a} is the largest number.");
        else if (b >= a && b >= c)
            Console.WriteLine($"{b} is the largest number.");
        else
            Console.WriteLine($"{c} is the largest number.");
    }
}