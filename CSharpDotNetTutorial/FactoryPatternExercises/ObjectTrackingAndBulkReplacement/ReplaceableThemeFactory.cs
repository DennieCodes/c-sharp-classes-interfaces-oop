using CSharpDotNetTutorial.FactoryPatternExercises.PatternDemo;

namespace CSharpDotNetTutorial.FactoryPatternExercises.ObjectTrackingAndBulkReplacement;

// Another level of indirection is after you've given out a ref
// To make them replaceable, you can change the underlying object.
public class ReplaceableThemeFactory
{
    // So, in simple terms, this line of code is creating a list that can hold weak references to theme references.
    private readonly List<WeakReference<Ref<ITheme>>> themes = new();
    private ITheme createThemeImpl(bool dark)
    {
        return dark ? new DarkTheme() : new LightTheme();
    }
    public Ref<ITheme> CreateTheme(bool dark)
    {
        var r = new Ref<ITheme>(createThemeImpl(dark));
        themes.Add(new(r));
        return r;
    }

    public void ReplaceTheme(bool dark)
    {
        foreach (var wr in themes)
        {
            // TryGetTarget(out var reference) is a method on the weak reference. It tries to get the object that the weak reference refers to.If the object has not been collected by the garbage collector, the method returns true and sets the out parameter(reference in this case) to the object.If the object has been collected, the method returns false and sets the out parameter to null.
            if (wr.TryGetTarget(out var reference))
            {
                reference.Value = createThemeImpl(dark);
            }
        }
    }
}
