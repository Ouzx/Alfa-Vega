using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa_Vega
{
    public static class Selected
    {
        public static int NameID = 0;
        public static int TypeID = 0;
        public static int OwnerID = 0;

        public enum Mode
        {
            Type,
            Name,
            Owner
        }

        public static List<List<string>> NAMES = new List<List<string>>();
        public static List<List<string>> TYPES = new List<List<string>>();
        public static List<List<string>> OWNER = new List<List<string>>();
    }
}
