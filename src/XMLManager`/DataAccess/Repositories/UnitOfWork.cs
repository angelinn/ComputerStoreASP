using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UnitOfWork
    {
        public UnitOfWork(ComputerStoreContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public UnitOfWork() : this(new ComputerStoreContext())
        { }

        public IGenericRepository<Parts> Parts
        {
            get
            {
                return GetRepository<Parts>();
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

        private ComputerStoreContext context;
        private Dictionary<Type, object> repositories;
    }
}
