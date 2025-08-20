namespace PriceCalculator
{
    public class CartItem
    {
        public string ItemName { get; }
        public Decimal UnitPrice { get; }
        public Decimal NoOfUnits { get; }
        public Decimal CalculateItemPrice() { return 0; }
    }
}
