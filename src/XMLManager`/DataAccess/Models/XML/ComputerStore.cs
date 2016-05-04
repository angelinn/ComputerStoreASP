using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    [XmlRoot("computer-store")]
    public class ComputerStore
    {
        [XmlElement("parts")]
        public Parts Parts { get; set; }
        [XmlArray("sockets")]
        [XmlArrayItem("socket", IsNullable = false)]
        public Socket[] Sockets { get; set; }
        [XmlArray("memory-types")]
        [XmlArrayItem("memory-type", IsNullable = false)]
        public Memory[] MemoryTypes{ get; set; }
    }
}
