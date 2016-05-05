using DataAccess.Models.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Domain
{
    public class ComputerStoreDO
    { 
        public static void AddStoreData(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Models.XML.ComputerStore));

            using (StreamReader reader = new StreamReader(fileName))
            using (UnitOfWork uow = new UnitOfWork())
            {
                Models.XML.ComputerStore store = (Models.XML.ComputerStore)serializer.Deserialize(reader);

                Parts parts = Parts.XMLToEntity(store.Parts);
                uow.Parts.Add(parts);
                uow.Save();
            }
        }
    }
}
