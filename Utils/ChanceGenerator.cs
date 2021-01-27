using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warcraftweaponscollection.Utils
{
   public class ChanceGenerator
    {
        public static bool Chance(int oneInHowMany)
        {
            Random mathRandom = new Random();
            var chance = mathRandom.Next(1, oneInHowMany);
            return chance == 1;
        }
    }
}
