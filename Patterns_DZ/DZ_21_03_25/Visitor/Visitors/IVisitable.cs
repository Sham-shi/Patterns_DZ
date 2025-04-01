
namespace Patterns_DZ.DZ_21_03_25.Visitor.Visitors;

public interface IVisitable
{
    public void Accept(IVisitor visitor);
}
