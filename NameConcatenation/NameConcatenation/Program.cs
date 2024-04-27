
namespace NameConcatenation;

class Program {

    static void Main ()
    {
        Console.WriteLine("Write your first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Write your last name:");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your full name is {firstName} {lastName}");

    }

}