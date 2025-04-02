
namespace Patterns_DZ.DZ_24_03_25.Bridge.Languages;

public class CPPLanguage : ILanguage
{
    public void Build()
    {
        Console.WriteLine("С помощью компилятора С++ компилируем программу в бинарный код");
    }

    public void Execute()
    {
        Console.WriteLine("Запускаем исполняемый файл программы");
    }
}
