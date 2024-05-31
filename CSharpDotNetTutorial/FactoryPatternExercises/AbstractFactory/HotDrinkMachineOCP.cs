namespace CSharpDotNetTutorial.FactoryPatternExercises.AbstractFactory;
public class HotDrinkMachineOCP
{
    private List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>>();

    public HotDrinkMachineOCP()
    {
        foreach (var t in typeof(HotDrinkMachineOCP).Assembly.GetTypes())
        {
            if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
            {
                var instance = Activator.CreateInstance(t);
                if (instance is IHotDrinkFactory factory)
                {
                    factories.Add(Tuple.Create(
                        t.Name.Replace("Factory", string.Empty),
                        factory
                    ));
                }
            }
        }
    }

    public IHotDrink? MakeDrink()
    {
        Console.WriteLine("Available drinks");
        for (var index = 0; index < factories.Count; index++)
        {
            var tuple = factories[index];
            Console.WriteLine($"{index}: {tuple.Item1}");
        }

        while (true)
        {
            string? s;
            if ((s = Console.ReadLine()) != null
                && int.TryParse(s, out int i)
                && i >= 0
                && i < factories.Count)
            {
                Console.WriteLine("Specify amount: ");
                s = Console.ReadLine();

                if (s != null
                    && int.TryParse(s, out int amount)
                    && amount > 0)
                {
                    return factories[i].Item2.Prepare(amount);
                }
            }
            Console.WriteLine("Incorrect input, try again!");
        }
    }
}
