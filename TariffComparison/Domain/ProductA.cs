using System;

namespace TariffComparison.Domain
{
    public sealed class ProductA: Product
    {
        public ProductA(string name, int kWh)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name), "Tariff name is null or empty.");
            if (kWh < 0)
                throw new ArgumentException("KWh must be a positive number.");

            TariffName = name;
            ComputeAnnualCosts(kWh);
        }

        protected override void ComputeAnnualCosts(int kWh)
        {
            AnnualCosts = 5 * 12 + (kWh * 22) / 100;
        }
    }
}
