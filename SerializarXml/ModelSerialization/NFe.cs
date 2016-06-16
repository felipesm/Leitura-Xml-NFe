using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SerializarXml.ModelSerialization
{    
    public class NFe
    {
        [XmlElement(ElementName = "infNFe")]
        public InfNFe InformacoesNFe { get; set; }
        
        public class InfNFe
        {
            [XmlElement("ide")]
            public Identificacao Identificacao { get; set; }

            [XmlElement("emit")]
            public Emitente Emitente { get; set; }

            [XmlElement("dest")]
            public Destinatario Destinatario { get; set; }
        }
    }
}
