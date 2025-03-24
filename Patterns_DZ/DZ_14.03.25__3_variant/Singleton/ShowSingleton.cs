using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Singleton
{
    class ShowSingleton
    {
        public static void ShowExample()
        {
            Console.WriteLine("Пример использования паттерна Singleton\n");

            var dbConnection1 = DatabaseConnection.GetInstance();

            dbConnection1.Connection();

            dbConnection1.RequestProcessing("SELECT * FROM Users");

            var dbConnection2 = DatabaseConnection.GetInstance();

            if (dbConnection1.GetHashCode() == dbConnection2.GetHashCode())
                Console.WriteLine("dbConnection1 равен dbConnection2");

            dbConnection1.Disconnection();

            Console.WriteLine("-----------------------------------------------\n");
        }
    }
}
