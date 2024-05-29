namespace CSharpDotNetTutorial.CompositionAndExtensibilityExample;

public enum FileType
{
    error, info
}

public class FileLogger : ILogger
{
    private string path;

    public FileLogger(string path)
    {
        this.path = path;
    }

    public void LogError(string message)
    {
        Log(message, FileType.error);
    }

    public void LogInfo(string message)
    {
        Log(message, FileType.info);
    }

    private void Log(string message, FileType type)
    {
        using (var streamWriter = new StreamWriter(this.path, true))
        {
            streamWriter.WriteLine(type + ": " + message);
        }
    }
}
