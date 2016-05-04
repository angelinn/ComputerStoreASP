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
        public int ID { get; set; }
        public int Levels { get; set; }
        public string Memory { get; set; }
    }
}
