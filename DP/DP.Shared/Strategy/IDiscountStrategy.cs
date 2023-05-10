using DP.Shared.Models;

namespace DP.Shared.Strategy
{
    public interface IDiscountStrategy
    {
        double Calculate(List<Product> products);
    }
}
