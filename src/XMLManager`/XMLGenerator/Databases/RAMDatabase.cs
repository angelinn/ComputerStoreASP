using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator.Databases
{
    public class RAMDatabase
    {
        public static string GetRandomRAM()
        {
            return Manufacturers[Generator.random.Next(0, Manufacturers.Length)];
        }

        public static string GetRandomChannel()
        {
            return Channels[Generator.random.Next(0, Channels.Length)];
        }

        public static string GetRandomMemory()
        {
            return Memories[Generator.random.Next(0, Memories.Length)];
        }

        public static string GetRandomType()
        {
            return MemoryTypes.Keys.ElementAt(Generator.random.Next(0, MemoryTypes.Keys.Count));
        }

        public static string GetRandomFrequencyFromType(string type)
        {
            return MemoryTypes[type][Generator.random.Next(0, MemoryTypes[type].Length)] + " мега-хертза";
        }

        private static string[] Memories = { "64мб", "128мб", "256мб", "512мб", "1ГБ", "2ГБ", "4ГБ", "8ГБ", "16ГБ" };
        private static string[] Channels = { "Единичен", "Двоен", "Троен" };
        private static string[] Manufacturers = { "Kingston", "XTremeDDR", "Micron", "Corsair", "Samsung", "AData",
                                                  "Crucial", "Crucial EDO", "Kingston Savage", "Kingston HYPER-X" };

        private static Dictionary<string, int[]> MemoryTypes = new Dictionary<string, int[]>()
        {
            { "DDR1", new int[] { 200, 400 } },
            { "DDR2", new int[] { 800, 833 } },
            { "DDR3", new int[] { 1664, 1666, 1333, 1866, 2133 } },
            { "DDR4", new int[] { 1600, 1866, 2133, 2400 } },
            { "EDO",  new int[] { 100, 122, 140, 210 } }
        };
    }
}
