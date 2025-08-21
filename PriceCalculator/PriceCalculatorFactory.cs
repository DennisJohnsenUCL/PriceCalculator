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
                _ => throw new NotImplementedException()
            };

            return calculator;
        }
    }
}
