using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Battle
    {
        private int mInterval; // interval in ms 
        public event HealthPointsChangedEventHandler HealthPointsChanged; 

        public Battle (int aInterval)
        {
            this.mInterval = aInterval;
        }

        protected void OnHealthPointsChanged(Hero hero1)
        {
            if (HealthPointsChanged != null)
            {
                HealthPointsChangedEventArgs args = new HealthPointsChangedEventArgs(hero1.HealthPoints);
                HealthPointsChanged(hero1, args);
            }
        }

        public string PerformASingleAttack(Hero heroA, Hero heroB)
        {
            System.Threading.Thread.Sleep(mInterval);

            double heroAAttackAmount = heroA.GetAttack();
            double heroBDefAmount = heroB.GetDeffence();
            double damage2HeroB = heroAAttackAmount - heroBDefAmount;

            if (damage2HeroB > 0)
            {
                heroB.HealthPoints -= (int)damage2HeroB;
            }
            else damage2HeroB = 0;

            Console.WriteLine("{0} attacks {1} and causes {2} damage.",heroA.Name, heroB.Name, (int)damage2HeroB);
            // prints the attack pts., defence pts. and actual damage of the current attack
            //Console.WriteLine("atk: "+heroAAttackAmount+"| def: "+heroBDefAmount+"| dmg: "+damage2HeroB); 
            OnHealthPointsChanged(heroB);

            if (heroB.HealthPoints <= 0)
            {
                Console.WriteLine("{0} has died. {1} is victorious.", heroB.Name, heroA.Name);
                return "Game Over!";
            }
            else return "";
        }

        public void Run(Hero heroA, Hero heroB)
        {
            while (true)
            {
                if (PerformASingleAttack(heroA, heroB) == "Game Over!")
                {
                    Console.WriteLine("Game Over!");
                    break;
                }
                if (PerformASingleAttack(heroB, heroA) == "Game Over!")
                {
                    Console.WriteLine("Game Over!");
                    break;
                }
            }
        }
    }
}
