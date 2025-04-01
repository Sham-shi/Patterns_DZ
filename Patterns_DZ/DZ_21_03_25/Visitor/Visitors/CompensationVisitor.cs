
using Patterns_DZ.DZ_21_03_25.Visitor.Employees;

namespace Patterns_DZ.DZ_21_03_25.Visitor.Visitors;

public class CompensationVisitor : IVisitor
{
    public decimal TotalCompensation { get; set; } = 0;
    public void Visit(OfficeEmployee employee)
    {
        TotalCompensation += employee.Salary + employee.Bonus;
    }

    public void Visit(SalesEmployee employee)
    {
        TotalCompensation += employee.Salary + employee.Comission;
    }
}
