
using Patterns_DZ.DZ_21_03_25.Decorator.Pizzas;

namespace Patterns_DZ.DZ_21_03_25.Decorator.Decorators;

public class CheesePizza : PizzaDecorator
{
    public CheesePizza(Pizza pizza) : base(pizza.Name + ", с сыром", pizza) { }
    public override int GetCost()
    {
        return _pizza.GetCost() + 5;
    }
}
