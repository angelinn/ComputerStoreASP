using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    internal class Processor
    {
        public int ID { get; set; }
        public string Alias { get; set; }
        public string Socket { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Architecture { get; set; }
        public string ClockFrequency { get; set; }
        public string Price { get; set; }
        public int Available { get; set; }
        public bool IntegratedVideo { get; set; }

        public virtual Threads Threads { get; set; }
        public virtual Cache Cache { get; set; }
    }
}
