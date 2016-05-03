using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    public class Socket
    {
        [XmlAttribute("id")]
        public string ID { get; set; }

        [XmlText]
        public string SocketName { get; set; }
    }
}
