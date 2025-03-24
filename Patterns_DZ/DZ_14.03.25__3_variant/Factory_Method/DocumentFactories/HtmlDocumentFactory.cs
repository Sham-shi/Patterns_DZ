﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Patterns_DZ.DZ_14._03._25__3_variant.Factory_Method.Documents;

namespace Patterns_DZ.DZ_14._03._25__3_variant.Factory_Method.DocumentFactories
{
    public class HtmlDocumentFactory : DocumentFactory
    {
        public override Document Create()
        {
            return new HtmlDocument();
        }
    }
}
