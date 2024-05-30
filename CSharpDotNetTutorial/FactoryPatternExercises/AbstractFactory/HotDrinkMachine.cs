namespace CSharpDotNetTutorial.FactoryPatternExercises.AbstractFactory;
public class HotDrinkMachine
{
    public enum AvailableDrink
    {
        Coffee, Tea
    }

    private Dictionary<AvailableDrink, IHotDrinkFactory> factories =
        new Dictionary<AvailableDrink, IHotDrinkFactory>();

    public HotDrinkMachine()
    {
        foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
        {
            var typeName = "CSharpDotNetTutorial.FactoryPatternExercises.AbstractFactory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory";
            var type = Type.GetType(typeName);
            if (type != null)
            {
                var instance = Activator.CreateInstance(type);
                if (instance is IHotDrinkFactory factory)
                {
                    factories.Add(drink, factory);
                }
            }
        }
    }

    public IHotDrink MakeDrink(AvailableDrink drink, int amount)
    {
        return factories[drink].Prepare(amount);
    }
}
