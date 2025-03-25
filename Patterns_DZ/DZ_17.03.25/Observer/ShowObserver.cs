
using Patterns_DZ.DZ_17._03._25.Observer.Observable;
using Patterns_DZ.DZ_17._03._25.Observer.Observers;

namespace Patterns_DZ.DZ_17._03._25.Observer;

public class ShowObserver
{
    public static void ShowExample()
    {
        Console.WriteLine("Пример использования паттерна Observer\n");

        var weather = new Weather(34, 760);

        var screen1 = new Screen("Экран1");
        var screen2 = new Screen("Экран2");
        var screen3 = new Screen("Экран3");

        weather.AddScreen(screen1);
        weather.AddScreen(screen2);
        weather.AddScreen(screen3);

        screen1.Display(weather);
        screen2.Display(weather);
        screen3.Display(weather);

        weather.Temperature = 30;
        weather.Pressure = 750;

        weather.NotifyScreen();

        weather.RemoveScreen(screen2);

        weather.Temperature = -24;
        weather.Pressure = 780;

        weather.NotifyScreen();

        Console.WriteLine("-----------------------------------------------\n");
    }
}
