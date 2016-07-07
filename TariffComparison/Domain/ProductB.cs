using System;

namespace TariffComparison.Domain
{
    public sealed class ProductB: Product
    {
        public ProductB(string name, int kWh)
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
            int extrakWh = kWh - 4000;
            AnnualCosts = 800 + ((extrakWh > 0 ? extrakWh : 0)*30)/100;
        }
    }
}
