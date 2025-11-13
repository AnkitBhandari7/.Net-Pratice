namespace ConsoleApp3;

public class DataType
{
    public void DataTypeChecker()
    {
        // Different data types
        byte b = 10;
        short s = 1000;
        int i = 50000;
        long l = 1000000000L;
        float f = 3.14f;
        double d = 9.8765;
        decimal dec = 123.456m;
        char ch = 'A';
        bool flag = true;

        // Type conversion
        string numString = i.ToString();   // Convert int to string
        double convertedDouble = double.Parse("3.14"); // Convert string to double

        // Print all values
        Console.WriteLine($"byte: {b}");
        Console.WriteLine($"short: {s}");
        Console.WriteLine($"int: {i}");
        Console.WriteLine($"long: {l}");
        Console.WriteLine($"float: {f}");
        Console.WriteLine($"double: {d}");
        Console.WriteLine($"decimal: {dec}");
        Console.WriteLine($"char: {ch}");
        Console.WriteLine($"bool: {flag}");
        Console.WriteLine($"Converted int to string: {numString}");
        Console.WriteLine($"Converted string to double: {convertedDouble}");
    }
}