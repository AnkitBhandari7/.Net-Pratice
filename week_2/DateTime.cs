namespace ConsoleApp3;

public class DateTimeExample
{
    public void DateTimeChecker()
    {
        // Birthdate
        DateTime birthDate = new DateTime(2002, 6, 15);

        // Current date and time
        DateTime now = DateTime.Now;

        // Calculate age using TimeSpan
        TimeSpan ageSpan = now - birthDate;
        int ageYears = (int)(ageSpan.Days / 365.25);

        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Current Date: {now.ToShortDateString()}");
        Console.WriteLine($"Your age is: {ageYears} years");

        // Add 10 days to birthdate
        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine($"10 days after your birthdate: {newDate.ToShortDateString()}");
    }
}