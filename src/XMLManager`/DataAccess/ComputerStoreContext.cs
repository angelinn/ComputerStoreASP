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
    internal class ComputerStoreContext : DbContext
    {
        public ComputerStoreContext() : base("ComputerStoreContext")
        {   }

        public IDbSet<Parts> Parts { get; set; }
        public IDbSet<Socket> Sockets { get; set; }
        public IDbSet<MemoryType> MemoryTypes { get; set; }

        public IDbSet<Processor> Processors { get; set; }
        public IDbSet<Threads> Threads { get; set; }
        public IDbSet<Cache> Caches { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
