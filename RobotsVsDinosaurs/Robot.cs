using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        string nameOfRobo;
        public int roboHealth;
        int power;

        public Weapon weapon;


        public Robot(string nameOfRobo, Weapon weapon)
        {
            this.nameOfRobo = nameOfRobo;
            roboHealth = 100;
            power = 100;
            this.weapon = weapon;
        }

        public void attack()
        {
            int newHealthOfDino = weapon.attackPower;

            //able to attack a dino!
        }
        public void beingAttacked(int health)
        {
            //get attcked by the dinos!
        }
    }
}
