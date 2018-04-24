using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Assassin : Hero
    {

        public Assassin(string aName, int aHealthPoints, int aAttackPoints, int aArmorPoints)
            : base(aName, aHealthPoints, aAttackPoints, aArmorPoints)
        {
        }

        public override double GetAttack()
        { // returns the raw damage
            AttackPoints = this.AttackPoints * ((double)Chance.GetPercent() / 100);
            double chance = Chance.GetPercentForSpecial();
            if (chance > 0 && 31 > chance)
            { // 30% chance to cause 300% damage
                Console.WriteLine("Critical !");
                return AttackPoints * 3;
            }
            return AttackPoints;
        }

        public override double GetDeffence()
        { // returns the value to reduce the attack with
            return this.ArmorPoints * ((double)Chance.GetPercent() / 100);
        }

    }
}
