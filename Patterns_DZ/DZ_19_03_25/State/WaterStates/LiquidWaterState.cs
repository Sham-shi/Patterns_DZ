
namespace Patterns_DZ.DZ_19_03_25.State.WaterStates;

public class LiquidWaterState : IWaterState
{
    public void Cooling(Water water)
    {
        Console.WriteLine("Превращаем воду в лёд");
        water.WaterState = new SolidWaterState();
    }

    public void Heating(Water water)
    {
        Console.WriteLine("Превращаем воду в пар");
        water.WaterState = new GasWaterState();
    }
}
