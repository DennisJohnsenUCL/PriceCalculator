namespace PriceCalculator
{
    public record CartItem
    {
        public string ItemName { get; }
        public Decimal UnitPrice { get; }
        public Decimal NoOfUnits { get; }
        public Decimal CalculateItemPrice() { return 0; }

        public CartItem(string itemName, decimal unitPrice, decimal noOfUnits)
        {
            ItemName = itemName;
            UnitPrice = unitPrice;
            NoOfUnits = noOfUnits;
        }
    }
}
