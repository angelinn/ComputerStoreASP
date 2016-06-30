using Common;
using DataAccess.Models.XML;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;
using DataAccess.Repositories;
using DataAccess.Domain;

namespace ComputerStore
{
    public partial class ManualInput : System.Web.UI.Page
    {
        private IEnumerable<Processor> processors;
        private IEnumerable<VideoCard> videoCards;
        private IEnumerable<HardDrive> hardDrives;
        private IEnumerable<RamBoard> ramBoards;
        private IEnumerable<Motherboard> motherboards;
        private IEnumerable<Socket> sockets;
        private IEnumerable<Memory> memoryTypes;

        protected void Page_Load(object sender, EventArgs e)
        {
            ProcessCollection(ref processors, "processors");
            ProcessCollection(ref videoCards, "videoCards");
            ProcessCollection(ref hardDrives, "hardDrives");
            ProcessCollection(ref ramBoards, "ramBoards");
            ProcessCollection(ref motherboards, "motherboards");
            ProcessCollection(ref sockets, "sockets");
            ProcessCollection(ref memoryTypes, "memoryTypes");
        }

        private void ProcessCollection<T>(ref IEnumerable<T> collection, string key)
        {
            collection = ViewState[key] as List<T>;
            if (collection == null)
            {
                collection = new List<T>();
                ViewState[key] = collection;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DataAccess.Models.XML.ComputerStore store = new DataAccess.Models.XML.ComputerStore();
            store.Parts = new Parts();

            store.Parts.Processors = processors.ToArray();
            store.Parts.VideoCards = videoCards.ToArray();
            store.Parts.RamBoards = ramBoards.ToArray();
            store.Parts.HardDrives = hardDrives.ToArray();
            store.Parts.Motherboards = motherboards.ToArray();
            store.Sockets = sockets.ToArray();
            store.MemoryTypes = memoryTypes.ToArray();

            XmlSerializer serializer = new XmlSerializer(typeof(DataAccess.Models.Entities.ComputerStore));
            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;
            writerSettings.IndentChars = "\t";

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            string resultXml = "C:\\Users\\betra\\desktop\\res.xml";

            using (TextWriter textWriter = new StreamWriter(resultXml))
            using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, writerSettings))
            {
                xmlWriter.WriteDocType("computer-store", null, "computer_store.dtd", null);
                serializer.Serialize(xmlWriter, store, ns);
            }

            ComputerStoreDO.Add(store);
        }

        public IQueryable<Processor> GetProcessors()
        {
            return processors.AsQueryable();
        }

        public void InsertProcessor()
        {
            Processor cpu = new Processor();
            TryUpdateModel(cpu);
        }

        public IQueryable<VideoCard> GetVideoCards()
        {
            return videoCards.AsQueryable();
        }

        public void InsertVideoCard()
        {
            VideoCard gpu = new VideoCard();
            TryUpdateModel(gpu);
        }

        public IQueryable<RamBoard> GetRamBoards()
        {
            return ramBoards.AsQueryable();
        }

        public void InsertRamBoard()
        {
            RamBoard ram = new RamBoard();
            TryUpdateModel(ram);
        }

        public IQueryable<HardDrive> GetHardDrives()
        {
            return hardDrives.AsQueryable();
        }

        public void InsertHardDrive()
        {
            HardDrive hdd = new HardDrive();
            TryUpdateModel(hdd);
        }

        public IQueryable<Motherboard> GetMotherboards()
        {
            return motherboards.AsQueryable();
        }

        public void InsertMotherboard()
        {
            Motherboard gpu = new Motherboard();
            TryUpdateModel(gpu);
        }

        public IQueryable<Socket> GetSockets()
        {
            return sockets.AsQueryable();
        }

        public void InsertSocket()
        {
            Socket socket = new Socket();
            TryUpdateModel(socket);
        }

        public IQueryable<Memory> GetMemoryTypes()
        {
            return memoryTypes.AsQueryable();
        }

        public void InsertMemoryType()
        {
            Memory memory = new Memory();
            TryUpdateModel(memory);
        }

    }
}
