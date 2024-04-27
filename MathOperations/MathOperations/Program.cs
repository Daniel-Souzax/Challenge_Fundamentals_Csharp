namespace MathOperations;

class Program
{
    static void Main ()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Write the first number");
        double fistNumber = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Second the first number");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        calculator.Sum(fistNumber, secondNumber);
        calculator.Subtraction(fistNumber, secondNumber);
        calculator.Multiply(fistNumber, secondNumber);
        calculator.Division(fistNumber, secondNumber);
        calculator.Avarage(fistNumber, secondNumber);

    }
}