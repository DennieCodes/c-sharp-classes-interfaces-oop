namespace CSharpDotNetTutorial;

public class Canvas
{
    public void DrawShapes(List<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}
