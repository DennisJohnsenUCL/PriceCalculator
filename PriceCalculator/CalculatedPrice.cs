namespace PriceCalculator
{
    internal record CalculatedPrice
    {
        public Decimal OrderTotalExclDiscountAmount { get; }
        public Decimal DiscountAmount { get; }
        public Decimal OrderTotalInclDiscountAmount { get; }

    }
}
