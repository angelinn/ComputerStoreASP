using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    internal class Threads
    {
        public int ID { get; set; }
        public int Logical { get; set; }
        public int Physical { get; set; }

        public virtual Processor Owner { get; set; }
    }
}
