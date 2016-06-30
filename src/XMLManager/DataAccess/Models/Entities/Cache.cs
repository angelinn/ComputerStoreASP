using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Cache
    {
        public static Cache XMLToEntity(XML.Cache xmlCache)
        {
            Cache cache = new Cache();
            cache.Levels = xmlCache.Levels;
            cache.Memory = xmlCache.Memory;

            return cache;
        }

        public int ID { get; set; }
        public int Levels { get; set; }
        public string Memory { get; set; }
    }
}
