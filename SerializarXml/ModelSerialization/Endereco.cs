using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializarXml.ModelSerialization
{
    public class Endereco
    {
        public string xLgr { get; set; }
        public string nro { get; set; }
        public string xBairro { get; set; }
        public string cMun { get; set; }
        public string xMun { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public int cPais { get; set; }
        public string xPais { get; set; }
    }
}
