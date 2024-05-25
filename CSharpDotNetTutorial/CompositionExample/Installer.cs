namespace CSharpDotNetTutorial.CompositionExample
{
    public class Installer
    {
        public Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }

        public void Install()
        {
            this.logger.Log("Installing...");
        }
    }
}

