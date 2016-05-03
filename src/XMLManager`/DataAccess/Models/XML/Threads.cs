using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    public class Threads
    {
        [XmlElement("physical")]
        public int Physical { get; set; }
        [XmlElement("logical")]
        public int Logical { get; set; }
    }
}
