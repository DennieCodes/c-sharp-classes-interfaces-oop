namespace CSharpDotNetTutorial.FactoryPatternExercises;

public class PointFactoryPatternDemo
{
    public static void Show()
    {
        var point = PointFactoryMethod.NewPolarPoint(1.0, Math.PI / 2);
        Console.WriteLine("Point Result");
        Console.WriteLine(point.Result());
    }
}
