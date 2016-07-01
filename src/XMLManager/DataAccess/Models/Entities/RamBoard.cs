using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class RamBoard
    {
        public static RamBoard XMLToEntity(XML.RamBoard xml)
        {
            return new RamBoard
            {               
                Alias = xml.ID,
                Type = xml.Type,
                Manufacturer = xml.Manufacturer,
                Frequency = xml.Frequency,
                Channel = xml.Channel,
                Available = xml.Available,
                Price = xml.Price,
                Memory = xml.Price
            };
        }

        public int ID { get; set; }
        public string Alias { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string Frequency { get; set; }
        public string Channel { get; set; }
        public int Available { get; set; }
        public string Price { get; set; }
        public string Memory { get; set; }
        
        public virtual MemoryType MemoryType { get; set; }
    }
}
