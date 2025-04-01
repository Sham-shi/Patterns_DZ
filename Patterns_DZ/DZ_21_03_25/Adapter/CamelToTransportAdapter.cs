
namespace Patterns_DZ.DZ_21_03_25.Adapter;

public class CamelToTransportAdapter : ITransport
{
    private Camel _camel;

    public CamelToTransportAdapter(Camel camel)
    {
        _camel = camel;
    }

    public void Drive()
    {
        _camel.Move();
    }
}
