namespace Assignment;

public class MultiplicationTable
{
    public void DisplayTable()
    {
        Console.Write("Enter a number to display its multiplication table: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int i = 1;

        while (i <= 10)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
            i++;
        }
    }
}