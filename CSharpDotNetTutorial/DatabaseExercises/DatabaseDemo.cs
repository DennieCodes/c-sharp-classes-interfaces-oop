namespace CSharpDotNetTutorial.DatabaseExercises;

public class DatabaseDemo
{
    public void Run()
    {
        var instruction = "Search the database for entries that begin with an H";
        var SqlDatabase = new SqlConnection("Some connection string");
        var SqlFunction = new DbCommand(SqlDatabase, instruction);
        SqlFunction.Execute();

        var newInstruction = "Searching for the Oracle at Delphi";
        var OracleDatabase = new OracleConnection("Oracle Connection String");
        var OracleFunction = new DbCommand(OracleDatabase, newInstruction);
        OracleFunction.Execute();
    }
}
