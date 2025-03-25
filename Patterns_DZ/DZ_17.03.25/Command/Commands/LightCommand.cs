
using Patterns_DZ.DZ_17._03._25.Command.SmartHomeElements;

namespace Patterns_DZ.DZ_17._03._25.Command.Commands;

public class LightCommand : ICommand
{
    private Light _light;
    private bool _isOn;

    public LightCommand(Light light, bool onOff)
    {
        _light = light;
        _isOn = onOff;
    }
    public void Execute()
    {
        if (_isOn)
            _light.TurnOn();
        else
            _light.TurnOff();
    }

    public void Undo()
    {
        if (!_isOn)
            _light.TurnOn();
        else
            _light.TurnOff();
    }
}
