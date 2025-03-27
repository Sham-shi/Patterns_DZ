namespace Patterns_DZ.DZ_19_03_25.ChainOfResponsobility.CreditHandlers;

public class DepartmentHeadHandler : CreditHandler
{
    public override void HandlerRequest(CreditRequest creditRequest)
    {
        if (creditRequest.Amount <= 500_000)
        {
            Console.WriteLine($"Заявка от {creditRequest.ClientName} на {creditRequest.Amount} принята начальником отдела");
        }
        else if (_nextHandler  != null)
        {
            _nextHandler.HandlerRequest(creditRequest);
        }
        else
        {
            Console.WriteLine("Заявка не может быть обработана");
        }
    }
}
