using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int result = firstNumber + secondNumber;

            Console.WriteLine($"Addition of {firstNumber} and {secondNumber} is = {result}");
            Console.WriteLine("Addition of" + firstNumber + "and" + secondNumber + "is=" + result);

        }
    }
}
