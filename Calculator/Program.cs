using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            
            Console.WriteLine("=== .NET Core Calculator ===");
            Console.WriteLine("Available operations: +, -, *, /");
            Console.WriteLine("Type 'exit' to quit\n");

            while (true)
            {
                try
                {
                    Console.Write("Enter first number (or 'exit' to quit): ");
                    string? input = Console.ReadLine();
                    
                    if (string.IsNullOrEmpty(input) || input.ToLower() == "exit")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }

                    if (!double.TryParse(input, out double firstNumber))
                    {
                        Console.WriteLine("Invalid number. Please try again.\n");
                        continue;
                    }

                    Console.Write("Enter operation (+, -, *, /): ");
                    string? operation = Console.ReadLine();

                    if (string.IsNullOrEmpty(operation) || 
                        (operation != "+" && operation != "-" && operation != "*" && operation != "/"))
                    {
                        Console.WriteLine("Invalid operation. Please use +, -, *, or /.\n");
                        continue;
                    }

                    Console.Write("Enter second number: ");
                    string? secondInput = Console.ReadLine();

                    if (!double.TryParse(secondInput, out double secondNumber))
                    {
                        Console.WriteLine("Invalid number. Please try again.\n");
                        continue;
                    }

                    double result = operation switch
                    {
                        "+" => calculator.Add(firstNumber, secondNumber),
                        "-" => calculator.Subtract(firstNumber, secondNumber),
                        "*" => calculator.Multiply(firstNumber, secondNumber),
                        "/" => calculator.Divide(firstNumber, secondNumber),
                        _ => throw new InvalidOperationException("Unsupported operation")
                    };

                    Console.WriteLine($"Result: {firstNumber} {operation} {secondNumber} = {result}\n");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}\n");
                }
            }
        }
    }
}
