namespace CSharpDotNetTutorial.Generics;
public static class GenericsDemo
{
    public static void Show()
    {
        var numbers = new GenericList<int>();
        numbers.Add(10);

        var dictionary = new GenericDictionary<string, int>();
        dictionary.Add("First", 100);

        var number = new Nullable<int>(5);
        Console.WriteLine("Has Value" + number.HasValue);
        Console.WriteLine("Value: " + number.Value);
    }
}
