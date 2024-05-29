namespace CSharpDotNetTutorial.CompositionAndExtensibilityExample;

public class Logger : ILogger
{
    public void LogError(string message)
    {
        Console.WriteLine(message);
    }

    public void LogInfo(string message)
    {
        Console.WriteLine(message);
    }
}