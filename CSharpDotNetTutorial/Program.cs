using System;
using CSharpDotNetTutorial;

namespace Classes;

class Program
{
    static void Main()
    {
        TextShape text = new TextShape();
        Shape shape = text;

        text.Width = 200;
        shape.Width = 100;

        Console.WriteLine(text.Width);
    }

}