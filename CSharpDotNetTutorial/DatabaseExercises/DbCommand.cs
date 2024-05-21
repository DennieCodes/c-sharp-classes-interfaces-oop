namespace CSharpDotNetTutorial.DatabaseExercises;

public class DbCommand
{
    private string command;
    private DbConnection connection;

    public DbCommand(DbConnection connection, string command)
    {
        this.connection = connection ?? throw new ArgumentException(nameof(DbConnection));
        this.command = command ?? throw new ArgumentException(nameof(command));
    }

    public void Execute()
    {
        connection.Open();
        Console.WriteLine($"Executing instructions: {this.command}");
        connection.Close();
    }
}
