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
using XMLWorker.Common;
using DataAccess.Repositories;

namespace XMLWorker
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
            ComputerStore store = new ComputerStore();
            
            //store.Parts.Processors[0] = new Processor
            //{
            //  //  ID = txtCpuID.Text,
            //    //Socket = txtCpuSocket.Text,
            //    //Model = txtCpuModel.Text,
            //    Manufacturer = txtCpuManufacturer.Text,
            //    Architecture = txtCpuArchitecture.Text,
            //    ClockFrequency = txtCpuFrequency.Text,
            //    Cache = new Cache { Levels = Int32.Parse(txtCacheLevels.Text), Memory = txtCacheMemory.Text },
            //    Threads = new Threads { Logical = Int32.Parse(txtLogicalThreads.Text), Physical = Int32.Parse(txtPhysicalThreads.Text) },
            //    Available = Int32.Parse(txtCpuAvailable.Text),
            //    Price = txtCpuPrice.Text,
            //    IntegratedVideo = chkCpuVideo.Checked
            //};

            //store.Parts.VideoCards = new VideoCard[1];
            //store.Parts.VideoCards[0] = new VideoCard
            //{
            //    Available = Int32.Parse(txtGpuAvailable.Text),
            //    Bandwidth = txtGpuBandwidth.Text,
            //    BusWidth = txtGpuBus.Text,
            //    DirectX = Int32.Parse(txtGpuDirectX.Text),
            //    GPUMemory = new GPUMemory { Amount = txtGpuMemoryAmount.Text, Type = txtGpuMemoryTypeID.Text },
            //    ID = txtGpuID.Text,
            //    Interface = txtGpuIface.Text,
            //    Manufacturer = txtGpuManufacturer.Text,
            //    Model = txtGpuModel.Text,
            //    Price = txtGpuPrice.Text,
            //    Shaders = txtGpuShaders.Text
            //};

            //store.Parts.RamBoards = new RamBoard[1];
            //store.Parts.RamBoards[0] = new RamBoard
            //{
            //    Available = Int32.Parse(txtRamAvailable.Text),
            //    Channel = drpRamChannel.SelectedValue,
            //    Frequency = txtRamFrequency.Text,
            //    ID = txtRamID.Text,
            //    Manufacturer = txtRamManufacturer.Text,
            //    Memory = txtRamMemory.Text,
            //    Price = txtRamPrice.Text,
            //    Type = txtRamType.Text
            //};

            //store.Parts.HardDrives = new HardDrive[1];
            //store.Parts.HardDrives[0] = new HardDrive
            //{
            //    Available = Int32.Parse(txtHddAvailable.Text),
            //    Bus = txtHddBus.Text,
            //    DriveMemory = new DriveMemory { Amount = txtHddMemory.Text, Type = txtHddType.Text },
            //    ID = txtHddID.Text,
            //    LaptopCompatible = Boolean.Parse(txtHddLaptop.Text),
            //    Manufacturer = txtHddManufacturer.Text,
            //    Price = txtHddPrice.Text,
            //    Size = txtHddSize.Text,
            //    Speed = txtHddSpeed.Text
            //};

            //store.Sockets = new Socket[1];
            //store.Sockets[0] = new Socket
            //{
            //    ID = txtSocketID.Text,
            //    SocketName = txtSocketName.Text
            //};

            //store.MemoryTypes = new Memory[1];
            //store.MemoryTypes[0] = new Memory
            //{
            //    ID = txtMemoryID.Text,
            //    MemoryName = txtMemoryName.Text
            //};

            //XmlSerializer serializer = new XmlSerializer(typeof(ComputerStore));
            //XmlWriterSettings writerSettings = new XmlWriterSettings();
            //writerSettings.Indent = true;
            //writerSettings.IndentChars = "\t";

            //XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            //ns.Add("", "");

            //using (TextWriter textWriter = new StreamWriter("C:\\Users\\betra\\desktop\\res.xml"))
            //using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, writerSettings))
            //{
            //    xmlWriter.WriteDocType("computer-store", null, "computer_store.dtd", null);
            //    serializer.Serialize(xmlWriter, store, ns);
            //}
        }

        protected void btnInputCount_Click(object sender, EventArgs e)
        {

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
