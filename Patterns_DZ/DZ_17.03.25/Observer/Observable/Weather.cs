
using Patterns_DZ.DZ_17._03._25.Observer.Observers;

namespace Patterns_DZ.DZ_17._03._25.Observer.Observable;


//Система мониторинга погоды.
//Различные дисплеи (например, отображение текущих условий или прогноз погоды)
//могут выступать в качестве наблюдателей за объектом данных о погоде.
//При изменении данных о погоде все дисплеи обновляют свою информацию.


public class Weather
{
    public int Temperature { get; set; }
    public int Pressure { get; set; }

    private List<IScreen> _screens;

    public Weather(int temperature, int pressure)
    {
        Temperature = temperature;
        Pressure = pressure;
        _screens = new List<IScreen>();
    }

    //добавляем экран в подписчики
    public void AddScreen(IScreen screen)
    {
        _screens.Add(screen);
    }

    //удаляем экран из подписчиков
    public void RemoveScreen(IScreen screen)
    {
        _screens.Remove(screen);
    }

    //оповещаем подписчиков об изменениях
    public void NotifyScreen()
    {
        for (int i = 0; i < _screens.Count; i++)
        {
            _screens[i].UpdateDisplay(this);
        }
    }
}
