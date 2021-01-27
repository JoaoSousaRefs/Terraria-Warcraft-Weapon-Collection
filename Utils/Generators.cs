using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warcraftweaponscollection.Utils
{
   public class Generators
    {   
        //Percentage int representes %.
        //Ex: int 10 = 10% drop chance.
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

        //Stack size of the roped item.
        //The stack size will be a random number between minimum value and maximum value.
        public static int StackSize(int minimum, int maximum)
        {
            Random mathRandom = new Random();
            var stackSize = mathRandom.Next(minimum, maximum);

            return stackSize;
        }
    }
}
