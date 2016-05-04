using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    internal class RamBoard
    {
        public int ID { get; set; }
        public string Alias { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string Memory { get; set; }
        public string Frequency { get; set; }
        public string Channel { get; set; }
        public int Available { get; set; }
        public string Price { get; set; }

        public virtual Motherboard Owner { get; set; }
    }
}
