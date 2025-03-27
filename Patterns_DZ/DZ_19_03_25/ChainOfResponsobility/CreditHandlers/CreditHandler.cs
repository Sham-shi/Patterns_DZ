namespace Patterns_DZ.DZ_19_03_25.ChainOfResponsobility.CreditHandlers;

public abstract class CreditHandler
{
    protected CreditHandler _nextHandler;

    public CreditHandler SetNext(CreditHandler nextHandler)
    {
        _nextHandler = nextHandler;

        return nextHandler;
    }

    public abstract void HandlerRequest(CreditRequest creditRequest);
}
