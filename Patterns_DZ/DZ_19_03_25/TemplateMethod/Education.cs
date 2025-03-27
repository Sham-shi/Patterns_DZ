using System.Transactions;

namespace Patterns_DZ.DZ_19_03_25.TemplateMethod;

public abstract class Education
{
    public void Learn()
    {
        Enter();
        Study();
        PassExams();
        GetDocument();
    }
    public abstract void Enter();
    public abstract void Study();
    public virtual void PassExams()
    {
        Console.WriteLine("Сдаём выпускные экзамены");
    }
    public abstract void GetDocument();
}
