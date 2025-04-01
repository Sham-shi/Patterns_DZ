namespace Patterns_DZ.DZ_21_03_25.Decorator.Pizzas;

public abstract class Pizza
{
    public string Name { get; protected set; }

    public Pizza(string name)
    {
        Name = name;
    }

    public abstract int GetCost();
}
