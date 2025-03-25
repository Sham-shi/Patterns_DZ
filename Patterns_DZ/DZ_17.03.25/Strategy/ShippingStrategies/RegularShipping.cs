
namespace Patterns_DZ.DZ_17._03._25.Strategy.ShippingStrategies;

public class RegularShipping : IShippingStrategy
{
    public double CalculateShippingCost(Order order)
    {
        return order.Weight * 0.5; 
    }
}
