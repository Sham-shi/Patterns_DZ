
namespace Patterns_DZ.DZ_21_03_25.Adapter;

public class Auto : ITransport
{
    public void Drive()
    {
        Console.WriteLine("Машина едет");
    }
}
