namespace CSharpDotNetTutorial;

public class MethodOverrideExample
{
    public void Shapes()
    {
        var shapes = new List<Shape>();
        shapes.Add(new Circle());
        shapes.Add(new Rectangle());

        var canvas = new Canvas();
        canvas.DrawShapes(shapes);
    }
}
