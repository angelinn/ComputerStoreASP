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
using XMLGenerator.Databases;

namespace XMLGenerator
{
    public static class Generator
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
            store.Parts.Processors = new Processor[2];
            store.Parts.RamBoards = new RamBoard[2];
            store.Parts.HardDrives = new HardDrive[2];
            store.Parts.VideoCards = new VideoCard[2];
            store.Parts.Motherboards = new Motherboard[2];

            for (int i = 0; i < store.Parts.Processors.Length; ++i)
            {
                store.Parts.Processors[i] = new Processor();
                store.Parts.Processors[i].Manufacturer = CPUDatabase.GetRandomCPU();
                store.Parts.Processors[i].Model = CPUDatabase.GetRandomCPUModel(store.Parts.Processors[i].Manufacturer);
                store.Parts.Processors[i].Architecture = CPUDatabase.GetRandomArchitecture(store.Parts.Processors[i].Manufacturer);
                store.Parts.Processors[i].ClockFrequency = CPUDatabase.GetRandomClockFrequency();
                store.Parts.Processors[i].Cache = CPUDatabase.GetRandomCache();
                store.Parts.Processors[i].Available = CommonDatabase.GetRandomAvailable();
                store.Parts.Processors[i].Threads = CPUDatabase.GetRandomThreads();
                store.Parts.Processors[i].Price = CommonDatabase.GetRandomPrice();
                store.Parts.Processors[i].ID = CPUDatabase.GetIdFromModel(store.Parts.Processors[i].Model);
                store.Parts.Processors[i].Socket = CPUDatabase.GetSocketFromManufacturer(store.Parts.Processors[i].Manufacturer);

                store.Parts.RamBoards[i] = new RamBoard();
                store.Parts.RamBoards[i].Manufacturer = RAMDatabase.GetRandomRAM();
                store.Parts.RamBoards[i].Memory = RAMDatabase.GetRandomMemory();
                store.Parts.RamBoards[i].Type = RAMDatabase.GetRandomType();
                store.Parts.RamBoards[i].Frequency = RAMDatabase.GetRandomFrequencyFromType(store.Parts.RamBoards[i].Type);
                store.Parts.RamBoards[i].Channel = RAMDatabase.GetRandomChannel();
                store.Parts.RamBoards[i].Available = CommonDatabase.GetRandomAvailable();
                store.Parts.RamBoards[i].Price = CommonDatabase.GetRandomPrice();
                store.Parts.RamBoards[i].ID = store.Parts.RamBoards[i].GetHashCode().ToString();

                store.Parts.VideoCards[i] = new VideoCard();
                store.Parts.VideoCards[i].Available = CommonDatabase.GetRandomAvailable();
                store.Parts.VideoCards[i].Price = CommonDatabase.GetRandomPrice();
                store.Parts.VideoCards[i].Manufacturer = GPUDatabase.GetRandomManufacturer();
                store.Parts.VideoCards[i].Model = GPUDatabase.GetRandomModel(store.Parts.VideoCards[i].Manufacturer);
                store.Parts.VideoCards[i].ID = store.Parts.VideoCards[i].GetHashCode().ToString();
                store.Parts.VideoCards[i].DirectX = GPUDatabase.GetRandomDirectX();
                store.Parts.VideoCards[i].Bandwidth = GPUDatabase.GetRandomBandwidth();
                store.Parts.VideoCards[i].BusWidth = GPUDatabase.GetRandomBusWidth();
                store.Parts.VideoCards[i].GPUMemory = GPUDatabase.GetRandomGPUMemory();
                store.Parts.VideoCards[i].Interface = GPUDatabase.GetRandomInterface();
                store.Parts.VideoCards[i].Shaders = GPUDatabase.GetRandomShaders();

            }

            return store;

        }

        public static readonly Random random = new Random();
    }
}
