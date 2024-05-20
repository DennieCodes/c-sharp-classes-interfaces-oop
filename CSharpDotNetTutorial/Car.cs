using System;
namespace CSharpDotNetTutorial
{
	public class Car : Vehicle
	{
		public string Make { get; }
		public string Model { get; }

		public Car(string make, string model, string registration)
			: base(registration)
		{
			this.Make = make;
			this.Model = model;
		}
	}
}

