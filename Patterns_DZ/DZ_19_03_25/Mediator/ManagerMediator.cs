
using Patterns_DZ.DZ_19_03_25.Mediator.Colleagues;

namespace Patterns_DZ.DZ_19_03_25.Mediator;

public class ManagerMediator : Mediator
{
    public CustomerCollegue Customer {  get; set; }
    public ProgrammerCollegue Programmer { get; set; }
    public TesterCollegue Tester { get; set; }

    public override void Send(string message, Collegue collegue)
    {
        //если отправитель заказчик, значит формируется новый заказ
        //отправляем сообщение программисту
        if (collegue == Customer)
        {
            Programmer.Notify(message);
        }
        //если отправитель программист, значит работа выполнена
        //отправляем сообщение тестеру
        else if (collegue ==  Programmer)
        {
            Tester.Notify(message);
        }
        //если отправитель тестер, значит заказ выполнен
        //отправляем сообщение заказчику
        else if (collegue ==  Tester)
        {
            Customer.Notify(message);
        }
    }
}
