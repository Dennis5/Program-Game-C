using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero heroA = new Assassin("Player 1", 300, 170, 75);
            Hero heroB = new Monk("Player 2", 450, 105, 110);

            Console.WriteLine("Lets Fight!\n");

            Battle battle = new Battle(500);
            battle.HealthPointsChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("{0} has {1} health points left.\n", sender.Name, sender.HealthPoints);
            };
            battle.Run(heroA, heroB);

            Console.ReadKey(true);
        }


    }
}
