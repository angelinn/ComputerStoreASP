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
        private ICollection<Processor> processors;
        private ICollection<VideoCard> videoCards;
        private ICollection<HardDrive> hardDrives;
        private ICollection<RamBoard> ramBoards;
        private ICollection<Motherboard> motherboards;
        private ICollection<Socket> sockets;
        private ICollection<Memory> memoryTypes;

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

        private void ProcessCollection<T>(ref ICollection<T> collection, string key)
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

            XmlSerializer serializer = new XmlSerializer(typeof(DataAccess.Models.XML.ComputerStore));
            XmlWriterSettings writerSettings = XMLUtilities.GetComputerStoreXmlWriterSettings();
            XmlSerializerNamespaces ns = XMLUtilities.GetComputerStoreNamespaces();

            string xmlName = Server.MapPath("~/App_Data/some.xml");

            using (TextWriter textWriter = new StreamWriter(xmlName))
            using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, writerSettings))
            {
                xmlWriter.WriteDocType("computer-store", null, "computer_store.dtd", null);
                serializer.Serialize(xmlWriter, store, ns);
            }

            XMLUtilities utils = new XMLUtilities();
            if (utils.ValidateXML(xmlName))
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

            processors.Add(cpu);
        }

        public IQueryable<VideoCard> GetVideoCards()
        {
            return videoCards.AsQueryable();
        }

        public void InsertVideoCard()
        {
            VideoCard gpu = new VideoCard();
            TryUpdateModel(gpu);

            videoCards.Add(gpu);
        }

        public IQueryable<RamBoard> GetRamBoards()
        {
            return ramBoards.AsQueryable();
        }

        public void InsertRamBoard()
        {
            RamBoard ram = new RamBoard();
            TryUpdateModel(ram);

            ramBoards.Add(ram);
        }

        public IQueryable<HardDrive> GetHardDrives()
        {
            return hardDrives.AsQueryable();
        }

        public void InsertHardDrive()
        {
            HardDrive hdd = new HardDrive();
            TryUpdateModel(hdd);

            hardDrives.Add(hdd);
        }

        public IQueryable<Motherboard> GetMotherboards()
        {
            return motherboards.AsQueryable();
        }

        public void InsertMotherboard()
        {
            Motherboard mobo = new Motherboard();
            TryUpdateModel(mobo);

            motherboards.Add(mobo);
        }

        public IQueryable<Socket> GetSockets()
        {
            return sockets.AsQueryable();
        }

        public void InsertSocket()
        {
            Socket socket = new Socket();
            TryUpdateModel(socket);

            sockets.Add(socket);
        }

        public IQueryable<Memory> GetMemoryTypes()
        {
            return memoryTypes.AsQueryable();
        }

        public void InsertMemoryType()
        {
            Memory memory = new Memory();
            TryUpdateModel(memory);

            memoryTypes.Add(memory);
        }
    }
}
