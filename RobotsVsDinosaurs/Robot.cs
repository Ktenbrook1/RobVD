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

        public string nameOfRobo;
        public int roboHealth;
        int power;
        public string robotWeapon;

        public Weapon weapon;
        List<Weapon> weapons;
        public Robot(string nameOfRobo)
        {
            this.nameOfRobo = nameOfRobo;
            roboHealth = 100;
            power = 100;
            robotWeapon = randomWeapon();
            weapon = new Weapon();
        }
        public string randomWeapon()
        {
            List<string> type = new List<string>() { "Guns", "Lasers", "Extracto Arms", "Shocks" };
            Random random = new Random();
            int index = random.Next(type.Count);

            string robotWeapon = type[index];
            // return random weapon 
            return robotWeapon;

        }

        public void attack(List<Dino> dinos)
        {
            //able to attack a dino!
            int newHealthOfDino = dinos[0].health - weapon.robotPower;
            dinos[0].health = newHealthOfDino;
            if(dinos[0].health > 0)
            {
                Console.WriteLine("Dinosaur, {0}, health is now {1}",dinos[0].nameOfDino, dinos[0].health);
            }
            else
            {
                Console.WriteLine("Dinosaur, {0}, health is now 0", dinos[0].nameOfDino);
            }
            
        }
        public void beingAttacked(int health, List<Dino> dinos, List<Robot> robots)
        {
            //get attcked by the dinos!
            if (roboHealth > 0 && dinos.Count > 0)
            {
                //run the dino attacking if health is greater than zero
                attack(dinos);
            }
            else if(roboHealth < 0)
            {
                Console.WriteLine("Robot has died\n\n");
                robots.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Robots win!!");
            }
        }
    }
}