using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    [Serializable]
    public class MemoryType
    {
        public MemoryType()
        {
            RamBoards = new HashSet<RamBoard>();
            GPUMemories = new HashSet<GPUMemory>();
        }

        public static MemoryType XMLToEntity(XML.Memory xmlMemory)
        {
            MemoryType memory = new MemoryType();
            memory.Alias = xmlMemory.ID;
            memory.Name = xmlMemory.MemoryName;

            return memory;
        }

        public int ID { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RamBoard> RamBoards { get; set; }
        public virtual ICollection<GPUMemory> GPUMemories { get; set; }
    }
}
