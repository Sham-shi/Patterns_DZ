
namespace Patterns_DZ.DZ_19_03_25.State.WaterStates;

public class SolidWaterState : IWaterState
{
    public void Cooling(Water water)
    {
        Console.WriteLine("Продолжаем охлаждать лёд");
    }

    public void Heating(Water water)
    {
        Console.WriteLine("Превращаем лёд в воду");
        water.WaterState = new LiquidWaterState();
    }
}
