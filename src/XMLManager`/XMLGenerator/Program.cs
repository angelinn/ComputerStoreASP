using Common;
using DataAccess.Models.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fileName = "computer-store-{0}.xml";

            for (int i = 5; i < 20; ++i)
            {
                Generator.SerializeXML(Generator.GenerateRandomData(), String.Format(fileName, i));
                if (!XMLValidator.ValidateXML(String.Format(fileName, i)))
                    Console.ReadLine();
            }
        }
    }
}
