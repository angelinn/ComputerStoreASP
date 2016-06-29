using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    [Serializable]
    public class HardDrive
    {
        public int ID { get; set; }
        public string Alias { get; set; }
        public string Bus { get; set; }
        public bool LaptopCompatible { get; set; }
        public string Manufacturer { get; set; }
        public string Speed { get; set; }
        public string Size { get; set; }
        public int Available { get; set; }
        public string Price { get; set; }
        
        public virtual DriveMemory DriveMemory { get; set; }
    }
}
