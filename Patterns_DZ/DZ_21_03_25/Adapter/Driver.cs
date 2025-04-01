
namespace Patterns_DZ.DZ_21_03_25.Adapter;

public class Driver
{
    public void Travel(ITransport transport)
    {
        transport.Drive();
    }
}
