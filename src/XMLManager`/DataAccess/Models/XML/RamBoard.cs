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
        [XmlAttribute]
        public string ID { get; set; }
        [XmlAttribute]
        public string Type { get; set; }

        public string Manufacturer { get; set; }
        public string Memory { get; set; }
        public string Frequency { get; set; }
        public string Channel { get; set; }
        public int Available { get; set; }
        public string Price { get; set; }
    }
}
