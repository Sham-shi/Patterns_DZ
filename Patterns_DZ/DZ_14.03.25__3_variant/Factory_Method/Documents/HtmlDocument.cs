using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Factory_Method.Documents
{
    class HtmlDocument : Document
    {
        public override void Formation()
        {
            Console.WriteLine("html документ сформирован.");
        }

        public override void Save(string path)
        {
            Console.WriteLine("html документ сохранён в " + path);
        }

        public override void Load(string path)
        {
            Console.WriteLine("html документ загружен из " + path);
        }

        public override void Edit()
        {
            Console.WriteLine("html документ отредактирован.\nИзменения сохранены.");
        }
    }
}
