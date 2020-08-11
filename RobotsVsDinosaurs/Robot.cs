using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        List<Dino> dinos;

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

        public void attack(List<Dino> dinos)
        {
            //able to attack a dino!
            int newHealthOfDino = roboHealth - weapon.attackPower;
            weapon.attackPower = roboHealth;
        }
        public void beingAttacked(int health)
        {
            //get attcked by the dinos!
            if (roboHealth > 0)
            {
                //run the dino attacking if health is greater than zero
                attack(dinos);
            }
            else
            {
                Console.WriteLine("Robot has died");
                dinos.RemoveAt(0);
            }
        }
    }
}
