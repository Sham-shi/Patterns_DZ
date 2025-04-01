
using Patterns_DZ.DZ_21_03_25.Visitor.Employees;

namespace Patterns_DZ.DZ_21_03_25.Visitor.Visitors;

public interface IVisitor
{
    void Visit(OfficeEmployee employee);
    void Visit(SalesEmployee employee);
}
