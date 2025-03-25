
using Patterns_DZ.DZ_17._03._25.Observer.Observable;

namespace Patterns_DZ.DZ_17._03._25.Observer.Observers;

public interface IScreen
{
    public void Display(Weather weather);
    public void UpdateDisplay(Weather weather);
}
