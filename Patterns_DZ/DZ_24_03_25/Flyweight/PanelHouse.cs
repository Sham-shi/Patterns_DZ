
namespace Patterns_DZ.DZ_24_03_25.Flyweight;

public class PanelHouse : House
{
    public PanelHouse()
    {
        stages = 16;
    }
    public override void Build(double latitude, double longitude)
    {
        Console.WriteLine($"Возведён {stages}-этажный панельный дом");
        Console.WriteLine($"Координаты: { latitude} широты, { longitude} долготы");
    }
}
