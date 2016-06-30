using DataAccess.Models.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Domain
{
    public class ComputerStoreDO
    { 
        public static void Add(Models.XML.ComputerStore store)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                ComputerStore dbStore = ComputerStore.XMLToEntity(store);

                uow.ComputerStores.Add(dbStore);
                uow.Save();
            }
        }
    }
}
