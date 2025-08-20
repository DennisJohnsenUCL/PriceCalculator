namespace PriceCalculator
{
    public record Order
    {
        public List<CartItem> Items { get; }

        public Order(List<CartItem> items)
        {
            Items = items;
        }
    }
}
