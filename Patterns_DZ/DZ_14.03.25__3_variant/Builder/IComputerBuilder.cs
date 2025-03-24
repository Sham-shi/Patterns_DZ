using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Builder
{
    public interface IComputerBuilder
    {
        IComputerBuilder SetProcessor(string processor);
        IComputerBuilder SetRAM(string RAM);
        IComputerBuilder SetHardDisk(string hardDisk);

        Computer Build();
    }
}
