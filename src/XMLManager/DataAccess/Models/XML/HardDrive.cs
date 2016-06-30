using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    [Serializable]
    public class HardDrive
    {
        [XmlAttribute("id")]
        public string ID { get; set; }
        [XmlAttribute("bus")]
        public string Bus { get; set; }
        [XmlAttribute("laptop-compatible")]
        public bool LaptopCompatible { get; set; }

        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }
        [XmlElement("drive-memory")]
        public DriveMemory DriveMemory { get; set; }
        [XmlElement("speed")]
        public string Speed { get; set; }
        [XmlElement("size")]
        public string Size { get; set; }
        [XmlElement("available")]
        public int Available { get; set; }
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
