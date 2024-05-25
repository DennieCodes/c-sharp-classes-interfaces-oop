namespace CSharpDotNetTutorial.CompositionExample
{
    public class DbMigrator
    {
        private readonly Logger logger;

        public DbMigrator(Logger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            this.logger.Log("We are migrating, blah....");
        }
    }
}

