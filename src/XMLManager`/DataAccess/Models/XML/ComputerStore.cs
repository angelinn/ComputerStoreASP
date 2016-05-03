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
        [XmlElement("sockets")]
        public Socket[] Sockets { get; set; }
        [XmlElement("memory-types")]
        public Memory[] MemoryTypes{ get; set; }
    }
}
