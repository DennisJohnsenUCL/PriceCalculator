using PriceCalculator.Models;

namespace PriceCalculator.Interfaces
{
    public interface IPriceCalculatorService
    {
        CalculatedPrice CalculatePrice(Customer customer, Order order);
    }
}
