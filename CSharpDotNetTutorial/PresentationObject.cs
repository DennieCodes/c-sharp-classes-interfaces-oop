using System;
namespace CSharpDotNetTutorial;

public class PresentationObject
{
    public int Width { get; set; }
    public int Height { get; set; }

    public PresentationObject()
    {
    }

    public void Copy()
    {
        Console.WriteLine("Object copied to clipboard.");
    }

    public void Duplicate()
    {
        Console.WriteLine("Object was duplicated.");
    }
}