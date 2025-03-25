
namespace Patterns_DZ.DZ_17._03._25.Strategy.ShippingStrategies;

public class ExpressShipping : IShippingStrategy
{
    public double CalculateShippingCost(Order order)
    {
        return order.Weight * 1.5;
    }
}
