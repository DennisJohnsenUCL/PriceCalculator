namespace PriceCalculator
{
    internal class IndividualPriceCalculatorService : BasePriceCalculatorService
    {
        protected override decimal GetDiscountAmount(decimal orderTotalExclDiscountAmount)
        {
            decimal discountAmount = orderTotalExclDiscountAmount switch
            {
                > 10000 => orderTotalExclDiscountAmount * 0.20m,
                > 5000 => orderTotalExclDiscountAmount * 0.15m,
                > 1000 => orderTotalExclDiscountAmount * 0.10m,
                _ => 0
            };

            return discountAmount;
        }
    }
}
