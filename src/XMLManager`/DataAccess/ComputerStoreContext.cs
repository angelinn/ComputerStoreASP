using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ComputerStoreContext : DbContext
    {
        public ComputerStoreContext() : base("ComputerStoreContext")
        {   }

        public IDbSet<ComputerStore> ComputerStores { get; set; }

        public IDbSet<Parts> Parts { get; set; }
        public IDbSet<Socket> Sockets { get; set; }
        public IDbSet<MemoryType> MemoryTypes { get; set; }

        public IDbSet<Processor> Processors { get; set; }
        public IDbSet<Threads> Threads { get; set; }
        public IDbSet<Cache> Caches { get; set; }

        public IDbSet<VideoCard> VideoCards { get; set; }
        public IDbSet<GPUMemory> GPUMemories { get; set; }

        public IDbSet<HardDrive> HardDrives { get; set; }
        public IDbSet<DriveMemory> DriveMemories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
