using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            BattleField battleField = new BattleField();

            Weapon sword = new Weapon("sword");
            Robot walle = new Robot("Walle", 100, 100, sword);

            Robot bender = new Robot("Bender", 100, 100, new Weapon("extendo-arms"));

            Console.WriteLine(walle.weapon.attackPower);
            Console.WriteLine(bender.weapon.attackPower);
        }
    }
}
