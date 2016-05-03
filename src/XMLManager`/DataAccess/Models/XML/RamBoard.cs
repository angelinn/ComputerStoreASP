using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    public class RamBoard
    {
        [XmlAttribute("id")]
        public string ID { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }
        [XmlElement("memory")]
        public string Memory { get; set; }
        [XmlElement("frequency")]
        public string Frequency { get; set; }
        [XmlElement("channel")]
        public string Channel { get; set; }
        [XmlElement("available")]
        public int Available { get; set; }
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
