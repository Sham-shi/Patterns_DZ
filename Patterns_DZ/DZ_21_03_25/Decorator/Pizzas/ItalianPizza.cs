namespace Patterns_DZ.DZ_21_03_25.Decorator.Pizzas;

public class ItalianPizza : Pizza
{
    public ItalianPizza() : base("Итальянская пицца") { }

    public override int GetCost()
    {
        return 10;
    }
}
