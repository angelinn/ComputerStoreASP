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
        [XmlElement("processors")]
        public Processor[] Processors { get; set; }
        [XmlElement("ram-boards")]
        public RamBoard[] RamBoards { get; set; }
        [XmlElement("video-cards")]
        public VideoCard[] VideoCards { get; set; }
        [XmlElement("hard-drives")]
        public HardDrive[] HardDrives { get; set; }
        [XmlElement("motherboards")]
        public Motherboard[] Motherboards { get; set; }
    }
}
