namespace CSharpDotNetTutorial.DatabaseExercises;

public class SqlConnection : DbConnection
{
    public SqlConnection(string connection)
        : base(connection)
    {
        // Perform specific SQL constructor initialization
    }

    public override void Open()
    {
        Console.WriteLine("Opening SQL connection");
    }

    public override void Close()
    {
        Console.WriteLine("Closing SQL connection");
    }
}
