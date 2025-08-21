namespace PriceCalculator.Models
{
    public record CalculatedPrice
    {
        public decimal OrderTotalExclDiscountAmount { get; }
        public decimal DiscountAmount { get; }
        public decimal OrderTotalInclDiscountAmount { get; }

        public CalculatedPrice(decimal orderTotalExclDiscountAmount, decimal discountAmount, decimal orderTotalInclDiscountAmount)
        {
            OrderTotalExclDiscountAmount = orderTotalExclDiscountAmount;
            DiscountAmount = discountAmount;
            OrderTotalInclDiscountAmount = orderTotalInclDiscountAmount;
        }
    }
}
