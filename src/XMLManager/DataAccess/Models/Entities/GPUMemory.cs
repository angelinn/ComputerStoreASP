using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class GPUMemory
    {
        public static GPUMemory XMLToEntity(XML.GPUMemory xml)
        {
            return new GPUMemory
            {
                Amount = xml.Amount,
                Type = xml.Type
            };
        }

        public int ID { get; set; }
        public string Type { get; set; }
        public string Amount { get; set; }
    }
}
