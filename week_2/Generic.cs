namespace ConsoleApp3;

public class Generic
{
    public void GenericMethod()
    {
        // Create a list of fruits
        List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };

        // Add a new fruit
        fruits.Add("Orange");

        // Remove one fruit
        fruits.Remove("Banana");

        // Print all fruits
        Console.WriteLine("List of fruits:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create a dictionary with fruit IDs
        Dictionary<int, string> fruitDict = new Dictionary<int, string>
        {
            {1, "Apple"},
            {2, "Mango"},
            {3, "Orange"}
        };

        // Add a new entry
        fruitDict.Add(4, "Grapes");

        // Print key-value pairs
        Console.WriteLine("\nFruit Dictionary:");
        foreach (var item in fruitDict)
        {
            Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
        }
    }
}