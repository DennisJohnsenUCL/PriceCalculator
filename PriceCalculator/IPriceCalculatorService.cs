namespace PriceCalculator
{
    public interface IPriceCalculatorService
    {
        CalculatedPrice CalculatePrice(Customer customer, Order order);
    }
}
