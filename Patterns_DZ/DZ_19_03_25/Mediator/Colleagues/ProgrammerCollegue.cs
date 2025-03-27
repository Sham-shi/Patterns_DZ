
namespace Patterns_DZ.DZ_19_03_25.Mediator.Colleagues;

public class ProgrammerCollegue : Collegue
{
    public ProgrammerCollegue(Mediator mediator) : base(mediator) { }
    public override void Notify(string message)
    {
        Console.WriteLine("Сообщение программисту: " + message);
    }
}
