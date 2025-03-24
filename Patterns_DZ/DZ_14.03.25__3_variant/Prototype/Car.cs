using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Prototype
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Car Clone()
        {
            return new Car()
            {
                Model = this.Model,
                Color = this.Color
            };
        }
    }
}
