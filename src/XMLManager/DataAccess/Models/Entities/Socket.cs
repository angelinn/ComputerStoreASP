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
            return new Socket
            {
                Alias = xmlSocket.ID,
                Name = xmlSocket.SocketName
            };
        }

        public int ID { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Processor> Processors { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }
    }
}
