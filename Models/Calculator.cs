namespace DelegateDemo.Models;

public class Calculator
{
    // Delegate declaration
    public delegate int MathOperation(int x, int y);
    
    // Func delegate
    public Func<int, int, string> FormatResult = (x, y) => $"Result: {x + y}";
    
    // Action delegate
    public Action<string> LogOperation = message => Console.WriteLine($"Operation performed: {message}");
    
    // Method that uses delegate as parameter
    public int ExecuteOperation(int a, int b, MathOperation operation)
    {
        LogOperation($"Executing operation on {a} and {b}");
        return operation(a, b);
    }
    
    // Methods that can be used with MathOperation delegate
    public static int Add(int x, int y) => x + y;
    public static int Subtract(int x, int y) => x - y;
    public static int Multiply(int x, int y) => x * y;
} 