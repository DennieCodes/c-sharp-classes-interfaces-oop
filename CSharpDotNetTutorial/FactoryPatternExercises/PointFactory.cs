namespace CSharpDotNetTutorial.FactoryPatternExercises;

public static class PointFactory
{
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
}

public class PointFactoryDemo()
{
    public static void Show()
    {
        var point = PointFactory.NewCartesianPoint(1.75, 5);
        Console.WriteLine(point.Result());
    }
}