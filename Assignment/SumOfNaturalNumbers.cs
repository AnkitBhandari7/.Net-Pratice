namespace Assignment;

public class SumOfNaturalNumbers
{
    public void CalculateSum()
    {
        int sum = 0;

        // for loop from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }

        Console.WriteLine("Sum of first 10 natural numbers = " + sum);
    }
}