using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.XML
{
    public class Parts
    {
        public Processor[] Processors { get; set; }
        public RamBoard[] RamBoards { get; set; }
        public VideoCard[] VideoCards { get; set; }
        public HardDrive[] HardDrives { get; set; }
        public Motherboard[] Motherboards { get; set; }
    }
}
