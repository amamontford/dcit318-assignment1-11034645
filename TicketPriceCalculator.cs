using System;

namespace TicketPriceCalculator
{
    public class TicketPriceCalculator
    {
        public static void Run()
        {
             
            
            while (true)
            {
                try
                {
                    Console.WriteLine("Ticket Price Calculator");
                    Console.Write("Enter your age: ");
                    string? input = Console.ReadLine();

                    // Check if user wants to exit
                    if (string.IsNullOrWhiteSpace(input) || input.ToLower() == "exit" || input.ToLower() == "quit")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }

                    // Parse the input to an integer
                    if (int.TryParse(input, out int age))
                    {
                        // Validate age range
                        if (age >= 0 && age <= 120)
                        {
                            // Calculate ticket price
                            double ticketPrice = CalculateTicketPrice(age);

                            // Display result
                            Console.WriteLine($"Age: {age}");
                            Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
                            Console.WriteLine();

                            // Ask if user wants to continue
                            Console.Write("Do you want to calculate another ticket price? (y/n): ");
                            string? continueChoice = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(continueChoice) ||
                                continueChoice.ToLower() != "y" && continueChoice.ToLower() != "yes")
                            {
                                Console.WriteLine("Goodbye!");
                                break;
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Error: Age must be between 0 and 120.");
                            Console.WriteLine();

                            // Ask if user wants to continue after error
                            Console.Write("Do you want to try another age? (y/n): ");
                            string? continueChoice = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(continueChoice) ||
                                continueChoice.ToLower() != "y" && continueChoice.ToLower() != "yes")
                            {
                                Console.WriteLine("Goodbye!");
                                break;
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a valid age (whole number).");
                        Console.WriteLine();

                        // Ask if user wants to continue after error
                        Console.Write("Do you want to try another age? (y/n): ");
                        string? continueChoice = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(continueChoice) ||
                            continueChoice.ToLower() != "y" && continueChoice.ToLower() != "yes")
                        {
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.WriteLine();

                    // Ask if user wants to continue after exception
                    Console.Write("Do you want to try another age? (y/n): ");
                    string? continueChoice = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(continueChoice) ||
                        continueChoice.ToLower() != "y" && continueChoice.ToLower() != "yes")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    Console.WriteLine();
                }
            }
        }

    
        static double CalculateTicketPrice(int age)
        {
            // Senior citizens (65 and above) and children (12 and below) get discounted price
            if (age >= 65 || age <= 12)
            {
                return 7.0; // Discounted price
            }
            else
            {
                return 10.0; // Regular price
            }
        }
    }
} 