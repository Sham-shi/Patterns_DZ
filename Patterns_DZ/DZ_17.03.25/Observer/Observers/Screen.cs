
using Patterns_DZ.DZ_17._03._25.Observer.Observable;

namespace Patterns_DZ.DZ_17._03._25.Observer.Observers;

public class Screen : IScreen
{
    private string _screenName;

    public Screen(string screenName)
    {
        _screenName = screenName;
    }

    public void Display(Weather weather)
    {
        Console.WriteLine(_screenName + ": ");
        Console.WriteLine("Температура: " + weather.Temperature + " C");
        Console.WriteLine("Давление: " + weather.Pressure + " мм рт. ст.");
    }

    public void UpdateDisplay(Weather weather)
    {
        Display(weather);
    }
}
