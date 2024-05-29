namespace CSharpDotNetTutorial.CompositionAndExtensibilityExample
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
            this.logger.LogInfo("Installing...");
        }
    }
}

