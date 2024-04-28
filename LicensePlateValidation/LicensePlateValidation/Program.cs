namespace LicensePlateValidation;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Digite a placa do seu carro");
        string licensePlate = Console.ReadLine();
        Console.WriteLine(licensePlate);

        if (licensePlate.Length != 7) {
            Console.WriteLine("False");
            return;
        }

        string numbers = licensePlate.Substring(3);
        long number1 = 0;
        string letters = licensePlate.Substring(0,3);

        /*
        if (letters == "letras" && numbers == "numeros") Console.WriteLine("true");
        else Console.WriteLine("False");
        
        */




    }
}