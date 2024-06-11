using CSharpDotNetTutorial.FactoryPatternExercises.ObjectTrackingAndBulkReplacement;

namespace CSharpDotNetTutorial.FactoryPatternExercises.PatternDemo
{
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

