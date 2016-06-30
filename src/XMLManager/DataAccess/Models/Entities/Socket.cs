using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Socket
    {
        public Socket()
        {
            Processors = new HashSet<Processor>();
            Motherboards = new HashSet<Motherboard>();
        }

        public static Socket XMLToEntity(XML.Socket xmlSocket)
        {
            Socket socket = new Socket();
            socket.Alias = xmlSocket.ID;
            socket.Name = xmlSocket.SocketName;

            return socket;
        }

        public int ID { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Processor> Processors { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }
    }
}
