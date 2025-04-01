
using Patterns_DZ.DZ_21_03_25.Decorator.Pizzas;

namespace Patterns_DZ.DZ_21_03_25.Decorator.Decorators;

public abstract class PizzaDecorator : Pizza
{
    protected Pizza _pizza;
    protected PizzaDecorator(string name, Pizza pizza) : base(name)
    {
        _pizza=pizza;
    }
}
