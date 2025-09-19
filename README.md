# .NET Core Calculator Demo Project

A simple calculator application built with .NET Core 8.0 featuring basic mathematical operations and comprehensive error handling.

## Features

- **Basic Operations**: Addition (+), Subtraction (-), Multiplication (*), Division (/)
- **Error Handling**: Graceful handling of division by zero and invalid input
- **Interactive Console Interface**: Easy-to-use command line interface
- **Comprehensive Unit Tests**: Full test coverage with xUnit framework

## Project Structure

```
Calculator/
├── Calculator/                 # Main console application
│   ├── Calculator.cs          # Calculator class with core operations
│   └── Program.cs            # Console interface and main program
├── Calculator.Tests/         # Unit test project
│   └── UnitTest1.cs         # Comprehensive unit tests
└── Calculator.sln           # Solution file
```

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later

### Building the Project

```bash
dotnet build
```

### Running the Calculator

```bash
cd Calculator
dotnet run
```

### Running Tests

```bash
dotnet test
```

## Usage

1. Start the application using `dotnet run` in the Calculator directory
2. Enter the first number when prompted
3. Choose an operation: `+`, `-`, `*`, or `/`
4. Enter the second number
5. View the result
6. Type `exit` to quit the application

### Example Session

```
=== .NET Core Calculator ===
Available operations: +, -, *, /
Type 'exit' to quit

Enter first number (or 'exit' to quit): 10
Enter operation (+, -, *, /): +
Enter second number: 5
Result: 10 + 5 = 15

Enter first number (or 'exit' to quit): exit
Goodbye!
```

## Error Handling

The calculator handles various error scenarios:

- **Division by Zero**: Displays appropriate error message
- **Invalid Numbers**: Prompts user to enter valid numbers
- **Invalid Operations**: Prompts user to use supported operations
- **Empty Input**: Handles null or empty input gracefully

## Testing

The project includes comprehensive unit tests covering:

- All basic operations (add, subtract, multiply, divide)
- Edge cases (negative numbers, decimals, zero)
- Error conditions (division by zero)
- Boundary conditions

Run tests with: `dotnet test`

## Development

This project demonstrates:

- Clean separation of concerns (Calculator logic vs. UI)
- Comprehensive error handling
- Unit testing best practices
- Modern C# features (switch expressions, nullable reference types)
- Interactive console application development
