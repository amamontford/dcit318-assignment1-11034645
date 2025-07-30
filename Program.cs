using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Grade Calculator ===");
            Console.WriteLine("This program converts numerical grades to letter grades.");
            Console.WriteLine();

            while (true)
            {
                try
                {
                    // Prompt user for numerical grade
                    Console.Write("Enter a numerical grade (0-100): ");
                    string? input = Console.ReadLine();

                    // Check if user wants to exit
                    if (string.IsNullOrWhiteSpace(input) || input.ToLower() == "exit" || input.ToLower() == "quit")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }

                    // Parse the input to a double
                    if (double.TryParse(input, out double grade))
                    {
                        // Validate grade range
                        if (grade >= 0 && grade <= 100)
                        {
                            // Convert to letter grade
                            string letterGrade = ConvertToLetterGrade(grade);
                            
                            // Display result
                            Console.WriteLine($"Numerical Grade: {grade}");
                            Console.WriteLine($"Letter Grade: {letterGrade}");
                            Console.WriteLine();
                            
                            // Ask if user wants to continue
                            Console.Write("Do you want to convert another grade? (y/n): ");
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
                            Console.WriteLine("Error: Grade must be between 0 and 100.");
                            Console.WriteLine();
                            
                            // Ask if user wants to continue after error
                            Console.Write("Do you want to try another grade? (y/n): ");
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
                        Console.WriteLine("Error: Please enter a valid number.");
                        Console.WriteLine();
                        
                        // Ask if user wants to continue after error
                        Console.Write("Do you want to try another grade? (y/n): ");
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
                    Console.Write("Do you want to try another grade? (y/n): ");
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

        /// <summary>
        /// Converts a numerical grade to a letter grade based on the specified scale
        /// </summary>
        /// <param name="grade">The numerical grade (0-100)</param>
        /// <returns>The corresponding letter grade</returns>
        static string ConvertToLetterGrade(double grade)
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }
    }
} 