using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator.Databases
{
    public class MotherboardDatabase
    {
        public static string GetSocketIDFromSocket(string socket)
        {
            return socket.First().ToString() + socket.Last();
        }

        public static string GetRandomChipset()
        {
            return CommonDatabase.GetRandomFromCollection(Chipsets);
        }

        public static string GetRandomManufacturer()
        {
            return CommonDatabase.GetRandomFromCollection(Manufacturers);
        }

        private static string[] Chipsets = { "Intel", "AMD", "Nvidia" };
        private static string[] Manufacturers = { "Intel", "AMD", "Nvidia", "ASUS", "Biostar", "ASRock", "Gigabyte", "Acer",
                                                  "Epox", "Powercolor", "Leadtech", "IBM", "Via Technologies" };
    }
}
