using CSharpDotNetTutorial.SqueakyClean;

namespace CSharpDotNetTutorial.StringBuilderExercise;
public static class IdentifierDemo
{
    public static void Show()
    {
        var result = Identifier.Clean("MyΟβιεγτFinder");
        Console.WriteLine(result);
    }
}
