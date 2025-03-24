using Patterns_DZ.DZ_14._03._25__3_variant.Factory_Method.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Factory_Method
{
    public class ShowFactoryMethod
    {
        public static void ShowExample()
        {
            Console.WriteLine("Пример использования паттерна Factory Method\n");

            var word1 = new WordDocument();
            word1.Formation();
            word1.Save("C:\\Documents");

            var pdf = new PdfDocument();
            pdf.Load("C:\\User\\Documents\\Example.pdf");
            pdf.Edit();

            var html = new HtmlDocument();
            word1.Formation();
            word1.Save("C:\\Downloads");

            Console.WriteLine("-----------------------------------------------\n");
        }
    }
}
