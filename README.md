# Grade Calculator

A simple C# console application that converts numerical grades to letter grades.

## Grade Scale

- 90 and above: A
- 80-89: B
- 70-79: C
- 60-69: D
- Below 60: F

## How to Run

### Prerequisites
- .NET 8.0 SDK or later

### Building and Running

1. Open a terminal/command prompt in the project directory
2. Build the project:
   ```
   dotnet build
   ```
3. Run the application:
   ```
   dotnet run
   ```

### Usage

1. The program will prompt you to enter a numerical grade between 0 and 100
2. Enter a valid number and press Enter
3. The program will display the corresponding letter grade
4. You can continue entering grades or type "exit" or "quit" to close the program

### Example Output

```
=== Grade Calculator ===
This program converts numerical grades to letter grades.

Enter a numerical grade (0-100): 85
Numerical Grade: 85
Letter Grade: B

Enter a numerical grade (0-100): 92
Numerical Grade: 92
Letter Grade: A

Enter a numerical grade (0-100): 55
Numerical Grade: 55
Letter Grade: F

Enter a numerical grade (0-100): exit
Thank you for using the Grade Calculator!
```

## Features

- Input validation for numerical grades
- Error handling for invalid inputs
- Support for decimal grades
- Continuous operation until user chooses to exit
- Clear and user-friendly interface 