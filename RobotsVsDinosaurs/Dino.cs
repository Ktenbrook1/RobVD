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
        int health;
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
            newHealthOfRobot = robots[0].roboHealth;
        }
        public void beingAttacked(int health)
        {
            //get attcked by the robots!
            if(health > 0)
            {
                //run the dino attacking if health is greater than zero
                attack(robots);
            }
            else
            {
                Console.WriteLine("Dino has died");
            }
        }
    }
}
