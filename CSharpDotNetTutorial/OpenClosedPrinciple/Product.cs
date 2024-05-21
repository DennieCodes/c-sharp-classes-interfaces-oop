using System.Drawing;

namespace CSharpDotNetTutorial.OpenClosePrinciple;

public class Product
{
    public string Name;
    public Color Color;
    public Size Size;

    public Product(string name, Color color, Size size)
    {
        if (name == null)
        {
            throw new ArgumentNullException(paramName: nameof(name));
        }

        this.Name = name;
        this.Color = color;
        this.Size = size;
    }
}
