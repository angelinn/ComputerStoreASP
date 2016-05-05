using DataAccess.Models.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Domain
{
    public class ComputerStoreDO
    { 
        public static void AddStoreData(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Models.XML.ComputerStore));

            using (StreamReader reader = new StreamReader(fileName))
            using (UnitOfWork uow = new UnitOfWork())
            {
                Models.XML.ComputerStore store = (Models.XML.ComputerStore)serializer.Deserialize(reader);

                Parts parts = Parts.XMLToEntity(store.Parts);
                List<Socket> sockets = new List<Socket>();
                List<MemoryType> memoryTypes = new List<MemoryType>();

                foreach (Models.XML.Socket xmlSocket in store.Sockets)
                {
                    sockets.Add(Socket.XMLToEntity(xmlSocket));
                    uow.Sockets.Add(sockets.Last());
                }

                foreach(Models.XML.Memory xmlMemoryType in store.MemoryTypes)
                {
                    memoryTypes.Add(MemoryType.XMLToEntity(xmlMemoryType));
                    uow.MemoryTypes.Add(memoryTypes.Last());
                }

                foreach (Processor cpu in parts.Processors)
                {
                    Socket socket = sockets.FirstOrDefault(s => s.Alias == cpu.Socket);
                    if (socket != null)
                        cpu.SocketObject = socket;
                }

                foreach (Motherboard mobo in parts.Motherboards)
                {
                    Socket socket = sockets.FirstOrDefault(s => s.Alias == mobo.SocketAlias);
                    if (socket != null)
                        mobo.Socket = socket;
                }

                uow.Parts.Add(parts);
                uow.Save();
            }
        }
    }
}
