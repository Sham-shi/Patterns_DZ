
using Patterns_DZ.DZ_21_03_25.Visitor.Visitors;

namespace Patterns_DZ.DZ_21_03_25.Visitor.Employees;
public class OfficeEmployee : Employee, IVisitable
{
    public decimal Bonus { get; set; }
    public OfficeEmployee(string name, decimal salary, decimal bonus) : base(name, salary)
    {
        Bonus=bonus;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
