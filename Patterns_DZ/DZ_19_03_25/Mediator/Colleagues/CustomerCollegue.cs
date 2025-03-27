
namespace Patterns_DZ.DZ_19_03_25.Mediator.Colleagues;

public class CustomerCollegue : Collegue
{
    public CustomerCollegue(Mediator mediator) : base(mediator) { }

    public override void Notify(string message)
    {
        Console.WriteLine("Сообщение заказчику: " + message);
    }
}
