using System.Collections.Generic;
using System.Linq;
using TariffComparison.Domain;

namespace TariffComparison
{
    public class TariffService
    {
        public List<Product> GetProducts(int kWh)
        {
            var products = new List<Product>
            {
                new ProductA("Basic electricity tariff", kWh),
                new ProductB("Packaged tariff", kWh)
            };
            return products.OrderBy(p => p.AnnualCosts).ToList();
        }
    }
}
