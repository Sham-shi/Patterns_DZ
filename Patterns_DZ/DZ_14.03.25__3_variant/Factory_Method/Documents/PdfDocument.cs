using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Factory_Method.Documents
{
    public class PdfDocument : Document
    {
        public override void Formation()
        {
            Console.WriteLine("pdf документ сформирован.");
        }

        public override void Save(string path)
        {
            Console.WriteLine(".pdf документ сохранён в " + path);
        }

        public override void Load(string path)
        {
            Console.WriteLine("pdf документ загружен из " + path);
        }

        public override void Edit()
        {
            Console.WriteLine("pdf документ отредактирован.\nИзменения сохранены.");
        }
    }
}
