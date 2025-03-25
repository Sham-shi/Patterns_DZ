
using Patterns_DZ.DZ_17._03._25.Strategy.ShippingStrategies;

namespace Patterns_DZ.DZ_17._03._25.Strategy;


//система расчета стоимости доставки,
//где используются различные варианты
//в зависимости от выбранного способа


public class ShippingContext
{
    private IShippingStrategy _shippingStrategy;
    public ShippingContext(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public void ChangeShippingStrategy(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public double CalculateCost(Order order)
    {
        return _shippingStrategy.CalculateShippingCost(order);
    }
}
