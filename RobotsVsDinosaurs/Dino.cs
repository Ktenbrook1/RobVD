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
        public string nameOfDino;
        public int health;
        int energy;
        int dinoPower;

        public int newHealthOfRobot;
        public Dino(string nameOfDino)
        {
            this.nameOfDino = nameOfDino;
            health = 100;
            energy = 100;
            dinoPower = attackType();
        }
        public int attackType()
        {
            int[] dinoAttack = { 10, 15, 22, 17 };
            Random random = new Random();

            int index = random.Next(dinoAttack.Length);
            int dinoPower = dinoAttack[index];
            return dinoPower;
        }
        public void attack(List<Robot> robots, List<Dino> dinos)
        {
            //able to attack a single robot!
            //needs to access the robots health
            int newHealthOfRobot = robots[0].roboHealth - dinos[0].dinoPower;
            robots[0].roboHealth = newHealthOfRobot;
            if(robots[0].roboHealth > 0)
            {
                Console.WriteLine("The Robot, {0}, health is now {1}",robots[0].nameOfRobo, robots[0].roboHealth);
            }
            else
            {
                Console.WriteLine("The Robot, {0}, health is 0", robots[0].nameOfRobo);
            }
            
        }
        public void beingAttacked(int health, List<Robot> robots, List<Dino> dinos)
        {
            //get attcked by the robots!
            //know what to do it the other character dies
            if (health > 0 && robots.Count > 0)
            {
                //run the dino attacking if health is greater than zero
                attack(robots, dinos);
            }
            else if(health <= 0)
            {
                Console.WriteLine("{0} has died\n\n", dinos[0].nameOfDino);
                dinos.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Dinos Win!");
            }
        }
    }
}