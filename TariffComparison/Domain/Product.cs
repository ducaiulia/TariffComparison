using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComparison.Domain
{
    public abstract class Product
    {
        public string TariffName { get; set; }
        public int AnnualCosts { get; set; }
        public override string ToString()
        {
            //return String.Format("{0}: {1} €/year", TariffName, AnnualCosts);
            return String.Format("{0} | {1} euro/year", TariffName, AnnualCosts);
        }

        protected abstract void ComputeAnnualCosts(int kWh);
    }
}
                                                                    
