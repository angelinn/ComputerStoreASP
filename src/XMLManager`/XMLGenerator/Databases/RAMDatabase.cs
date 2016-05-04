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
            return CommonDatabase.GetRandomFromCollection(Manufacturers);
        }

        public static string GetRandomChannel()
        {
            return CommonDatabase.GetRandomFromCollection(Channels);
        }

        public static string GetRandomMemory()
        {
            return CommonDatabase.GetRandomFromCollection(Memories);
        }

        public static string GetRandomType()
        {

            return CommonDatabase.GetRandomFromCollection(MemoryTypes.Keys);
        }

        public static string GetRandomFrequencyFromType(string type)
        {
            return CommonDatabase.GetRandomFromCollection(MemoryTypes[type]) + " мега-херца";
        }

        public static string GetRAMNameFromID(string name)
        {
            if (name[0] == 'D')
                return "DDR" + name.Last();

            else
                return "EDO";
        }

        private static string[] Memories = { "64мб", "128мб", "256мб", "512мб", "1ГБ", "2ГБ", "4ГБ", "8ГБ", "16ГБ" };
        private static string[] Channels = { "Единичен", "Двоен", "Троен" };
        private static string[] Manufacturers = { "Kingston", "XTremeDDR", "Micron", "Corsair", "Samsung", "AData",
                                                  "Crucial", "Crucial EDO", "Kingston Savage", "Kingston HYPER-X" };

        private static Dictionary<string, int[]> MemoryTypes = new Dictionary<string, int[]>()
        {
            { "D1", new int[] { 200, 400 } },
            { "D2", new int[] { 800, 833 } },
            { "D3", new int[] { 1664, 1666, 1333, 1866, 2133 } },
            { "D4", new int[] { 1600, 1866, 2133, 2400 } },
            { "ER",  new int[] { 100, 122, 140, 210 } }
        };
    }
}
