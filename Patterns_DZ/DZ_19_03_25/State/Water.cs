using Patterns_DZ.DZ_19_03_25.State.WaterStates;

namespace Patterns_DZ.DZ_19_03_25.State;

public class Water
{
    public IWaterState WaterState { get; set; }

    public Water(IWaterState waterState)
    {
        WaterState = waterState;
    }

    public void Heating()
    {
        WaterState.Heating(this);
    }

    public void Cooling()
    {
        WaterState.Cooling(this);
    }
}
