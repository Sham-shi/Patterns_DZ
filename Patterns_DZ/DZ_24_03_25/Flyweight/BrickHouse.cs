
namespace Patterns_DZ.DZ_24_03_25.Flyweight;

public class BrickHouse : House
{
    public BrickHouse()
    {
        stages = 5;
    }
    public override void Build(double latitude, double longitude)
    {
        Console.WriteLine($"Возведён {stages}-этажный кирпичный дом");
        Console.WriteLine($"Координаты: {latitude} широты, {longitude} долготы");
    }
}
