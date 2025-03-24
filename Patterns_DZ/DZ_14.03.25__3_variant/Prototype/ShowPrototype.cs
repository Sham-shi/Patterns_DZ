using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Prototype
{
    public class ShowPrototype
    {
        public static void ShowExample()
        {
            Console.WriteLine("Пример использования паттерна Prototype\n");

            var car = new Car
            {
                Model = "Mazda",
                Color = "Red"
            };

            Console.WriteLine($"Оригинал: {car.Model}, {car.Color}");

            var car1 = car.Clone();

            Console.WriteLine($"Копия: {car1.Model}, {car1.Color}");

            Console.WriteLine("-----------------------------------------------\n");
        }
    }
}
