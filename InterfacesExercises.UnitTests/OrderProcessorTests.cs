using CSharpDotNetTutorial.InterfacesExercises;

namespace InterfacesExercises.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        [TestMethod]
        public void Processor_OrderIsAlreadyShipped_ThrowsAnException()
        {
            // ARRANGE
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            // ACT
            try
            {
                orderProcessor.Process(order);
                Assert.Fail("No exception was thrown");
            }
            catch (InvalidOperationException)
            {
                // ASSERT
            }
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            // ARRANGE
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.isShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }
}