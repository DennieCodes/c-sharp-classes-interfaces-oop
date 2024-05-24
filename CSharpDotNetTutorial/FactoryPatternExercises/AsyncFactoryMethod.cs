namespace CSharpDotNetTutorial.FactoryPatternExercises;

public class AsyncFactoryMethod
{
    // private constructor
    private AsyncFactoryMethod()
    {

    }

    // private asynchronous initialization
    private async Task<AsyncFactoryMethod> InitAsync()
    {
        await Task.Delay(1000);
        return this;
    }

    // public factory Method
    public static Task<AsyncFactoryMethod> CreateAsync()
    {
        var result = new AsyncFactoryMethod();
        return result.InitAsync();
    }
}

public class AsyncFactoryMethodDemo()
{
    public async void Show()
    {
        AsyncFactoryMethod asyncClass = await AsyncFactoryMethod.CreateAsync();
    }
}