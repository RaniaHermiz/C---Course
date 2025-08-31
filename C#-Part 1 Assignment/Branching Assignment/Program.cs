using System;

class Program
{
    static void Main()
    {
        // Initial greeting
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("-------------------------------------------------------------");

        // === SECTION: PACKAGE WEIGHT ===
        Console.Write("Input package weight [lbs]: ");
        decimal wt = Convert.ToDecimal(Console.ReadLine());

        if (wt > 50)
        {
            Console.WriteLine("ERROR: Package too heavy to be shipped via Package Express.");
            Console.WriteLine("Have a good day.");
            return;
        }

        // === SECTION: PACKAGE DIMENSIONS ===
        Console.Write("Input width [inches]: ");
        decimal w = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Input height [inches]: ");
        decimal h = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Input length [inches]: ");
        decimal l = Convert.ToDecimal(Console.ReadLine());

        // Check total size constraint
        if ((w + h + l) > 50)
        {
            Console.WriteLine("ERROR: Package too big to be shipped via Package Express.");
            return;
        }

        // === SECTION: QUOTE CALCULATION ===
        decimal result = (w * h * l * wt) / 100;

        // === OUTPUT ===
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine($"Estimated Shipping Quote: ${result:0.00}");
        Console.WriteLine("Thank you for using Package Express.");
    }
}
