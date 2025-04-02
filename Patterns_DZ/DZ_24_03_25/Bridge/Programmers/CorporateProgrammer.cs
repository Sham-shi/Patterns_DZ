
using Patterns_DZ.DZ_24_03_25.Bridge.Languages;

namespace Patterns_DZ.DZ_24_03_25.Bridge.Programmers;

public class CorporateProgrammer : Programmer
{
    public CorporateProgrammer(ILanguage language) : base(language) { }

    public override void EarnMoney()
    {
        Console.WriteLine("Зарплата в конце месяца");
    }
}
