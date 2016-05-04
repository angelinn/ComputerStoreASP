using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Socket
    {
        public int ID { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }

        public ICollection<Processor> Processors { get; set; }
        public ICollection<Motherboard> Motherboards { get; set; }
    }
}
