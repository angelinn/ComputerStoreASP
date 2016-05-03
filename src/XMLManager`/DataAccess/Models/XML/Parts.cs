using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    public class Parts
    {
        [XmlArray("processors")]
        [XmlArrayItem("processor")]
        public Processor[] Processors { get; set; }
        [XmlArray("ram-boards")]
        [XmlArrayItem("ram-board")]
        public RamBoard[] RamBoards { get; set; }
        [XmlArray("video-cards")]
        [XmlArrayItem("video-cards")]
        public VideoCard[] VideoCards { get; set; }
        [XmlArray("hard-drives")]
        [XmlArrayItem("hard-drive")]
        public HardDrive[] HardDrives { get; set; }
        [XmlArray("motherboards")]
        [XmlArrayItem("motherboard")]
        public Motherboard[] Motherboards { get; set; }
    }
}
