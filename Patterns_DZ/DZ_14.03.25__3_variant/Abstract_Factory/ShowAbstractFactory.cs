using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory.TransportMeans.HondaTransportMeans;
using Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory.TransportMeans.ToyotaTransportMeans;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory
{
    public class ShowAbstractFactory
    {
        public static void ShowExample()
        {
            Console.WriteLine("Пример использования паттерна AbstractFactory\n");

            var hondaBike = new HondaBike();
            var hondaCar = new HondaCar();

            var toyotaBike = new ToyotaBike();
            var toyotaCar = new ToyotaCar();

            Console.WriteLine("-----------------------------------------------\n");
        }
    }
}
