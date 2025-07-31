using System;

namespace TriangleTypeIdentifier
{
    public class TriangleTypeIdentifier
    {
        public static void Run()
        {
            Console.WriteLine("Triangle Type Identifier");
            Console.WriteLine();

            while (true)
            {
                try
                {
                    // Prompt user for three sides of triangle
                    Console.Write("Enter the length of side 1: ");
                    string? input1 = Console.ReadLine();

                    // Check if user wants to exit
                    if (string.IsNullOrWhiteSpace(input1) || input1.ToLower() == "exit" || input1.ToLower() == "quit")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }

                    Console.Write("Enter the length of side 2: ");
                    string? input2 = Console.ReadLine();

                    Console.Write("Enter the length of side 3: ");
                    string? input3 = Console.ReadLine();

                    // Parse the inputs to doubles
                    if (double.TryParse(input1, out double side1) && 
                        double.TryParse(input2, out double side2) && 
                        double.TryParse(input3, out double side3))
                    {
                        // Validate that sides are positive
                        if (side1 > 0 && side2 > 0 && side3 > 0)
                        {
                            // Check if it's a valid triangle (sum of any two sides > third side)
                            if (IsValidTriangle(side1, side2, side3))
                            {
                                // Determine triangle type
                                string triangleType = DetermineTriangleType(side1, side2, side3);
                                
                                // Display result
                                Console.WriteLine($"Side 1: {side1}");
                                Console.WriteLine($"Side 2: {side2}");
                                Console.WriteLine($"Side 3: {side3}");
                                Console.WriteLine($"Triangle Type: {triangleType}");
                                Console.WriteLine();
                                
                                // Ask if user wants to continue
                                Console.Write("Do you want to identify another triangle? (y/n): ");
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
                                Console.WriteLine("Error: These side lengths cannot form a valid triangle.");
                                Console.WriteLine("The sum of any two sides must be greater than the third side.");
                                Console.WriteLine();
                                
                                // Ask if user wants to continue after error
                                Console.Write("Do you want to try another triangle? (y/n): ");
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
                            Console.WriteLine("Error: All sides must be positive numbers.");
                            Console.WriteLine();
                            
                            // Ask if user wants to continue after error
                            Console.Write("Do you want to try another triangle? (y/n): ");
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
                        Console.WriteLine("Error: Please enter valid numbers for all sides.");
                        Console.WriteLine();
                        
                        // Ask if user wants to continue after error
                        Console.Write("Do you want to try another triangle? (y/n): ");
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
                    Console.Write("Do you want to try another triangle? (y/n): ");
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
        /// Determines if three side lengths can form a valid triangle
        /// </summary>
        /// <param name="side1">Length of first side</param>
        /// <param name="side2">Length of second side</param>
        /// <param name="side3">Length of third side</param>
        /// <returns>True if valid triangle, false otherwise</returns>
        static bool IsValidTriangle(double side1, double side2, double side3)
        {
            // Triangle inequality theorem: sum of any two sides must be greater than the third side
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }

        /// <summary>
        /// Determines the type of triangle based on side lengths
        /// </summary>
        /// <param name="side1">Length of first side</param>
        /// <param name="side2">Length of second side</param>
        /// <param name="side3">Length of third side</param>
        /// <returns>The type of triangle</returns>
        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            // Check if all sides are equal (Equilateral)
            if (Math.Abs(side1 - side2) < 0.001 && Math.Abs(side2 - side3) < 0.001)
            {
                return "Equilateral";
            }
            // Check if two sides are equal (Isosceles)
            else if (Math.Abs(side1 - side2) < 0.001 || Math.Abs(side1 - side3) < 0.001 || Math.Abs(side2 - side3) < 0.001)
            {
                return "Isosceles";
            }
            // No sides are equal (Scalene)
            else
            {
                return "Scalene";
            }
        }
    }
} 