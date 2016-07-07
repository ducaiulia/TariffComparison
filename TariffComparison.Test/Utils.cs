using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComparison.Test
{
    static class Utils
    {
        public const string ArgumentNullExceptionMessage = "Tariff name is null or empty.";
        public const string ArgumentExceptionMessage = "KWh must be a positive number.";

        public static string ProductToString(string tariffName, int costs)
        {
            return String.Format("{0} | {1} euro/year", tariffName, costs);
        }
    }
}
