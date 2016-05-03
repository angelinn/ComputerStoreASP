using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    public class Motherboard
    {
        [XmlAttribute]
        public string ID { get; set; }
        [XmlAttribute]
        public string SocketID { get; set; }
        [XmlAttribute]
        public string Processor { get; set; }
        [XmlAttribute]
        public string VideoCard { get; set; }
        [XmlAttribute]
        public string RamMemory { get; set; }
        [XmlAttribute]
        public string HardDrive { get; set; }

        public string Manufacturer { get; set; }
        public string Chipset { get; set; }
        public int Available { get; set; }
        public string Price { get; set; }

    }
}
