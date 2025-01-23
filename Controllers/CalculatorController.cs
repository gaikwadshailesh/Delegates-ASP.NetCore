using Microsoft.AspNetCore.Mvc;
using DelegateDemo.Models;

namespace DelegateDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly Calculator _calculator;

    public CalculatorController()
    {
        _calculator = new Calculator();
    }

    [HttpGet("add/{x}/{y}")]
    public IActionResult Add(int x, int y)
    {
        // Using custom delegate
        int result = _calculator.ExecuteOperation(x, y, Calculator.Add);
        
        // Using Func delegate
        string formattedResult = _calculator.FormatResult(x, y);
        
        return Ok(new { 
            Result = result,
            FormattedResult = formattedResult 
        });
    }

    [HttpGet("subtract/{x}/{y}")]
    public IActionResult Subtract(int x, int y)
    {
        int result = _calculator.ExecuteOperation(x, y, Calculator.Subtract);
        return Ok(new { Result = result });
    }

    [HttpGet("multiply/{x}/{y}")]
    public IActionResult Multiply(int x, int y)
    {
        // Using anonymous method with delegate
        Calculator.MathOperation multiply = (a, b) => a * b;
        int result = _calculator.ExecuteOperation(x, y, multiply);
        return Ok(new { Result = result });
    }
} 