using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TariffComparison.Domain;

namespace TariffComparison.Test
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), Utils.ArgumentNullExceptionMessage)]
        public void ProductA_NullTariffName()
        {
            var product = new ProductA(null, 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), Utils.ArgumentNullExceptionMessage)]
        public void ProductA_EmptyTariffName()
        {
            var product = new ProductA(String.Empty, 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), Utils.ArgumentExceptionMessage)]
        public void ProductA_NegativeKWh()
        {
            var product = new ProductA("Tariff name", -1);
        }

        [TestMethod]
        public void ProductA_ZeroKWh()
        {
            //Arrange
            var product = new ProductA("Basic electricity tariff", 0);

            //Assert
            Assert.AreEqual(60, product.AnnualCosts);
        }

        [TestMethod]
        public void ProductA_PositiveKWh()
        {
            //Arrange
            var product = new ProductA("Basic electricity tariff", 6000);

            //Assert
            Assert.AreEqual(1380, product.AnnualCosts);
        }

        [TestMethod]
        public void ProductA_ToString()
        {
            //Arrange
            var product = new ProductA("Basic electricity tariff", 4500);
            
            //Assert
            Assert.AreEqual(Utils.ProductToString("Basic electricity tariff", 1050), product.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), Utils.ArgumentNullExceptionMessage)]
        public void ProductB_NullTariffName()
        {
            var product = new ProductB(null, 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), Utils.ArgumentNullExceptionMessage)]
        public void ProductB_EmptyTariffName()
        {
            var product = new ProductB(String.Empty, 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), Utils.ArgumentExceptionMessage)]
        public void ProductB_NegativeKWh()
        {
            var product = new ProductB("Tariff name", -1);
        }

        [TestMethod]
        public void ProductB_ZeroKWh()
        {
            var product = new ProductB("Packaged tariff", 0);

            Assert.AreEqual(800, product.AnnualCosts);
        }

        [TestMethod]
        public void ProductB_Below4000KWh()
        {
            //Arrange
            var product = new ProductB("Packaged tariff", 3500);

            //Assert
            Assert.AreEqual(800, product.AnnualCosts);
        }

        [TestMethod]
        public void ProductB_Over4000KWh()
        {
            var product = new ProductB("Packaged tariff", 6000);

            Assert.AreEqual(1400, product.AnnualCosts);
        }

        [TestMethod]
        public void ProductB_4000KWh()
        {
            //Arrange
            var product = new ProductB("Packaged tariff", 4000);

            //Assert
            Assert.AreEqual(800, product.AnnualCosts);
        }

        [TestMethod]
        public void ProductB_ToString()
        {
            //Arrange
            var product = new ProductB("Packaged tariff", 4500);

            //Assert
            Assert.AreEqual(Utils.ProductToString("Packaged tariff", 950), product.ToString());
        }
    }
}
