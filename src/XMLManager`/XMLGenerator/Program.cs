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
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ComputerStore));
            TextWriter textWriter = new StreamWriter("file.xml");

            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;
            writerSettings.IndentChars = "\t";

            XmlWriter xmlWriter = XmlWriter.Create(textWriter, writerSettings);
            xmlWriter.WriteDocType("computer-store", null, "computer-store.dtd", null);
            ComputerStore store = new ComputerStore();
            store.Parts = new Parts();
            store.Parts.Processors = new Processor[1];
            store.Parts.Processors[0] = new Processor()
            {
                Manufacturer = "Intel",
                Model = "i5 4200h"
            };

            serializer.Serialize(xmlWriter, store);
        }
    }
}
