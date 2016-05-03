using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    public class HardDrive
    {
        [XmlAttribute]
        public string ID { get; set; }
        [XmlAttribute]
        public string Bus { get; set; }
        [XmlAttribute]
        public bool LaptopCompatible { get; set; }

        public string Manufacturer { get; set; }
        public DriveMemory DriveMemory { get; set; }
        public string Speed { get; set; }
        public string Size { get; set; }
        public int Available { get; set; }
        public string Price { get; set; }
    }
}
