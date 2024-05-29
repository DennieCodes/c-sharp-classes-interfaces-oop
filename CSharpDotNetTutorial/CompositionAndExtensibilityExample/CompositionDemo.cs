namespace CSharpDotNetTutorial.CompositionAndExtensibilityExample;
public class CompositionDemo
{
    public static void Show()
    {
        var dbMigrator = new DbMigrator(new FileLogger("c:\\projects\filePath.txt"));

        // Next two lines are from the composition example
        //var logger = new Logger();
        //var installer = new Installer(logger);
        //dbMigrator.Migrate();
        //installer.Install();

        dbMigrator.Migrate();
    }
}
