namespace CSharpDotNetTutorial.FactoryPatternExercises.AbstractFactory;
internal class CoffeeFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        Console.WriteLine($"Grind beans, pour {amount} ml of water, brew, enjoy");
        return new Coffee();
    }
}
