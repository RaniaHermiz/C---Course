using System;

namespace ArithmeticApp
{
    // Define a class with a different name
    class Calculator
    {
        // Method that takes two integers and does addition on the first, shows second
        public void ProcessNumbers(int value1, int value2)
        {
            // Add 100 to the first number
            int sum = value1 + 100;

            // Print the result of the addition
            Console.WriteLine("First number after adding 100: " + sum);

            // Print the second number
            Console.WriteLine("Second input number: " + value2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Calculator
            Calculator calc = new Calculator();

            // Call using positional arguments
            calc.ProcessNumbers(20, 5);

            // Call using named arguments
            calc.ProcessNumbers(value1: 45, value2: 30);

            Console.ReadLine(); // Pause console
        }
    }
}
