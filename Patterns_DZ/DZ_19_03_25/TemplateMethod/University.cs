
namespace Patterns_DZ.DZ_19_03_25.TemplateMethod;

public class University : Education
{
    public override void Enter()
    {
        Console.WriteLine("Сдаём вступительные экзамены, поступаем в университет");
    }

    public override void Study()
    {
        Console.WriteLine("Посещаем лекции, проходим практику");
    }

    public override void PassExams()
    {
        Console.WriteLine("Пишем дипломную работу, сдаём экзамен по специальности");
    }

    public override void GetDocument()
    {
        Console.WriteLine("Получаем диплом о высшем образовании");
    }
}
