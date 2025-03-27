
namespace Patterns_DZ.DZ_19_03_25.State.WaterStates;

public class GasWaterState : IWaterState
{
    public void Cooling(Water water)
    {
        Console.WriteLine("Превращаем пар в воду");
        water.WaterState = new LiquidWaterState();
    }

    public void Heating(Water water)
    {
        Console.WriteLine("Продолжаем нагревать пар");
    }
}
