namespace Patterns_DZ.DZ_19_03_25.State.WaterStates;

public interface IWaterState
{
    public void Heating(Water water);
    public void Cooling(Water water);
}
