using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    public class Processor
    {
        [XmlAttribute]
        public string ID { get; set; }
        [XmlAttribute]
        public string Socket { get; set; }
        [XmlAttribute]
        public bool IntegratedVideo { get; set; }

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Architecture { get; set; }
        public string ClockFrequency { get; set; }
        public string Cache { get; set; }
        public Threads Threads { get; set; }
        public int Available { get; set; }
        public string Price { get; set; }
    }
}
