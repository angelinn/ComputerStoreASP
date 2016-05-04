using DataAccess.Models.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ComputerStore store = Serializer.GenerateRandomData();
            Serializer.SerializeXML(store, "xmled.xml");
        }
    }
}
