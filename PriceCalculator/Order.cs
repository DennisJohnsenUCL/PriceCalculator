namespace PriceCalculator
{
    public record Order
    {
        public List<CartItem> Items { get; }
    }
}
