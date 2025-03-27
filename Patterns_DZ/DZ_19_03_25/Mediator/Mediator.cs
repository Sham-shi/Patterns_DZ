using Patterns_DZ.DZ_19_03_25.Mediator.Colleagues;

namespace Patterns_DZ.DZ_19_03_25.Mediator;

public abstract class Mediator
{
    public abstract void Send(string message, Collegue collegue);
}
