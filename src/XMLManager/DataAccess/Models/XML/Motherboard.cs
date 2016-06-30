using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    [Serializable]
    public class Motherboard
    {
        [XmlAttribute("id")]
        public string ID { get; set; }
        [XmlAttribute("socket-id")]
        public string SocketID { get; set; }
        [XmlAttribute("processor")]
        public string Processor { get; set; }
        [XmlAttribute("video-card")]
        public string VideoCard { get; set; }
        [XmlAttribute("ram-memory")]
        public string RamMemory { get; set; }
        [XmlAttribute("hard-drive")]
        public string HardDrive { get; set; }

        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }
        [XmlElement("chipset")]
        public string Chipset { get; set; }
        [XmlElement("available")]
        public int Available { get; set; }
        [XmlElement("price")]
        public string Price { get; set; }

    }
}
