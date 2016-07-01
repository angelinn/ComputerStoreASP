using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Processor
    {
        public static Processor XMLToEntity(XML.Processor xmlProcessor)
        {
            return new Processor()
            {
                Alias = xmlProcessor.ID,
                Architecture = xmlProcessor.Architecture,
                Available = xmlProcessor.Available,
                Cache = Cache.XMLToEntity(xmlProcessor.Cache),
                ClockFrequency = xmlProcessor.ClockFrequency,
                IntegratedVideo = xmlProcessor.IntegratedVideo,
                Manufacturer = xmlProcessor.Manufacturer,
                Model = xmlProcessor.Model,
                Price = xmlProcessor.Price,
                Socket = xmlProcessor.Socket,
                Threads = Threads.XMLToEntity(xmlProcessor.Threads)
            };
        }

        public int ID { get; set; }
        public string Alias { get; set; }
        public string Socket { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Architecture { get; set; }
        public string ClockFrequency { get; set; }
        public string Price { get; set; }
        public int Available { get; set; }
        public bool IntegratedVideo { get; set; }

        public virtual Threads Threads { get; set; }
        public virtual Cache Cache { get; set; }
        public virtual Socket SocketObject { get; set; }
    }
}
