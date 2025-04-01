
using Patterns_DZ.DZ_21_03_25.Decorator.Pizzas;

namespace Patterns_DZ.DZ_21_03_25.Decorator.Decorators;

public class TomatoPizza : PizzaDecorator
{
    public TomatoPizza(Pizza pizza) : base(pizza.Name + ", с томатами", pizza) { }
    public override int GetCost()
    {
        return _pizza.GetCost() + 3;
    }
}
