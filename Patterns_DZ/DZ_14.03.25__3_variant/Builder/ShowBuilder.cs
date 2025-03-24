using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Builder
{
    public class ShowBuilder
    {
        public static void ShowExample()
        {
            Console.WriteLine("Пример использования паттерна Builder\n");

            var computerBuilder = new ComputerBuilder();
            var computer = computerBuilder
                                .SetHardDisk("Western Digital WD40EZRZ")
                                .SetProcessor("AMD Ryzen 5 5600G")
                                .SetRAM("ADATA XPG GAMMIX D20")
                                .Build();

            Console.WriteLine("Собрали компьютер со следующими характеристиками: ");
            Console.WriteLine("Процессор: " + computer.Processor);
            Console.WriteLine("ОЗУ: " + computer.RAM);
            Console.WriteLine("Жёсткий диск: " + computer.HardDisk);

            Console.WriteLine("-----------------------------------------------\n");
        }
    }
}
