using PriceCalculator.Enums;
using PriceCalculator.Interfaces;
using PriceCalculator.Models;

namespace PriceCalculator
{
    internal class PriceCalculatorFactory
    {
        public PriceCalculatorFactory() { }

        public IPriceCalculatorService GetPriceCalculator(Customer customer)
        {
            IPriceCalculatorService calculator = customer.CustomerType switch
            {
                CustomerType.Individual => new IndividualPriceCalculatorService(),
                CustomerType.Organization => new OrganizationPriceCalculatorService(),
                CustomerType.NonProfit => new NonProfitPriceCalculatorService(),
                _ => throw new NotImplementedException($"No discount calculator found for customer type {nameof(customer.CustomerType)}")
            };

            return calculator;
        }
    }
}
