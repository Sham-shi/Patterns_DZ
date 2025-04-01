namespace Patterns_DZ.DZ_21_03_25.Decorator.Pizzas;

public class BulgerianPizza : Pizza
{
    public BulgerianPizza() : base("Болгарская пицца") { }

    public override int GetCost()
    {
        return 8;
    }
}
