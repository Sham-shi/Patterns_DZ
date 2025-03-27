namespace Patterns_DZ.DZ_19_03_25.TemplateMethod;

public class School : Education
{
    public override void Enter()
    {
        Console.WriteLine("Идём в первый класс");
    }

    public override void Study()
    {
        Console.WriteLine("Ходим на уроки, делаем ДЗ");
    }

    public override void GetDocument()
    {
        Console.WriteLine("Получаем аттестат о среднем образовании");
    }
}