using DataAccess.Models.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator
{
    public static class Database
    {
        public static string GetRandomCPU()
        {
            int position = random.Next(0, ProcessorManufacturers.Length);

            if (ProcessorModels[ProcessorManufacturers[position]].Length == 0)
            {
                string toDelete = ProcessorManufacturers[position];
                ProcessorManufacturers = ProcessorManufacturers.Where(man => man != toDelete).ToArray();
            }
            else
                return ProcessorManufacturers[position];

            return GetRandomCPU();
        }

        public static string GetRandomCPUModel(string manufacturer)
        {
            int position = random.Next(0, ProcessorModels[manufacturer].Length);

            if (ProcessorModels[manufacturer].Length == 1)
                return ProcessorModels[manufacturer][position];

            string toDelete = ProcessorModels[manufacturer][position];
            ProcessorModels[manufacturer] = ProcessorModels[manufacturer].Where(model => model != toDelete).ToArray();

            return toDelete;
        }

        public static string GetRandomArchitecture()
        {
            return Architectures[random.Next(0, Architectures.Length)];
        }

        public static string GetRandomClockFrequency()
        {
            return random.Next(10, 41) + "00mhz";
        }

        public static Cache GetRandomCache()
        {
            return new Cache { Levels = random.Next(1, 3), Memory = random.Next(1, 6) + "MB" };
        }

        public static Threads GetRandomThreads()
        {
            int physical = random.Next(1, 8);
            return new Threads { Physical = physical, Logical = physical == 1 ? physical : physical * 2 };
        }

        public static int GetRandomAvailable()
        {
            return random.Next(10);
        }

        public static string GetRandomCPUPrice()
        {
            return random.Next(100, 801) + "лева";
        }

        public static string GetIdFromModel(string model)
        {
            return model;
        }

        public static string GetSocketFromManufacturer(string manufacturer)
        {
            if (manufacturer == "АМД")
                return "AM3+";
            else
                return "1151";
        }

        private static readonly Random random = new Random();
        private static string[] MemoryTypes = { "DDR1", "DDR2", "DDR3", "DDR4" };
        private static string[] ProcessorManufacturers = { "Интел", "АМД" };
        private static string[] Architectures = { "Максуел", "Бродуел", "Скайлейк" };
        private static Dictionary<string, string[]> ProcessorModels = new Dictionary<string, string[]>()
        {
            { "Интел", new string[]{ "i54200h", "i7660k", "i35200u", "i36500u", "i76700HQ", "i54210u", "i52510m",
                                     "i5250m", "PentiumN", "PentiumQ", "N2350", "N2370", "M2570", "core2duo", "celeron"} },

            { "АМД", new string[] { "Athlon64", "Athlon64X2", "Phenom64", "Sempron64X1", "Opteron4300", "Opteron6700",
                                    "FX-4150", "FX-6130", "FX-8370E", "FX8350-Black", "AthlonX4-860K"} }
        };

    }
}
