namespace CSharpDotNetTutorial.FactoryPatternExercises.AbstractFactory;
public interface IHotDrinkFactory
{
    IHotDrink Prepare(int amount);
}
