
using Patterns_DZ.DZ_17._03._25.Command.Commands;
using Patterns_DZ.DZ_17._03._25.Command.SmartHomeControlPanel;
using Patterns_DZ.DZ_17._03._25.Command.SmartHomeElements;

namespace Patterns_DZ.DZ_17._03._25.Command;

public class ShowCommand
{
    public static void ShowExample()
    {
        Console.WriteLine("Пример использования паттерна Command\n");

        var light = new Light();
        var player = new MusicPlayer();

        var controlPanel = new ControlPanel();

        controlPanel.ExecuteCommand(new LightCommand(light, true));
        controlPanel.ExecuteCommand(new MusicCommand(player, true));

        Console.WriteLine("\nОтменяем последние действия:\n");

        controlPanel.UndoCommand();
        controlPanel.UndoCommand();

        Console.WriteLine("-----------------------------------------------\n");
    }
}
