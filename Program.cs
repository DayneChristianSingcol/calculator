using System;

class Program
{
    // Display the calculator to the user
    public static void DisplayCalculator()
    {
        while (true)
        {
            // Input for first number
            Console.WriteLine("Enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }

            // Input for second number
            Console.WriteLine("Enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }

            // Input for operation
            Console.WriteLine("Enter operation (+, -, *, /, %, = to exit): ");
            string operation = Console.ReadLine().Trim();

            // Call Calculate method to perform the operation
            double? result = Calculator.Calculate(num1, num2, operation);

            // Display result if valid
            if (result.HasValue)
            {
                Console.WriteLine($"Result: {result.Value}");
            }
        }
    }

    // Main method to start the program
    public static void Main(string[] args)
    {
        DisplayCalculator();
    }
}
    
