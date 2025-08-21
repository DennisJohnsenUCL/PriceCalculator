using PriceCalculator.Interfaces;
using PriceCalculator.Models;

namespace PriceCalculator
{
    public abstract class BasePriceCalculatorService : IPriceCalculatorService
    {

        // Den fælles logik er implementeret i base classen og kan anvendes af alle nedarvende klasser
        // (Kan kaldes på alle nedarvende klasser uden at referere til base classen)
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

        // Metoden er abstract og SKAL overrides af nedarvende klasser, som hver kan implementere deres egen rabatstrategi
        protected abstract decimal GetDiscountAmount(decimal orderTotalExclDiscountAmount);
    }
}
