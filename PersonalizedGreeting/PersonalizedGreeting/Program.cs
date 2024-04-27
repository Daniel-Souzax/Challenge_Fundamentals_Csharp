namespace PersonalizedGreeting;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write your name for a personalized greeting:");

        string userName = Console.ReadLine().Trim();
        string personalizedGreeting = $"Olá, {userName}! Seja muito bem-vindo!";

        Console.WriteLine(personalizedGreeting);
    }
}