using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    [Serializable]
    public class VideoCard
    {
        public int ID { get; set; }
        public string Alias { get; set; }
        public string Interface { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string BusWidth { get; set; }
        public string Bandwidth { get; set; }
        public int DirectX { get; set; }
        public string Shaders { get; set; }
        public int Available { get; set; }
        public string Price { get; set; }
        
        public virtual GPUMemory GPUMemory { get; set; }
    }
}
