using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Knight : Hero
    {

        public Knight(string aName, int aHealthPoints, int aAttackPoints, int aArmorPoints)
            : base(aName, aHealthPoints, aAttackPoints, aArmorPoints)
        {
        }

        public override double GetAttack()
        { // returns the raw damage
            AttackPoints = this.AttackPoints * ((double)Chance.GetPercent() / 100);
            double chance = Chance.GetPercentForSpecial();
            if (chance > 0 && 11 > chance)
            { // 10% chance to cause 200% damage
                Console.WriteLine("Critical!");
                return AttackPoints * 2;
            }
            return AttackPoints;
        }

        public override double GetDeffence()
        { // returns the value to reduce the attack with
            ArmorPoints = this.ArmorPoints * ((double)Chance.GetPercent() / 100);
            double chance = Chance.GetPercentForSpecial();
            if (chance > 0 && 21 > chance)
            { // 20% chance to block
                Console.WriteLine("Block!");
                return 10000;
            }
            return ArmorPoints;
        }

    }
}
