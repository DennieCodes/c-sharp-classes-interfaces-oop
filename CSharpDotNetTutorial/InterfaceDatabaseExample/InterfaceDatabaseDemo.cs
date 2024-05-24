namespace CSharpDotNetTutorial.InterfaceDatabaseExample;

public class InterfaceDatabaseDemo
{
    private IDatabaseConnection connection;

    public InterfaceDatabaseDemo(IDatabaseConnection connection)
    {
        this.connection = connection;
    }

    public void Interact()
    {
        this.connection.Connect();
        // Do something to the database
        this.connection.Disconnect();
    }
}
