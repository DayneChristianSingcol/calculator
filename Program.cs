using System;

{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                
                Console.Write("Enter the first integer: ");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                    continue;
                }

                
                Console.Write("Enter the second integer: ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                    continue;
                }

                string? operation;
                while (true) 
                {
                    Console.Write("Choose an operation (+, -, *, /, %, = to exit): ");
                    operation = Console.ReadLine();

                    if (operation == "+" || operation == "-" || operation == "*" ||
                        operation == "/" || operation == "%" || operation == "=")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Operation Used, please try again.");
                    }
                }

                if (operation == "=")
                {
                    Console.WriteLine("Exiting calculator. Goodbye!");
                    break;
                }

               
                var result = Calculator.Calculate(num1, num2, operation);

                if (result != null)
                {
                    Console.WriteLine($"Result: {result}");
                }

                Console.WriteLine(); 
            }
        }
    }
}
