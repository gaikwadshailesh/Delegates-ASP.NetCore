# Delegate Demo in ASP.NET Core

This project demonstrates the usage of delegates in C# using an ASP.NET Core Web API. It implements a simple calculator application that showcases different types of delegates and their implementations.

## Features

- Custom delegate implementation
- Usage of built-in delegates (Func and Action)
- Different ways to use delegates:
  - Named methods
  - Anonymous methods
  - Lambda expressions
- REST API endpoints for basic mathematical operations

## Types of Delegates Demonstrated

1. **Custom Delegate**: `MathOperation`
   - Demonstrates how to create and use custom delegates
   - Used for basic mathematical operations

2. **Func Delegate**: `Func<int, int, string>`
   - Shows the usage of built-in generic delegates
   - Used for formatting calculation results

3. **Action Delegate**: `Action<string>`
   - Demonstrates void delegates
   - Used for logging operations

## Project Structure

DelegateDemo/
├── Controllers/
│   └── CalculatorController.cs
├── Models/
│   └── Calculator.cs
├── Program.cs
├── DelegateDemo.csproj
└── DelegateDemo.sln
