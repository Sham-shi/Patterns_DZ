
using Patterns_DZ.DZ_17._03._25.Command.Commands;

namespace Patterns_DZ.DZ_17._03._25.Command.SmartHomeControlPanel;

//Система умный дом
//Возможность включения/выключения света и/или музыки
//сохранение команд в список, возвращение к предыдущей команде

public class ControlPanel
{
    private List<ICommand> _commands;

    public ControlPanel()
    {
        _commands = new List<ICommand>();
    }

    public void ExecuteCommand(ICommand command)
    {
        _commands.Add(command);
        command.Execute();
    }

    public void UndoCommand()
    {
        var command = _commands[_commands.Count - 1];
        command.Undo();
        _commands.Remove(command);
    }
}
