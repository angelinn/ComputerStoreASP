using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.XML
{
    public class ComputerStore
    {
        public Parts Parts { get; set; }
        public Socket[] Sockets { get; set; }
        public Memory[] MemoryTypes{ get; set; }
    }
}
