using BookCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookCalculatorTests
{
    [TestClass]
    public class HardcoverTests
    {
        [TestMethod]
        public void should_return_cost_of_manufacturing()
        {
            Hardcover sut = new Hardcover("Test", "Test", 100);

            decimal result = sut.GetCostOfManufacturing();
            
            Assert.AreEqual(8m, result);
        }
    }
}
