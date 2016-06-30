using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    [Serializable]
    public class DriveMemory
    {
        [XmlElement("amount")]
        public string Amount { get; set; }
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
