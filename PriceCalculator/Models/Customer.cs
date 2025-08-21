using PriceCalculator.Enums;

namespace PriceCalculator.Models
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
