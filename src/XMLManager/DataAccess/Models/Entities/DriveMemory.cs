using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class DriveMemory
    {
        public static DriveMemory XMLToEntity(XML.DriveMemory xml)
        {
            return new DriveMemory
            {
                Amount = xml.Amount,
                Type = xml.Type
            };
        }

        public int ID { get; set; }
        public string Amount { get; set; }
        public string Type { get; set; }
    }
}
