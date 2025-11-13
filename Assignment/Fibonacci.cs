namespace Assignment;

public class Fibonacci
{
    public void PrintFibonacci()
    {
        int n1 = 0, n2 = 1, n3;
        Console.Write("First 10 Fibonacci terms: ");
        Console.Write(n1 + " " + n2 + " ");

        for (int i = 2; i < 10; i++)
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }

        Console.WriteLine();
    }
}