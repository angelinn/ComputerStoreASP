using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class ComputerStore
    {
        public ComputerStore()
        {
            Processors = new HashSet<Processor>();
            VideoCards = new HashSet<VideoCard>();
            RamBoards = new HashSet<RamBoard>();
            HardDrives = new HashSet<HardDrive>();
            Motherboards = new HashSet<Motherboard>();

            Sockets = new HashSet<Socket>();
            MemoryTypes = new HashSet<MemoryType>();
        }

        public static ComputerStore XMLToEntity(XML.ComputerStore xmlStore)
        {
            ComputerStore store = new ComputerStore();
            foreach (XML.Processor xmlCPU in xmlStore.Parts.Processors)
                store.Processors.Add(Processor.XMLToEntity(xmlCPU));

            foreach (XML.VideoCard xmlGPU in xmlStore.Parts.VideoCards)
                store.VideoCards.Add(VideoCard.XMLToEntity(xmlGPU));

            foreach (XML.Socket xmlSocket in xmlStore.Sockets)
                store.Sockets.Add(Socket.XMLToEntity(xmlSocket));

            foreach (XML.Memory xmlMemory in xmlStore.MemoryTypes)
                store.MemoryTypes.Add(MemoryType.XMLToEntity(xmlMemory));

            foreach (Processor cpu in store.Processors)
            {
                Socket socket = store.Sockets.FirstOrDefault(s => s.Alias == cpu.Socket);
                if (socket != null)
                    cpu.SocketObject = socket;
            }

            foreach (Motherboard mobo in store.Motherboards)
            {
                Socket socket = store.Sockets.FirstOrDefault(s => s.Alias == mobo.SocketAlias);
                if (socket != null)
                    mobo.Socket = socket;
            }

            return store;
        }
        
        public int ID { get; set; }

        public virtual ICollection<Processor> Processors { get; set; }
        public virtual ICollection<VideoCard> VideoCards { get; set; }
        public virtual ICollection<RamBoard> RamBoards { get; set; }
        public virtual ICollection<HardDrive> HardDrives { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }

        public virtual ICollection<Socket> Sockets { get; set; }
        public virtual ICollection<MemoryType> MemoryTypes { get; set; }
    }
}
