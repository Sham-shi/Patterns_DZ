﻿
using Patterns_DZ.DZ_24_03_25.Bridge.Languages;

namespace Patterns_DZ.DZ_24_03_25.Bridge.Programmers;

public class FreelancerProgrammer : Programmer
{
    public FreelancerProgrammer(ILanguage language) : base(language) { }

    public override void EarnMoney()
    {
        Console.WriteLine("Оплата за выполненный заказ");
    }
}
