using System.Text.RegularExpressions;

namespace LicensePlateValidation;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Enter the license plate");
        string licensePlate = Console.ReadLine();

        if (licensePlate.Length != 7) {
            Console.WriteLine("false");
            return;
        }

        string numbers = licensePlate.Substring(3);
        string letters = licensePlate.Substring(0,3);

        bool validationNumbers = Regex.IsMatch(numbers, "^[0-9]+$");
        bool validationLetters = Regex.IsMatch(letters, "^[a-zA-Z]+$");

        if (validationNumbers && validationLetters) Console.WriteLine("True");
        else Console.WriteLine("False");

    }
}