
namespace Patterns_DZ.DZ_19_03_25.Mediator.Colleagues;

public class TesterCollegue : Collegue
{
    public TesterCollegue(Mediator mediator) : base(mediator) { }
    public override void Notify(string message)
    {
        Console.WriteLine("Сообщение тестеру: " + message);
    }
}
