using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Warrior : Hero
    {

        public Warrior(string aName, int aHealthPoints, int aAttackPoints, int aArmorPoints)
            : base (aName, aHealthPoints, aAttackPoints, aArmorPoints)
        {
        }

        public override double GetAttack()
        { // returns the raw damage
            return this.AttackPoints * ((double)Chance.GetPercent() / 100);
        }

        public override double GetDeffence()
        { // returns the value to reduce the attack with
            return this.ArmorPoints * ((double)Chance.GetPercent() / 100);
        }

    }
}
