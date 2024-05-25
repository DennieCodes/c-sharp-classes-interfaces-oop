using CSharpDotNetTutorial.FactoryPatternExercises.ObjectTrackingAndBulkReplacement;

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

    public class IThemeDemo
    {
        public static void Show()
        {
            var factory = new TrackingThemeFactory();
            var theme1 = factory.CreateTheme(true);
            var theme2 = factory.CreateTheme(false);
            Console.WriteLine(factory.Info);

            var factory2 = new ReplaceableThemeFactory();
            var magicTheme = factory2.CreateTheme(true);
            Console.WriteLine(magicTheme.Value.BgColor);
            factory2.ReplaceTheme(false);
            Console.WriteLine(magicTheme.Value.BgColor);
        }
    }

}

