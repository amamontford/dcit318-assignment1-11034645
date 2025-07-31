using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a program to run:");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter your choice (1-4): ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        GradeCalculator.GradeCalculator.Run();
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine();
                        TicketPriceCalculator.TicketPriceCalculator.Run();
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine();
                        TriangleTypeIdentifier.TriangleTypeIdentifier.Run();
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                        Console.WriteLine();
                        break;
                }

                // Show menu again after program finishes
                Console.WriteLine("Choose a program to run:");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
            }
        }
    }
} 