namespace PriceCalculator
{
    internal class NonProfitPriceCalculatorService : BasePriceCalculatorService
    {
        protected override decimal GetDiscountAmount(decimal orderTotalExclDiscountAmount) => orderTotalExclDiscountAmount * 0.20m;
    }
}
