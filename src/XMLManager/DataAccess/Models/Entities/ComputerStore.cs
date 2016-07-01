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

            foreach (XML.HardDrive xmlHDD in xmlStore.Parts.HardDrives)
                store.HardDrives.Add(HardDrive.XMLToEntity(xmlHDD));

            foreach (XML.RamBoard xmlRAM in xmlStore.Parts.RamBoards)
                store.RamBoards.Add(RamBoard.XMLToEntity(xmlRAM));

            foreach (XML.Motherboard xmlMobo in xmlStore.Parts.Motherboards)
                store.Motherboards.Add(Motherboard.XMLToEntity(xmlMobo));

            foreach (XML.Socket xmlSocket in xmlStore.Sockets)
                store.Sockets.Add(Socket.XMLToEntity(xmlSocket));

            foreach (XML.Memory xmlMemory in xmlStore.MemoryTypes)
                store.MemoryTypes.Add(MemoryType.XMLToEntity(xmlMemory));

            foreach (Processor cpu in store.Processors)
                cpu.SocketObject = store.Sockets.FirstOrDefault(s => s.Alias == cpu.Socket);

            foreach (RamBoard ram in store.RamBoards)
                ram.MemoryType = store.MemoryTypes.FirstOrDefault(m => m.Alias == ram.Type);

            foreach (Motherboard mobo in store.Motherboards)
            {
                mobo.Socket = store.Sockets.FirstOrDefault(s => s.Alias == mobo.SocketAlias);
                mobo.Processor = store.Processors.FirstOrDefault(c => c.Alias == mobo.ProcessorAlias);
                mobo.VideoCard = store.VideoCards.FirstOrDefault(v => v.Alias == mobo.GpuAlias);
                mobo.HardDrive = store.HardDrives.FirstOrDefault(h => h.Alias == mobo.HDDAlias);
                mobo.RamBoard = store.RamBoards.FirstOrDefault(r => r.Alias == mobo.RamAlias);
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
