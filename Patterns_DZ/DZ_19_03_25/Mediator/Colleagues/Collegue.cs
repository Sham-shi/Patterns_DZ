
namespace Patterns_DZ.DZ_19_03_25.Mediator.Colleagues;

public abstract class Collegue
{
    protected Mediator _mediator;

    public Collegue(Mediator mediator)
    {
        _mediator = mediator;
    }

    public virtual void Send(string message)
    {
        _mediator.Send(message, this);
    }

    public abstract void Notify(string message);
}
