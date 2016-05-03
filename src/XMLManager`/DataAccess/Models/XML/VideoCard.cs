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
        [XmlAttribute("id")]
        public string ID { get; set; }
        [XmlAttribute("interface")]
        public string Interface { get; set; }

        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }
        [XmlElement("model")]
        public string Model { get; set; }
        [XmlElement("gpu-memory")]
        public GPUMemory GPUMemory { get; set; }
        [XmlElement("bus-width")]
        public string BusWidth { get; set; }
        [XmlElement("bandwidth")]
        public string Bandwidth { get; set; }
        [XmlElement("directx")]
        public int DirectX { get; set; }
        [XmlElement("shaders")]
        public string Shaders { get; set; }
        [XmlElement("available")]
        public int Available { get; set; }
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
