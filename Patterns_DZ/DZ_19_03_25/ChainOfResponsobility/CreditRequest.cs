namespace Patterns_DZ.DZ_19_03_25.ChainOfResponsobility;

public class CreditRequest
{
    public string ClientName {  get; set; }
    public double Amount { get; set; }

    public CreditRequest(string clientName, double amount)
    {
        ClientName = clientName;
        Amount = amount;
    }
}
