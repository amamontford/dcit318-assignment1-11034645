using System;

namespace GradeCalculator
{
    public class GradeCalculator
    {
        public static void Run()
        {
            Console.WriteLine("Grade Calculator");
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