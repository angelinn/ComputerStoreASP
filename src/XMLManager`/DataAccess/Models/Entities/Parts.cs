using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    internal class Parts
    {
        public int ID { get; set; }

        public virtual ICollection<Processor> Processors { get; set; }
        public virtual ICollection<VideoCard> VideoCards { get; set; }
        public virtual ICollection<RamBoard> RamBoards { get; set; }
        public virtual ICollection<HardDrive> HardDrives { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }
    }
}
