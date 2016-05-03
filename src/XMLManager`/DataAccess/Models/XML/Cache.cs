using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    public class Cache
    {
        [XmlElement("levels")]
        public int Levels { get; set; }
        [XmlElement("memory")]
        public string Memory { get; set; }
    }
}
