using DataAccess.Models.XML;
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
            XmlSerializer serializer = new XmlSerializer(typeof(ComputerStore));

            using (StreamReader reader = new StreamReader(fileName))
            using (UnitOfWork uow = new UnitOfWork())
            {
                ComputerStore store = (ComputerStore)serializer.Deserialize(reader);
            }
        }
    }
}
