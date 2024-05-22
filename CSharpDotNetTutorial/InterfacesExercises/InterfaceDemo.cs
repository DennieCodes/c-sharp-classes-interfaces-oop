namespace CSharpDotNetTutorial.InterfacesExercises;

public class InterfaceDemo
{
    public void Execute()
    {
        var orderProcessor = new OrderProcessor(new ShippingCalculator());
        var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
        orderProcessor.Process(order);
    }
}
