
using Patterns_DZ.DZ_21_03_25.Visitor.Employees;

namespace Patterns_DZ.DZ_21_03_25.Visitor.Visitors;

public class StockOptionVisitor : IVisitor
{
    public decimal TotalUnit { get; set; } = 0;
    public void Visit(OfficeEmployee employee)
    {
        var totalCompensation = employee.Salary + employee.Bonus;
        if (totalCompensation > 100_000)
        {
            TotalUnit += totalCompensation + 1000;
        }
        else
        {
            TotalUnit += totalCompensation + 500;
        }
    }

    public void Visit(SalesEmployee employee)
    {
        var totalCompensation = employee.Salary + employee.Comission;
        if (totalCompensation > 100_000)
        {
            TotalUnit += totalCompensation + 1000;
        }
        else
        {
            TotalUnit += totalCompensation + 500;
        }
    }
}
