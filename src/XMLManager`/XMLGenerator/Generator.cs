using DataAccess.Models.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLGenerator
{
    public static class Serializer
    {
        public static void SerializeXML<T>(T toSerialize, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter textWriter = new StreamWriter(fileName);

            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;
            writerSettings.IndentChars = "\t";

            XmlWriter xmlWriter = XmlWriter.Create(textWriter, writerSettings);
            xmlWriter.WriteDocType("computer-store", null, "computer-store.dtd", null);

            serializer.Serialize(xmlWriter, toSerialize);
        }

        public static ComputerStore GenerateRandomData()
        {
            ComputerStore store = new ComputerStore();
            store.Parts = new Parts();
            store.Parts.Processors = new Processor[5];

            for (int i = 0; i < store.Parts.Processors.Length; ++i)
            {
                store.Parts.Processors[i] = new Processor();
                store.Parts.Processors[i].Manufacturer = Database.GetRandomCPU();
                store.Parts.Processors[i].Model = Database.GetRandomCPUModel(store.Parts.Processors[i].Manufacturer);
                store.Parts.Processors[i].Architecture = Database.GetRandomArchitecture();
                store.Parts.Processors[i].ClockFrequency = Database.GetRandomClockFrequency();
                store.Parts.Processors[i].Cache = Database.GetRandomCache();
                store.Parts.Processors[i].Available = Database.GetRandomAvailable();
                store.Parts.Processors[i].Threads = Database.GetRandomThreads();
                store.Parts.Processors[i].Price = Database.GetRandomCPUPrice();
                store.Parts.Processors[i].ID = Database.GetIdFromModel(store.Parts.Processors[i].Model);
                store.Parts.Processors[i].Socket = Database.GetSocketFromManufacturer(store.Parts.Processors[i].Manufacturer);
            }

            return store;

        }
    }
}
