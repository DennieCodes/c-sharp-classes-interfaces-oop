namespace CSharpDotNetTutorial.DatabaseExercises;

public class OracleConnection : DbConnection
{
    public OracleConnection(string connection)
        : base(connection)
    {

    }

    public override void Open()
    {
        Console.WriteLine("Open Oracle Database Connection");
    }

    public override void Close()
    {
        Console.WriteLine("Close Oracle Database Connection");
    }
}
