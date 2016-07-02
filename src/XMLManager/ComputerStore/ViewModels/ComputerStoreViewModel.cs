using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerStore.ViewModels
{
    public class ComputerStoreViewModel
    {
        public int ID { get; set; }
        public int ProcessorCount { get; set; }
        public int GPUCount { get; set; }
        public int HDDCount { get; set; }
        public int RAMCount { get; set; }
        public int MoboCount { get; set; }
        public int SocketCount { get; set; }
        public int MemoryCount { get; set; }
    }
}