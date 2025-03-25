
namespace Patterns_DZ.DZ_17._03._25.Strategy.ShippingStrategies;

public interface IShippingStrategy
{
    public double CalculateShippingCost(Order order);
}
