namespace CSharpDotNetTutorial.FactoryPatternExercises;

public class InnerPointFactoryMethod
{
    // This factory pattern will call the constructor with the appropriate initialization
    public static InnerPointFactoryMethod NewCartesianPoint(double x, double y)
    {
        return new InnerPointFactoryMethod(x, y);
    }

    // This factory pattern will call the constructor with the appropriate initialization
    public static InnerPointFactoryMethod NewPolarPoint(double rho, double theta)
    {
        return new InnerPointFactoryMethod(
            rho * Math.Cos(theta),
            rho * Math.Sin(theta));
    }

    public double x, y;

    // Note: InnerPointFactoryMethod is private unlike PointFactoryMethod
    // since we are using an inner factory
    private InnerPointFactoryMethod(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public string Result()
    {
        return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
    }

    public static InnerPointFactoryMethod Origin = new InnerPointFactoryMethod(0, 0);

    // The inner Factory is able to access the private constructor for InnerPointFactoryMethod
    // whereas the previous PointFactoryMethod necessitated a public constructor.
    public static class Factory
    {
        public static InnerPointFactoryMethod NewCartesianPoint(double x, double y)
        {
            return new InnerPointFactoryMethod(x, y);
        }

        // This factory pattern will call the constructor with the appropriate initialization
        public static InnerPointFactoryMethod NewPolarPoint(double rho, double theta)
        {
            return new InnerPointFactoryMethod(
                rho * Math.Cos(theta),
                rho * Math.Sin(theta));
        }
    }
}

public class InnerPointFactoryMethodDemo
{
    public static void Show()
    {
        var point = InnerPointFactoryMethod.Factory.NewPolarPoint(1.0, Math.PI / 2);
        Console.WriteLine(point.Result());
    }
}