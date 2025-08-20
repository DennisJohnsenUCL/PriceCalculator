namespace PriceCalculator
{
    public record Customer
    {
        public CustomerType CustomerType { get; }

        public Customer(CustomerType customerType)
        {
            CustomerType = customerType;
        }
    }
}
