using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializarXml.ModelSerialization
{
    public class Identificacao
    {
        public int cUF { get; set; }
        public string cNF { get; set; }
        public string natOp { get; set; }
        public int indPag { get; set; }
        public string mod { get; set; }
        public int serie { get; set; }
        public string nNF { get; set; }
        public DateTime dhEmi { get; set; }
        public DateTime dhSaiEnt { get; set; }

    }
}
