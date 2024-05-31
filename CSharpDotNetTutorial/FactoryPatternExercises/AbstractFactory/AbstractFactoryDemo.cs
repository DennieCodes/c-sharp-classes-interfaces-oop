namespace CSharpDotNetTutorial.FactoryPatternExercises.AbstractFactory;
public class AbstractFactoryDemo
{
    public static void Show()
    {
        //var machine = new HotDrinkMachine();
        //var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 100);
        //drink.Consume();

        var machine = new HotDrinkMachineOCP();
        var drink = machine.MakeDrink();
        drink?.Consume();
    }
}
