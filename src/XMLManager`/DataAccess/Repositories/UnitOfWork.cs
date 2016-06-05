using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UnitOfWork : IDisposable
    {
        public UnitOfWork(ComputerStoreContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public UnitOfWork() : this(new ComputerStoreContext())
        { }

        public IGenericRepository<ComputerStore> ComputerStores
        {
            get
            {
                return GetRepository<ComputerStore>();
            }
        }

        public IGenericRepository<Parts> Parts
        {
            get
            {
                return GetRepository<Parts>();
            }
        }

        public IGenericRepository<Socket> Sockets
        {
            get
            {
                return GetRepository<Socket>();
            }
        }

        public IGenericRepository<MemoryType> MemoryTypes
        {
            get
            {
                return GetRepository<MemoryType>();
            }
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            if (!repositories.ContainsKey(typeof(T)))
            {
                Type type = typeof(GenericRepository<T>);
                repositories.Add(typeof(T), Activator.CreateInstance(type, context));
            }
            return (IGenericRepository<T>)repositories[typeof(T)];
        }

        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        private ComputerStoreContext context;
        private Dictionary<Type, object> repositories;
    }
}
