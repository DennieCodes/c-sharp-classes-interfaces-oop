namespace CSharpDotNetTutorial.FactoryPatternExercises.PatternDemo
{
    public interface ITheme
    {
        string TextColor { get; }
        string BgColor { get; }
    }

    class LightTheme : ITheme
    {
        string ITheme.TextColor => "black";
        string ITheme.BgColor => "white";
    }

    class DarkTheme : ITheme
    {
        string ITheme.TextColor => "white";
        string ITheme.BgColor => "black";
    }

    // Usage example
    // Ref<string> refString = new Ref<string>("Hello, world!");
    // Console.WriteLine(refString.Value);  // Outputs: Hello, world!
    public class Ref<T> where T : class
    {
        public T Value;

        public Ref(T value)
        {
            this.Value = value;
        }
    }
}

