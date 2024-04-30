
using System.Globalization;

namespace DateAndTime;

class Program
{
    static void Main()
    {
        DateTime fullDateAndTime = DateTime.Now;
        string dateOnly = fullDateAndTime.ToString("dd/MM/yyyy");
        string timeOnly = fullDateAndTime.ToString("HH:mm:ss");
        string dateMonthFull = fullDateAndTime.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("PT-pt"));

        Console.WriteLine(fullDateAndTime);
        Console.WriteLine(dateOnly);
        Console.WriteLine(timeOnly);
        Console.WriteLine(dateMonthFull);
    }
}