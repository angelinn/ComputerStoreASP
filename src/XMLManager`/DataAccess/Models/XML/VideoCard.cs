using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    public class VideoCard
    {
        [XmlAttribute]
        public string ID { get; set; }
        [XmlAttribute]
        public string Interface { get; set; }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public GPUMemory GPUMemory { get; set; }
        public string BusWidth { get; set; }
        public string Bandwidth { get; set; }
        public int DirectX { get; set; }
        public string Shaders { get; set; }
        public int Available { get; set; }
        public string Price { get; set; }
    }
}
