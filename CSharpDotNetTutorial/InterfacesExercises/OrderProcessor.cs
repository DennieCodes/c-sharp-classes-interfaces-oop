namespace CSharpDotNetTutorial.InterfacesExercises;

public class OrderProcessor
{
    private readonly IShippingCalculator shippingCalculator;

    public OrderProcessor(IShippingCalculator shippingCalculator)
    {
        this.shippingCalculator = shippingCalculator;
    }

    public void Process(Order order)
    {
        if (order.isShipped)
        {
            throw new InvalidOperationException("The order is already processed.");
        }

        order.Shipment = new Shipment
        {
            Cost = this.shippingCalculator.CalculateShipping(order),
            ShippingDate = DateTime.Today.AddDays(1)
        };
    }
}
