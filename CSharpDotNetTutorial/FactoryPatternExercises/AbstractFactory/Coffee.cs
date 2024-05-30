namespace CSharpDotNetTutorial.FactoryPatternExercises.AbstractFactory;
internal class Coffee : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("Coffee");
    }
}
