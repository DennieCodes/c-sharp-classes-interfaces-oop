using System;
namespace CSharpDotNetTutorial;

public class UseParams
{
    public UseParams()
    {
        var calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Add(1, 2, 3));
        Console.WriteLine(calculator.Add(1, 2, 3, 4));
    }
}