using DP.Shared.Models;

namespace DP.Shared.Strategy
{
    public class DiscountStrategyRegularCustomer : IDiscountStrategy
    {
        public double Calculate(List<Product> products)
        {
            var total = products.Sum(p => p.Price);

            return total * 0.03;
        }
    }
}
