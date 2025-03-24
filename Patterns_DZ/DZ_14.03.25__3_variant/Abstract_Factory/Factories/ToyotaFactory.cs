using Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory.TransportMeans.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory.TransportMeans.ToyotaTransportMeans;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory.Factories
{
    public class ToyotaFactory : TransportFactory
    {
        public override Bike CreateBike()
        {
            return new ToyotaBike();
        }

        public override Car CreateCar()
        {
            return new ToyotaCar();
        }
    }
}
