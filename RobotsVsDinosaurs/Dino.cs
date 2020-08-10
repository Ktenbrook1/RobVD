using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dino
    {
        string nameOfDino = "";
        int health = 0;
        int energy = 0;
        int attcPower;
        public Dino(string nameOfDino, int health, int energy, int attcPower)
        {
            this.nameOfDino = nameOfDino;
            this.health = health;
            this.energy = energy;
            this.attcPower = attcPower;
        }

        public void attack(int attcPower)
        {
            //able to attack a robot!
        }
        public void beingAttacked(int health)
        {
            //get attcked by the robots!
        }
    }
}
