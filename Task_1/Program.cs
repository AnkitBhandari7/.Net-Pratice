namespace Week_4;
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Task 1: Student Class ===");

        // Creating first object of Student
        Student s1 = new Student();
        s1.name = "Ankit";
        s1.age = 21;
        s1.address = "Kathmandu";

        // Creating second object of Student
        Student s2 = new Student();
        s2.name = "Rahul";
        s2.age = 22;
        s2.address = "Pokhara";

        // Printing details
        Console.WriteLine($"{s1.name}, {s1.age}, {s1.address}, College: {Student.collegeName}");
        Console.WriteLine($"{s2.name}, {s2.age}, {s2.address}, College: {Student.collegeName}");


        Console.WriteLine("\n=== Task 2: Calculator ===");

        Calculator calc = new Calculator();
        calc.PrintWelcome();

        int addResult = calc.Add(10, 5);
        int mulResult = calc.Multiply(10); // second number defaults to 1

        Console.WriteLine($"Addition: {addResult}");
        Console.WriteLine($"Multiplication: {mulResult}");
        
        
        Console.WriteLine("\n=== Task 3: Parameter Types ===");

        ParameterDemo pd = new ParameterDemo();

        int num = 5;
        pd.Increase(ref num); // ref requires variable already assigned
        Console.WriteLine($"After Increase: {num}");

        pd.GetFullName(out string fullName); // out gets value from method
        Console.WriteLine($"Full Name: {fullName}");

        int total = pd.SumAll(1, 2, 3, 4, 5);
        Console.WriteLine($"SumAll: {total}");
        
        
        Console.WriteLine("\n=== Task 4: Constructors ===");

        Player p1 = new Player(); // default constructor

        Player p2 = new Player("Ankit", 10, 100); // parameterized constructor

        Console.WriteLine($"{p2.playerName}, Level: {p2.level}, Health: {p2.health}");
        
        
        Console.WriteLine("\n=== Task 5: Enums & Records ===");

        Console.Write("Enter a day: ");
        string day = Console.ReadLine().ToLower();

        DayType result =
            (day == "friday" || day == "saturday") ? DayType.Weekend : DayType.Weekday;

        Console.WriteLine($"It is: {result}");

        // Record example
        Book b1 = new Book("C# Basics", "John Doe", 19.99);

        // using WITH expression → create copy with changes
        Book b2 = b1 with { title = "Advanced C#", price = 29.99 };

        Console.WriteLine($"Book 1 → {b1}");

        // Deconstructing Book record
        var (title, author, price) = b2;
        Console.WriteLine($"Book 2 Details → {title}, {author}, {price}");


    }

}