using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class MemoryType
    {
        public int ID { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RamBoard> RamBoards { get; set; }
        public virtual ICollection<GPUMemory> GPUMemories { get; set; }
    }
}
