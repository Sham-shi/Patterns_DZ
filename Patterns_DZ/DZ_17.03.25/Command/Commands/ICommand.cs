
namespace Patterns_DZ.DZ_17._03._25.Command.Commands;

public interface ICommand
{
    public void Execute();
    public void Undo();
}
