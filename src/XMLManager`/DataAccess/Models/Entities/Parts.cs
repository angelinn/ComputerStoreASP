using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Parts
    {
        public Parts()
        {
            Processors = new HashSet<Processor>();
            VideoCards = new HashSet<VideoCard>();
            RamBoards = new HashSet<RamBoard>();
            HardDrives = new HashSet<HardDrive>();
            Motherboards = new HashSet<Motherboard>();
        }

        public static Parts XMLToEntity(XML.Parts xmlParts)
        {
            Parts parts = new Parts();
            foreach (XML.Processor xmlCPU in xmlParts.Processors)
                parts.Processors.Add(Processor.XMLToEntity(xmlCPU));

            //foreach (XML.VideoCard xmlGPU in xmlParts.VideoCards)
            //    parts.VideoCards.Add(VideoCard.XMLToEntity(xmlGPU));

            //foreach (XML.HardDrive xmlHDD in xmlParts.HardDrives)
            //    parts.HardDrives.Add(HardDrive.XMLToEntity(xmlHDD));

            //foreach (XML.RamBoard xmlRAM in xmlParts.RamBoards)
            //    parts.RamBoards.Add(RamBoard.XMLToEntity(xmlRAM));

            //foreach (XML.Motherboard xmlMobo in xmlParts.Motherboards)
            //    parts.Motherboards.Add(Motherboard.XMLToEntity(xmlMobo));

            return parts;
        }

        public int ID { get; set; }

        public virtual ICollection<Processor> Processors { get; set; }
        public virtual ICollection<VideoCard> VideoCards { get; set; }
        public virtual ICollection<RamBoard> RamBoards { get; set; }
        public virtual ICollection<HardDrive> HardDrives { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }
    }
}
