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

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            XmlWriter xmlWriter = XmlWriter.Create(textWriter, writerSettings);
            xmlWriter.WriteDocType("computer-store", null, "computer_store.dtd", null);

            serializer.Serialize(xmlWriter, toSerialize, ns);
            xmlWriter.Close();
            textWriter.Close();
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

            store.Sockets = new Socket[2];
            store.MemoryTypes = new Memory[4];

            for (int i = 0, j = 0; i < store.Parts.Processors.Length; ++i)
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
                store.Parts.Processors[i].ID = "st_" + store.Parts.Processors[i].GetHashCode().ToString();
                store.Parts.Processors[i].Socket = CPUDatabase.GetSocketFromManufacturer(store.Parts.Processors[i].Manufacturer);

                store.Parts.RamBoards[i] = new RamBoard();
                store.Parts.RamBoards[i].Manufacturer = RAMDatabase.GetRandomRAM();
                store.Parts.RamBoards[i].Memory = RAMDatabase.GetRandomMemory();
                store.Parts.RamBoards[i].Type = RAMDatabase.GetRandomType();
                store.Parts.RamBoards[i].Frequency = RAMDatabase.GetRandomFrequencyFromType(store.Parts.RamBoards[i].Type);
                store.Parts.RamBoards[i].Channel = RAMDatabase.GetRandomChannel();
                store.Parts.RamBoards[i].Available = CommonDatabase.GetRandomAvailable();
                store.Parts.RamBoards[i].Price = CommonDatabase.GetRandomPrice();
                store.Parts.RamBoards[i].ID = "st_" + store.Parts.RamBoards[i].GetHashCode().ToString();

                store.Parts.VideoCards[i] = new VideoCard();
                store.Parts.VideoCards[i].Available = CommonDatabase.GetRandomAvailable();
                store.Parts.VideoCards[i].Price = CommonDatabase.GetRandomPrice();
                store.Parts.VideoCards[i].Manufacturer = GPUDatabase.GetRandomManufacturer();
                store.Parts.VideoCards[i].Model = GPUDatabase.GetRandomModel(store.Parts.VideoCards[i].Manufacturer);
                store.Parts.VideoCards[i].ID = "st_" + store.Parts.VideoCards[i].GetHashCode().ToString();
                store.Parts.VideoCards[i].DirectX = GPUDatabase.GetRandomDirectX();
                store.Parts.VideoCards[i].Bandwidth = GPUDatabase.GetRandomBandwidth();
                store.Parts.VideoCards[i].BusWidth = GPUDatabase.GetRandomBusWidth();
                store.Parts.VideoCards[i].GPUMemory = GPUDatabase.GetRandomGPUMemory();
                store.Parts.VideoCards[i].Interface = GPUDatabase.GetRandomInterface();
                store.Parts.VideoCards[i].Shaders = GPUDatabase.GetRandomShaders();

                store.Parts.HardDrives[i] = new HardDrive();
                store.Parts.HardDrives[i].ID = "st_" + store.Parts.HardDrives[i].GetHashCode().ToString();
                store.Parts.HardDrives[i].Available = CommonDatabase.GetRandomAvailable();
                store.Parts.HardDrives[i].Price = CommonDatabase.GetRandomPrice();
                store.Parts.HardDrives[i].Bus = HDDDatabase.GetRandomBus();
                store.Parts.HardDrives[i].DriveMemory = HDDDatabase.GetRandomMemory();
                store.Parts.HardDrives[i].Manufacturer = HDDDatabase.GetRandomManufacturer();
                store.Parts.HardDrives[i].Size = HDDDatabase.GetRandomSize();
                store.Parts.HardDrives[i].Speed = HDDDatabase.GetSpeedFromDriveType(store.Parts.HardDrives[i].DriveMemory.Type);
                store.Parts.HardDrives[i].LaptopCompatible = HDDDatabase.GetLaptopCompatibleFromSize(store.Parts.HardDrives[i].Size);

                store.Parts.Motherboards[i] = new Motherboard();
                store.Parts.Motherboards[i].Available = CommonDatabase.GetRandomAvailable();
                store.Parts.Motherboards[i].Price = CommonDatabase.GetRandomPrice();
                store.Parts.Motherboards[i].HardDrive = store.Parts.HardDrives[i].ID;
                store.Parts.Motherboards[i].ID = "st_" + store.Parts.Motherboards[i].GetHashCode().ToString();
                store.Parts.Motherboards[i].Processor = store.Parts.Processors[i].ID;
                store.Parts.Motherboards[i].RamMemory = store.Parts.RamBoards[i].ID;
                store.Parts.Motherboards[i].VideoCard = store.Parts.VideoCards[i].ID;
                store.Parts.Motherboards[i].Chipset = MotherboardDatabase.GetRandomChipset();
                store.Parts.Motherboards[i].SocketID = MotherboardDatabase.GetSocketIDFromSocket(store.Parts.Processors[i].Socket);
                store.Parts.Motherboards[i].Manufacturer = MotherboardDatabase.GetRandomManufacturer();

                if (store.Sockets.Length == 0 || !store.Sockets.Any(s => s != null && s.ID == store.Parts.Motherboards[i].SocketID))
                {
                    store.Sockets[i] = new Socket();
                    store.Sockets[i].ID = store.Parts.Motherboards[i].SocketID;
                    store.Sockets[i].SocketName = store.Parts.Processors[i].Socket;
                }

                if (store.MemoryTypes.Length == 0 || !store.MemoryTypes.Any(m => m != null && m.ID == store.Parts.RamBoards[i].Type))
                {
                    store.MemoryTypes[j] = new Memory();
                    store.MemoryTypes[j].ID = store.Parts.RamBoards[i].Type;
                    store.MemoryTypes[j].MemoryName = RAMDatabase.GetRAMNameFromID(store.MemoryTypes[j].ID);
                    ++j;
                }

                if (store.MemoryTypes.Length == 0 || !store.MemoryTypes.Any(m => m != null && m.ID == store.Parts.VideoCards[i].GPUMemory.Type))
                {
                    store.MemoryTypes[j] = new Memory();
                    store.MemoryTypes[j].ID = store.Parts.VideoCards[i].GPUMemory.Type;
                    store.MemoryTypes[j].MemoryName = RAMDatabase.GetRAMNameFromID(store.MemoryTypes[j].ID);
                    ++j;
                }

                store.Parts.Processors[i].Socket = store.Parts.Motherboards[i].SocketID;
            }

            return store;
        }

        public static readonly Random random = new Random();
    }
}
