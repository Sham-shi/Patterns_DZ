
using Patterns_DZ.DZ_21_03_25.Visitor.Visitors;

namespace Patterns_DZ.DZ_21_03_25.Visitor.Employees;

public class SalesEmployee : Employee, IVisitable
{
    public decimal Comission { get; set; }
    public SalesEmployee(string name, decimal salary, decimal comission) : base(name, salary)
    {
        Comission = comission;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
