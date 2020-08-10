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
        int health = 0;
        int power = 0;

        public Weapon weapon;


        public Robot(string nameOfRobo, int health, int power, Weapon weapon)
        {
            this.nameOfRobo = nameOfRobo;
            this.health = health;
            this.power = power;
            this.weapon = weapon;
        }

        public void attack()
        {
            int damage = weapon.attackPower;
            //able to attack a dino!
        }
        public void beingAttacked(int health)
        {
            //get attcked by the dinos!
        }
    }
}
