﻿using Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory.TransportMeans.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Abstract_Factory.TransportMeans.ToyotaTransportMeans
{
    public class ToyotaCar : Car
    {
        public ToyotaCar()
        {
            Console.WriteLine("Собрали автомобиль Toyota.");
        }
        public override void Assembling()
        {
            //...
        }
    }
}
