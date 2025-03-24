using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Factory_Method.Documents
{
    class WordDocument : Document
    {
        public override void Formation()
        {
            Console.WriteLine("word документ сформирован.");
        }

        public override void Save(string path)
        {
            Console.WriteLine("word документ сохранён в " + path);
        }

        public override void Load(string path)
        {
            Console.WriteLine("word документ загружен из " + path);
        }

        public override void Edit()
        {
            Console.WriteLine("word документ отредактирован.\nИзменения сохранены.");
        }
    }
}
