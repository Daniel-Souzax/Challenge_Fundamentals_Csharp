namespace MathOperations;

public class Calculator
{
    public void Sum(double firstNumber, double secondNumber) => Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
    public void Subtraction(double firstNumber, double secondNumber) => Console.WriteLine($"Subtracting {firstNumber} and {secondNumber} is {firstNumber - secondNumber}");
    public void Multiply(double firstNumber, double secondNumber) => Console.WriteLine($"The multiplication of {firstNumber} and {secondNumber} is {Math.Round(firstNumber * secondNumber,2)}");
    public void Avarage(double firstNumber, double secondNumber) => Console.WriteLine($"The average of {firstNumber} and {secondNumber} is {(firstNumber + secondNumber) / 2}");
    public void Division(double firstNumber, double secondNumber)
    {
   
        if(secondNumber == 0)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        else
        {
            Console.WriteLine($"The division of {firstNumber} and {secondNumber} is {Math.Round(firstNumber / secondNumber, 2)}");
        }
    }
}   
