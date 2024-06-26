﻿namespace CSharpDotNetTutorial.FactoryPatternExercises;

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
    // public for PointFactory demo.
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
