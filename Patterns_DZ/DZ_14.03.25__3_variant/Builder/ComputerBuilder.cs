using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Builder
{
    public class ComputerBuilder : IComputerBuilder
    {
        private Computer _computer;

        public ComputerBuilder()
        {
            _computer = new Computer();
        }

        public IComputerBuilder SetHardDisk(string hardDisk)
        {
            _computer.HardDisk = hardDisk;

            return this;
        }

        public IComputerBuilder SetProcessor(string processor)
        {
            _computer.Processor = processor;

            return this;
        }

        public IComputerBuilder SetRAM(string RAM)
        {
            _computer.RAM = RAM;

            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
