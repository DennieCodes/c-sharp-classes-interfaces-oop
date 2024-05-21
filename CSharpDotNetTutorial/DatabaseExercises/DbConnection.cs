namespace CSharpDotNetTutorial.DatabaseExercises;

public class DbConnection
{
    public string Connection;
    public TimeSpan TimeOut { get; set; }

    public DbConnection(string connection)
    {
        this.Connection = connection ?? throw new ArgumentException(nameof(connection));
    }

    public virtual void Open()
    {

    }

    public virtual void Close()
    {

    }
}
