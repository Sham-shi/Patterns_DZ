
namespace Patterns_DZ.DZ_24_03_25.Flyweight;

public class HouseFactory
{
    private Dictionary<string, House> _houses = new Dictionary<string, House>();

    public HouseFactory()
    {
        _houses.Add("Panel", new PanelHouse());
        _houses.Add("Brick", new BrickHouse());
    }

    public House GetHouse(string key)
    {
        if (_houses.ContainsKey(key))
        {
            return _houses[key];
        }
        else
            return null;
    }
}
