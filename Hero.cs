using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public abstract class Hero
    {
        public string Name { get; set; } // name
        public int HealthPoints { get; set; } // health points
        public double AttackPoints { get; set; } // attack points
        public double ArmorPoints { get; set; } // deffence points

        public Hero(string name, int aHealthPoints, double aAttackPoints, double aArmorPoints)
        { // constructor
            this.Name = name;
            this.HealthPoints = aHealthPoints;
            this.AttackPoints = aAttackPoints;
            this.ArmorPoints = aArmorPoints;
        }

        public abstract double GetAttack();

        public abstract double GetDeffence();

    }
}
