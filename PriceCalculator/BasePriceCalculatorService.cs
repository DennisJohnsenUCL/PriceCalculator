using PriceCalculator.Interfaces;
using PriceCalculator.Models;

namespace PriceCalculator
{
    public abstract class BasePriceCalculatorService : IPriceCalculatorService
    {
        public CalculatedPrice CalculatePrice(Customer customer, Order order)
        {
            decimal orderTotalExclDiscountAmount = 0;

            foreach (var item in order.Items)
            {
                orderTotalExclDiscountAmount += item.CalculateItemPrice();
            }

            var discountAmount = GetDiscountAmount(orderTotalExclDiscountAmount);

            decimal orderTotalInclDiscountAmount = orderTotalExclDiscountAmount - discountAmount;

            return new CalculatedPrice(orderTotalExclDiscountAmount, discountAmount, orderTotalInclDiscountAmount);
        }

        protected abstract decimal GetDiscountAmount(decimal orderTotalExclDiscountAmount);
    }
}
