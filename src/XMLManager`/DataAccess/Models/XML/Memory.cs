﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Models.XML
{
    public class Memory
    {
        [XmlAttribute]
        public string ID { get; set; }

        [XmlText]
        public string MemoryName { get; set; }

    }
}