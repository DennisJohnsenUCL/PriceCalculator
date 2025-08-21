namespace PriceCalculator.Models
{
    public record CartItem
    {
        public string ItemName { get; }
        public decimal UnitPrice { get; }
        public decimal NoOfUnits { get; }

        public CartItem(string itemName, decimal unitPrice, decimal noOfUnits)
        {
            ItemName = itemName;
            UnitPrice = unitPrice;
            NoOfUnits = noOfUnits;
        }

        public decimal CalculateItemPrice()
        {
            return UnitPrice * NoOfUnits;
        }
    }
}
