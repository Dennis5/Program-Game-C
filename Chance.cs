using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Chance
    {
        static Random rand = new Random();
        public static int GetPercentForSpecial()
        { // returns random number between 0 and 100 for special
            return rand.Next(1, 101);
        }

        public static int GetPercent()
        { // returns random number between 80 and 120 for attack and deffence amount
            return rand.Next(80, 121);
        }
    }
}
