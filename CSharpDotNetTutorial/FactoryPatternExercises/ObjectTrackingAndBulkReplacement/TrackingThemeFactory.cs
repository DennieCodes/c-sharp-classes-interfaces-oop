using System.Text;

using CSharpDotNetTutorial.FactoryPatternExercises.PatternDemo;

namespace CSharpDotNetTutorial.FactoryPatternExercises.ObjectTrackingAndBulkReplacement;

// This is a tracker for all of the objects created by the factory
// We use a weakreference so as not to extend the lifetime of the constructed objects.
// Otherwise they will live as long as the factory and mess with garbage collection
public class TrackingThemeFactory
{
    private readonly List<WeakReference<ITheme>> themes = new();

    public ITheme CreateTheme(bool dark)
    {
        ITheme theme = dark ? new DarkTheme() : new LightTheme();
        themes.Add(new WeakReference<ITheme>(theme));
        return theme;
    }

    public string Info
    {
        get
        {
            var sb = new StringBuilder();
            foreach (var reference in themes)
            {
                if (reference.TryGetTarget(out var theme))
                {
                    bool dark = theme is DarkTheme;
                    sb.Append(dark ? "Dark" : "Light")
                        .AppendLine(" theme");
                }
            }
            return sb.ToString();
        }
    }
}
