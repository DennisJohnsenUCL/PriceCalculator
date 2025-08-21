namespace PriceCalculator
{
    internal class NonProfitPriceCalculatorService : BasePriceCalculatorService
    {
        protected override decimal GetDiscountAmount(decimal orderTotalExclDiscountAmount)
        {
            return orderTotalExclDiscountAmount * 0.20m;
        }
    }
}
