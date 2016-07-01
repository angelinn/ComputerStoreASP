using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class HardDrive
    {
        public static HardDrive XMLToEntity(XML.HardDrive xml)
        {
            return new HardDrive
            {
                Alias = xml.ID,
                Bus = xml.Bus,
                LaptopCompatible = xml.LaptopCompatible,
                Manufacturer = xml.Manufacturer,
                Speed = xml.Speed,
                Size = xml.Size,
                Available = xml.Available,
                Price = xml.Price,
                DriveMemory = DriveMemory.XMLToEntity(xml.DriveMemory)
            };
        }

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
