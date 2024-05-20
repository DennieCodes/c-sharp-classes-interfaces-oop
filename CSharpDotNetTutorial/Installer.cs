using System;
namespace CSharpDotNetTutorial
{
	public class Installer
	{
        public Logger _logger;

        public Installer(Logger logger)
		{
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("Installing...");
        }
    }
}

