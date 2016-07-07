using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TariffComparison.Test
{
    [TestClass]
    public class TariffServiceTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), Utils.ArgumentExceptionMessage)]
        public void GetProducts_NegativeKWh()
        {
            //Arrange
            var service = new TariffService();

            //Act
            service.GetProducts(-1);
        }

        [TestMethod]
        public void GetProducts_PositiveKWh()
        {
            //Arrange
            var service = new TariffService();

            //Act
            var products = service.GetProducts(3500);

            //Assert
            Assert.IsNotNull(products);
            Assert.AreEqual(2, products.Count);
            Assert.AreEqual(true, products[0].AnnualCosts < products[1].AnnualCosts);
            Assert.AreEqual(800, products[0].AnnualCosts);
            Assert.AreEqual(830, products[1].AnnualCosts);
            Assert.AreEqual(Utils.ProductToString("Packaged tariff", 800), products[0].ToString());
            Assert.AreEqual(Utils.ProductToString("Basic electricity tariff", 830), products[1].ToString());
        }
    }
}
