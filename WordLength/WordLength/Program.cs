namespace WordLength;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write one or more words");

        string oneOrMoreWords = Console.ReadLine().Trim();

        foreach (var word in oneOrMoreWords.Split(" "))
        {
            Console.WriteLine($"The word {word} has {word.Length} letters");
        }
    }
}