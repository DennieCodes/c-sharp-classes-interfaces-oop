namespace CSharpDotNetTutorial.FactoryPatternExercises;

public enum CoordinateSystem
{
    Cartesian,
    Polar
}

// Gives an example of why a Factory pattern would be beneficial
public class Point
{
    private double x, y;

    // Initializes a point from either Cartesian or Polar
    public Point(double a, double b,
        CoordinateSystem system = CoordinateSystem.Cartesian)
    {
        switch (system)
        {
            case CoordinateSystem.Cartesian:
                this.x = a;
                this.y = b;
                break;
            case CoordinateSystem.Polar:
                x = a * Math.Cos(b);
                y = b * Math.Sin(b);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(system), system, null);
        }
    }
}
