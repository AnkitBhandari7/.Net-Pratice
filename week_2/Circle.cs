namespace ConsoleApp3;

public class Circle
{
    // Declare a constant variable (value cannot be changed)
    const double PI = 3.14;
    public void Area(){

    // Try to modify PI this will give an error
    // Circle.PI = 3.14159; // Error: cannot assign to constant

    // Print PI value
    Console.WriteLine($"Value of PI is: {Circle.PI}");

    // Calculate area and perimeter of a circle
    double radius = 5;
    double area = Circle.PI * radius * radius;
    double perimeter = 2 * Circle.PI * radius;

    Console.WriteLine($"Area: {area}");
    Console.WriteLine($"Perimeter: {perimeter}");
}


}

