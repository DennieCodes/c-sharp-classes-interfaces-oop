namespace CSharpDotNetTutorial.FactoryPatternExercises;

public class PointFactoryMethod
{
    // This factory pattern will call the constructor with the appropriate initialization
    public static PointFactoryMethod NewCartesianPoint(double x, double y)
    {
        return new PointFactoryMethod(x, y);
    }

    // This factory pattern will call the constructor with the appropriate initialization
    public static PointFactoryMethod NewPolarPoint(double rho, double theta)
    {
        return new PointFactoryMethod(
            rho * Math.Cos(theta),
            rho * Math.Sin(theta));
    }

    public double x, y;

    // Note PointFactoryMethod constructor was originally private but only made
    // public for PointFactory.
    public PointFactoryMethod(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public string Result()
    {
        return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
    }
}

public class PointFactoryPatternDemo
{
    public static void Show()
    {
        var point = PointFactoryMethod.NewPolarPoint(1.0, Math.PI / 2);
        Console.WriteLine("Point Result");
        Console.WriteLine(point.Result());
    }
}
