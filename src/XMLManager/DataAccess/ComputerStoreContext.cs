using DataAccess.Extensions;
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
        {
            // Database.SetInitializer(new DropCreateDatabaseAlways<ComputerStoreContext>());
        }

        public DbSet<ComputerStore> ComputerStores { get; set; }

        public DbSet<Socket> Sockets { get; set; }
        public DbSet<MemoryType> MemoryTypes { get; set; }

        public DbSet<Processor> Processors { get; set; }
        public DbSet<Threads> Threads { get; set; }
        public DbSet<Cache> Caches { get; set; }

        public DbSet<VideoCard> VideoCards { get; set; }
        public DbSet<GPUMemory> GPUMemories { get; set; }

        public DbSet<RamBoard> RamBoards { get; set; }

        public DbSet<Motherboard> Motherboards { get; set; }

        public DbSet<HardDrive> HardDrives { get; set; }
        public DbSet<DriveMemory> DriveMemories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public void Clear()
        {
            Sockets.Clear();
            MemoryTypes.Clear();
            GPUMemories.Clear();
            DriveMemories.Clear();
            Caches.Clear();
            Threads.Clear();
            HardDrives.Clear();
            Processors.Clear();
            VideoCards.Clear();
            RamBoards.Clear();
            Motherboards.Clear();
            ComputerStores.Clear();
        }
    }
}
