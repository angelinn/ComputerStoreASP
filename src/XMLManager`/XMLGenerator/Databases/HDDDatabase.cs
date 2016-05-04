using DataAccess.Models.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator.Databases
{
    public static class HDDDatabase
    {
        public static string GetRandomBus()
        {
            return CommonDatabase.GetRandomFromCollection(Buses);
        }

        public static DriveMemory GetRandomMemory()
        {
            return new DriveMemory
            {
                Amount = CommonDatabase.GetRandomFromCollection(Memories),
                Type = CommonDatabase.GetRandomFromCollection(Types)
            };
        }

        public static string GetRandomSize()
        {
            return CommonDatabase.GetRandomFromCollection(Sizes);
        }

        public static string GetSpeedFromDriveType(string type)
        {
            if (type == "Флаш")
                return "няма";

            return CommonDatabase.GetRandomFromCollection(Speeds);
        }

        public static bool GetLaptopCompatibleFromSize(string size)
        {
            return size == "2.5\"";
        }

        public static string GetRandomManufacturer()
        {
            return CommonDatabase.GetRandomFromCollection(Manufacturers);
        }

        private static string[] Speeds = { "5200 оборота/минута", "7200 оборота/минута" };
        private static string[] Buses = { "SATA2", "SATA3", "ATA" };
        private static string[] Types = { "Флаш", "Оптична" };
        private static string[] Sizes = { "2.5\"", "3.5\"" };
        private static string[] Memories = { "160гб", "256гб", "320гб", "500гб", "1ТБ", "2ТБ" };
        private static string[] Manufacturers = { "Seagate", "Samsung", "Hitachi", "Intel", "Patriot", "Kingston", "Corsair",
                                                  "IBM", "Western Digital", "Seagate Barracuda" };
    }
}
