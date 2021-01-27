using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warcraftweaponscollection.Utils
{
   public class ChanceGenerator
    {
        public static bool Chance(int percentage)
        {
            Random mathRandom = new Random();
            var numberGenerated = mathRandom.Next(1, 100);

            
            if (numberGenerated <= percentage)
            {
                return true;
            }

            return false;
        }
    }
}
