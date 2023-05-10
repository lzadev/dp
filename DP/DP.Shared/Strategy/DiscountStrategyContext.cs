using DP.Shared.Models;

namespace DP.Shared.Strategy
{
    public static class DiscountStrategyContext
    {
        public static IDiscountStrategy GetStrategy(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.REGULAR:
                    return new DiscountStrategyRegularCustomer();
                case CustomerType.PREMIUM:
                    return new DiscountStrategyPremiumCustomer();
                default:
                    throw new InvalidOperationException("Invalid Customer type provided");
            }
        }
    }
}
 