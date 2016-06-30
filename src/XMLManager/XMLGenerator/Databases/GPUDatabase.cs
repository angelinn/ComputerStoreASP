using DataAccess.Models.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator.Databases
{
    public class GPUDatabase
    {
        public static string GetRandomManufacturer()
        {
            int position = Generator.random.Next(0, Manufacturers.Length);

            if (Models[Manufacturers[position]].Length == 0)
            {
                string toDelete = Manufacturers[position];
                Manufacturers = Manufacturers.Where(man => man != toDelete).ToArray();
            }
            else
                return Manufacturers[position];

            return GetRandomManufacturer();
        }

        public static string GetRandomModel(string manufacturer)
        {
            int position = Generator.random.Next(0, Models[manufacturer].Length);

            if (Models[manufacturer].Length == 1)
                return Models[manufacturer][position];

            string toDelete = Models[manufacturer][position];
            Models[manufacturer] = Models[manufacturer].Where(model => model != toDelete).ToArray();

            return toDelete;
        }

        public static int GetRandomDirectX()
        {
            return Generator.random.Next(9, 13);
        }

        public static string GetRandomBandwidth()
        {
            return String.Format("{0}.{1}гб/с", Generator.random.Next(10, 40), Generator.random.Next(0, 10));
        }

        public static string GetRandomBusWidth()
        {
            return String.Format("{0} бита", CommonDatabase.GetRandomFromCollection(Bits));
        }

        public static string GetRandomInterface()
        {
            return "PCIE-3";
        }

        public static string GetRandomShaders()
        {
            return String.Format("{0}.{1} гига пиксела", Generator.random.Next(5, 25), Generator.random.Next(0, 10));
        }

        public static GPUMemory GetRandomGPUMemory()
        {
            return new GPUMemory
            {
                Amount = CommonDatabase.GetRandomFromCollection(Bits) * Generator.random.Next(1, 3) + "мега-байта",
                Type = CommonDatabase.GetRandomFromCollection(GraphicMemoryTypes)
            };
        }

        private static int[] Bits = { 64, 128, 256, 512 };
        private static string[] GraphicMemoryTypes = { "GD3", "GD5" };
        private static string[] Manufacturers = { "ATi", "NVidia" };
        private static Dictionary<string, string[]> Models = new Dictionary<string, string[]>()
        {
            { "ATi", new string[] { "Rage", "Rage XL", "Rage Pro", "Rage Fury 128", "Radeon VE", "Radeon 7500",
                                    "Radeon 330", "Radeon 340", "Radeon 9100", "Radeon 9300", "Radeon HD 2400",
                                    "Radeon HD 3450", "Radeon HD 3850 X2", "Radeon HD 6750", "Radeon HD 6850",
                                    "R7 260X", "R7 280", "R9 285", "R9 290X", "R9 295X2", "FirePro W600", "FirePro W9000" } },

            { "NVidia", new string[] { "GeForce 256 SDR", "GeForce 256 DDR", "GeForce2", "GeForce2 MX", "GeForce2 TI",
                                       "GeForce2 Ultra", "GeForce3 TI200", "GeForce3", "GeForce4 MX420", "GeForce FX7500",
                                       "GeForce FX5950 Ultra", "GeForce 6600GT", "GeForce 6800 ULTRA", "GeForce 8300GS",
                                       "GeForce 8800 ULTRA", "GeForce 8900 GTX", "GeForce GTX 850m", "GeForce GTX 950m",
                                       "GeForce GTX 980M TI", "Quadro2 MXR", "Quadro4 PRO", "Quadro4 980XL", "Quadro FX 4800SDI",
                                       "Titan" } }
        };
    }
}
