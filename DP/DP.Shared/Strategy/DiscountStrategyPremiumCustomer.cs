using DP.Shared.Models;

namespace DP.Shared.Strategy
{
    public class DiscountStrategyPremiumCustomer : IDiscountStrategy
    {
        public double Calculate(List<Product> products)
        {
            var total = products.Sum(p => p.Price);
            return total * 0.10;
        }
    }
}
