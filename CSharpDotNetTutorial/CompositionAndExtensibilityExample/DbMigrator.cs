namespace CSharpDotNetTutorial.CompositionAndExtensibilityExample
{
    public class DbMigrator
    {
        private readonly ILogger logger;

        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            this.logger.LogInfo("Migration started at {0}" + DateTime.Now);

            this.logger.LogInfo("Migration finished at {0}" + DateTime.Now);
        }
    }
}

