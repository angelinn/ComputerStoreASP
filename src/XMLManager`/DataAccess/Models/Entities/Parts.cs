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
