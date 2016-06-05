using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class ComputerStore
    {
        public ComputerStore()
        {
            Sockets = new HashSet<Socket>();
            MemoryTypes = new HashSet<MemoryType>();
        }

        public static ComputerStore XMLToEntity(Models.XML.ComputerStore xmlStore)
        {
            ComputerStore store = new ComputerStore();
            store.Parts = Parts.XMLToEntity(xmlStore.Parts);

            foreach (XML.Socket xmlSocket in xmlStore.Sockets)
                store.Sockets.Add(Socket.XMLToEntity(xmlSocket));

            foreach (XML.Memory xmlMemory in xmlStore.MemoryTypes)
                store.MemoryTypes.Add(MemoryType.XMLToEntity(xmlMemory));

            foreach (Processor cpu in store.Parts.Processors)
            {
                Socket socket = store.Sockets.FirstOrDefault(s => s.Alias == cpu.Socket);
                if (socket != null)
                    cpu.SocketObject = socket;
            }

            foreach (Motherboard mobo in store.Parts.Motherboards)
            {
                Socket socket = store.Sockets.FirstOrDefault(s => s.Alias == mobo.SocketAlias);
                if (socket != null)
                    mobo.Socket = socket;
            }

            return store;
        }

        public int ID { get; set; }

        public virtual Parts Parts { get; set; }
        public virtual ICollection<Socket> Sockets { get; set; }
        public virtual ICollection<MemoryType> MemoryTypes { get; set; }
    }
}
