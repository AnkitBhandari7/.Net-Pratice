namespace ConsoleApp3;

public class Arrays
{
    public void ArryasMethod()
    {
        // Create an array of 5 favorite numbers
        int[] numbers = { 5, 2, 9, 1, 7 };

        // Sort array in ascending order
        Array.Sort(numbers);

        // Reverse array to descending order
        Array.Reverse(numbers);

        // Print each element using a for loop
        Console.WriteLine("Numbers in array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Find position of a specific number
        int position = Array.IndexOf(numbers, 7);
        Console.WriteLine($"Position of number 7: {position}");
    }
}