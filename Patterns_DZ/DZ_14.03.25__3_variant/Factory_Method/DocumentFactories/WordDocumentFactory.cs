using Patterns_DZ.DZ_14._03._25__3_variant.Factory_Method.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Factory_Method.DocumentFactories
{
    class WordDocumentFactory : DocumentFactory
    {
        public override Document Create()
        {
            return new WordDocument();
        }
    }
}
