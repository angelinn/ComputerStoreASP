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
            Threads threads = new Threads();
            threads.Logical = xmlThreads.Logical;
            threads.Physical = xmlThreads.Physical;

            return threads;
        }

        public int ID { get; set; }
        public int Logical { get; set; }
        public int Physical { get; set; }
    }
}
