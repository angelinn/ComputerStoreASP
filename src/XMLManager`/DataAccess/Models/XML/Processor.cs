using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    [Serializable]
    public class Processor
    {
        [XmlAttribute("id")]
        public string ID { get; set; }
        [XmlAttribute("socket")]
        public string Socket { get; set; }
        [XmlAttribute("integrated_video")]
        public bool IntegratedVideo { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }
        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }
        [XmlElement("architecture")]
        public string Architecture { get; set; }
        [XmlElement("clock-frequency")]
        public string ClockFrequency { get; set; }
        [XmlElement("cache")]
        public Cache Cache { get; set; }
        [XmlElement("threads")]
        public Threads Threads { get; set; }
        [XmlElement("available")]
        public int Available { get; set; }
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
