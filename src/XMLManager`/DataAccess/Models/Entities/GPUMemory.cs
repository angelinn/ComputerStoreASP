using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    internal class GPUMemory
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Amount { get; set; }

        public virtual VideoCard Owner { get; set; }
    }
}
