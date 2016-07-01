using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Threads
    {
        public static Threads XMLToEntity(XML.Threads xmlThreads)
        {
            return new Threads()
            {
                Logical = xmlThreads.Logical,
                Physical = xmlThreads.Physical
            };
        }

        public int ID { get; set; }
        public int Logical { get; set; }
        public int Physical { get; set; }
    }
}
