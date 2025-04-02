
using Patterns_DZ.DZ_24_03_25.Bridge.Languages;

namespace Patterns_DZ.DZ_24_03_25.Bridge.Programmers;

public abstract class Programmer
{
    protected ILanguage _language;

    public ILanguage Language
    {
        set { _language = value; }
    }

    public Programmer(ILanguage language)
    {
        _language = language;
    }

    public virtual void DoWOrk()
    {
        _language.Build();
        _language.Execute();
    }

    public abstract void EarnMoney();
}
