namespace CSharpDotNetTutorial.Generics;
public class GenericsDemo
{
    public void Show()
    {
        var numbers = new GenericList<int>();
        numbers.Add(10);

        var dictionary = new GenericDictionary<string, int>();
        dictionary.Add("First", 100);
    }
}
