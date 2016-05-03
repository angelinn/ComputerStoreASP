using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    public class GPUMemory
    {
        [XmlAttribute]
        public string Type { get; set; }
        [XmlText]
        public string Amount { get; set; }
    }
}
