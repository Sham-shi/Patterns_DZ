namespace Patterns_DZ.DZ_21_03_25.Visitor.Employees;

public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
}
