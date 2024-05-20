using System;
namespace CSharpDotNetTutorial;

public class UsePoints
{
    public UsePoints()
    {
        try
        {
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));

            Console.WriteLine("Point is at ({0}. {1})", point.X, point.Y);
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error occured.");
        }
    }
}