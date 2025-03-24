using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory.TransportMeans.Abstractions;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory.TransportMeans.HondaTransportMeans
{
    public class HondaBike : Bike
    {
        public HondaBike()
        {
            Console.WriteLine("Собрали мотоцикл Honda.");
        }
        public override void Assembling()
        {
            //...
        }
    }
}
