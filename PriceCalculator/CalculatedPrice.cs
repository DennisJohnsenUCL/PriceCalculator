namespace PriceCalculator
{
    public record CalculatedPrice
    {
        public Decimal OrderTotalExclDiscountAmount { get; }
        public Decimal DiscountAmount { get; }
        public Decimal OrderTotalInclDiscountAmount { get; }

        public CalculatedPrice(decimal orderTotalExclDiscountAmount, decimal discountAmount, decimal orderTotalInclDiscountAmount)
        {
            OrderTotalExclDiscountAmount = orderTotalExclDiscountAmount;
            DiscountAmount = discountAmount;
            OrderTotalInclDiscountAmount = orderTotalInclDiscountAmount;
        }
    }
}
