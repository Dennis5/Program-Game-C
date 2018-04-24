using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Monk : Hero
    {

        public Monk(string aName, int aHealthPoints, double aAttackPoints, double aArmorPoints)
            : base(aName, aHealthPoints, aAttackPoints, aArmorPoints)
        {
        }

        public override double GetAttack()
        { // returns the raw damage
            return this.AttackPoints * ((double)Chance.GetPercent() / 100);
        }

        public override double GetDeffence()
        { // returns the value to reduce the attack with
            ArmorPoints = ArmorPoints * ((double)Chance.GetPercent() / 100);
            double chanceForSpecial = Chance.GetPercentForSpecial();
            if (chanceForSpecial > 0 && 31> chanceForSpecial)
            { // 30% chance to block the attack
                Console.WriteLine("Block!");
                return 10000;
            }
            return ArmorPoints;
        }

    }
}
