using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dino
    {
        List<Robot> robots;
        string nameOfDino;
        public int health;
        int energy;
        int attcPower;
        public int newHealthOfRobot;
        public Dino(string nameOfDino, int attcPower)
        {
            this.nameOfDino = nameOfDino;
            health = 100;
            energy = 100;
            this.attcPower = attcPower;
        }

        public void attack(List<Robot> robots)
        {
            //able to attack a single robot!
            //needs to access the robots health
            int newHealthOfRobot = robots[0].roboHealth - attcPower;
            robots[0].roboHealth = newHealthOfRobot;
            Console.WriteLine("The Robots health is now {0}", robots[0].roboHealth);
        }
        public void beingAttacked(int health, List<Robot> robots, List<Dino> dinos)
        {
            //get attcked by the robots!
            //know what to do it the other character dies
            if(health > 0 && robots.Count > 0)
            {
                //run the dino attacking if health is greater than zero
                attack(robots);
            }
            else
            {
                Console.WriteLine("Dino has died");
                dinos.RemoveAt(0);
            }
        }
    }
}
