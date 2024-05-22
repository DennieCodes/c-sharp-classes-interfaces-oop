using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfaceExercises.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsException()
        {
            var orderProcessor = new OrderProcessor();
        }
    }
}
