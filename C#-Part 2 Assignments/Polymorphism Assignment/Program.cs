using System;

namespace QuitApp_V1
{
    // Interface declaring Quit method
    interface IQuittable
    {
        void Quit();
    }

    // Employee class implementing the interface
    class Employee : IQuittable
    {
        public string FullName { get; set; }

        // Quit method logs a custom message with the current time
        public void Quit()
        {
            Console.WriteLine($"Employee {FullName} quit at {DateTime.Now}.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an employee
            Employee e = new Employee { FullName = "Rania Hermiz" };

            // Polymorphic assignment
            IQuittable quitter = e;

            // Call Quit using interface type
            quitter.Quit();

            Console.ReadKey();
        }
    }
}
