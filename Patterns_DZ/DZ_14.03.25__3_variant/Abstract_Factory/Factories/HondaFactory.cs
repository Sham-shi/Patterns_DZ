using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory.TransportMeans.Abstractions;
using Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory.TransportMeans.HondaTransportMeans;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory.Factories
{
    public class HondaFactory : TransportFactory
    {
        public override Bike CreateBike()
        {
            return new HondaBike();
        }

        public override Car CreateCar()
        {
            return new HondaCar();
        }
    }
}
