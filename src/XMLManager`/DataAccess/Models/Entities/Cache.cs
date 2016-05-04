using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    internal class Cache
    {
        public int ID { get; set; }
        public int Levels { get; set; }
        public string Memory { get; set; }

        public virtual Processor Owner { get; set; }
    }
}
