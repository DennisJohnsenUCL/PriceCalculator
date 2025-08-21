namespace PriceCalculator
{
    internal class OrganizationPriceCalculatorService : BasePriceCalculatorService
    {
        protected override decimal GetDiscountAmount(decimal orderTotalExclDiscountAmount)
        {
            decimal discountAmount = orderTotalExclDiscountAmount switch
            {
                > 100000 => orderTotalExclDiscountAmount * 0.30m,
                > 75000 => orderTotalExclDiscountAmount * 0.25m,
                > 50000 => orderTotalExclDiscountAmount * 0.20m,
                > 10000 => orderTotalExclDiscountAmount * 0.15m,
                _ => 0
            };

            return discountAmount;
        }
    }
}
