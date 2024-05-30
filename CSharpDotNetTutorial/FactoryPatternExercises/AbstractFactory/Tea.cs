namespace CSharpDotNetTutorial.FactoryPatternExercises.AbstractFactory;
internal class Tea : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("Tea");
    }
}
