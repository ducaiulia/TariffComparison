using System;

namespace TariffComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            var service = new TariffService();
            var products = service.GetProducts(3500);
            Console.WriteLine("Tariff name | Annual Costs");
            products.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
