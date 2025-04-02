
namespace Patterns_DZ.DZ_24_03_25.Bridge.Languages;

public class CSharpLanguage : ILanguage
{
    public void Build()
    {
        Console.WriteLine("С помощью компилятора Roslyn компилируем исходный код в файл ехе");
    }

    public void Execute()
    {
        Console.WriteLine("JIT компилирует программу в IL");
        Console.WriteLine("CLR выполняет скомпилированный IL");
    }
}
