using System;
namespace CSharpDotNetTutorial
{
	public class Vehicle
	{
		private string Registration;

		public Vehicle(string registration)
		{
			this.Registration = registration;
		}

		public string GetRegistration()
		{
			return this.Registration;
		}
	}
}

