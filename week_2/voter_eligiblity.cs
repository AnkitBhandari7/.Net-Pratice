namespace ConsoleApp3;

public class voter_eligiblity
{
    public void UserInput()
    {
        Console.Write("What is your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are eligible for voting ");
            
        }
        else
        {
            Console.WriteLine("You are not eligible for voting ");
        }
    }
}