using DataAccess.Models.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator.Databases
{
    public class CPUDatabase
    {
        public static string GetRandomCPU()
        {
            int position = Generator.random.Next(0, ProcessorManufacturers.Length);

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
            int position = Generator.random.Next(0, ProcessorModels[manufacturer].Length);

            if (ProcessorModels[manufacturer].Length == 1)
                return ProcessorModels[manufacturer][position];

            string toDelete = ProcessorModels[manufacturer][position];
            ProcessorModels[manufacturer] = ProcessorModels[manufacturer].Where(model => model != toDelete).ToArray();

            return toDelete;
        }

        public static string GetRandomArchitecture(string manufacturer)
        {
            if (manufacturer == "АМД")
                return "amd64";

            return CommonDatabase.GetRandomFromCollection(Architectures);
        }

        public static string GetRandomClockFrequency()
        {
            return Generator.random.Next(10, 41) + "00mhz";
        }

        public static Cache GetRandomCache()
        {
            return new Cache { Levels = Generator.random.Next(1, 3), Memory = Generator.random.Next(1, 6) + "MB" };
        }

        public static Threads GetRandomThreads()
        {
            int physical = Generator.random.Next(1, 8);
            return new Threads { Physical = physical, Logical = physical == 1 ? physical : physical * 2 };
        }

        public static string GetIdFromModel(string model)
        {
            return model;
        }

        public static string GetSocketFromManufacturer(string manufacturer)
        {
            if (manufacturer == "АМД")
                return "AM3";
            else
                return "i1151";
        }

        private static string[] ProcessorManufacturers = { "Интел", "АМД" };
        private static string[] Architectures = { "Максуел", "Бродуел", "Скайлейк", "Хасуел", "Санди Бридж", "Айви Бридж" };
        private static Dictionary<string, string[]> ProcessorModels = new Dictionary<string, string[]>()
        {
            { "Интел", new string[]{ "i5-4200h", "i7-6600k", "i3-5200u", "i3-6500u", "i7-6700HQ", "i5-4210u", "i5-2510m",
                                     "i5-250m", "Pentium N", "Pentium Q", "N2350", "N2370", "M2570", "Core2Duo", "Celeron II",
                                     "Celeron II Xeon", "Pentium II Xeon", "Pentium III", "Pentium 4", "Itanium 2", "Core 2",
                                     "Itanium 2300", "i7-2600s" } },

            { "АМД", new string[] { "Athlon64", "Athlon64X2", "Phenom64", "Sempron64X1", "Opteron4300", "Opteron6700",
                                    "FX-4150", "FX-6130", "FX-8370E", "FX8350-Black", "AthlonX4-860K", "PhenomFX", "Phenom X3",
                                    "Phenom X4", "Athlon II", "Turion II", "Turion 64", "Athlon 64FX", "Am386", "Am486", "Am586",
                                    "Athlon X2 Black Edition", "Phenom II X6 1035T", "Phenom II X4 B93", "Turion X2 RM-77",
                                    "Athlon Neo X2 L325", "Turion II Ultra M660", "Duron 1800", "Duron 1600"} }
        };
    }
}
