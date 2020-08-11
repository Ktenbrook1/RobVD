using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class BattleField
    {
        Fleet fleet;
        Herd herd;
        //Console.WriteLine("Please pick from the 3 robots to be on your team!");

        public BattleField()
        {
            List<Robot> robots = new List<Robot>();

            ResultOfRobots(robots);
            fleet = new Fleet(robots);

            List<Dino> dinos = new List<Dino>();

            ResultOfDinos(dinos);
            herd = new Herd(dinos);

            Battle(dinos, robots);
        }
        public void ResultOfRobots(List<Robot> robots)
        {
            Console.WriteLine("Which Robot would you like on your Battlefield? Please pick 3");
            for (int i = 0; i <= 2; i++)
            {
                if (i > 0)
                {
                    Console.WriteLine("Pick another");
                }
                Console.WriteLine("Robo1");
                Console.WriteLine("Robo2");
                Console.WriteLine("Robo3");
                Console.WriteLine();
                string userInput = Console.ReadLine().ToLower();
                UserInput(userInput, robots);
            }
            
        }
        public void ResultOfDinos(List<Dino> dinos)
        {
            Console.WriteLine("Which Dino would you like on your Herd? Please pick 3");
            for (int i = 0; i <= 2; i++)
            {
                if(i > 0)
                {
                    Console.WriteLine("Pick another");
                }
                
                Console.WriteLine("Dino1");
                Console.WriteLine("Dino2");
                Console.WriteLine("Dino3");
                Console.WriteLine();
                string userInput = Console.ReadLine().ToLower();
                UserInput2(userInput, dinos);
            }

        }
        public void UserInput(string userInput, List<Robot> robots)
        {
           
            if (userInput == "robo1")
            {
                Robot robo1 = new Robot("Wall-E", new Weapon());
                robots.Add(robo1);
            }
            else if (userInput == "robo2")
            {
                Robot robo2 = new Robot("Eva", new Weapon());
                robots.Add(robo2);
            }
            else
            {
                Robot robo3 = new Robot("Drone", new Weapon());
                robots.Add(robo3);
            }
        }
        public void UserInput2(string userInput, List<Dino> dinos)
        { 
            if (userInput == "dino1")
            {
                Dino dino1 = new Dino("T-Rex", 10);
                dinos.Add(dino1);
            }
            else if (userInput == "dino2")
            {
                Dino dino2 = new Dino("X-Rex", 10);
                dinos.Add(dino2);
            }
            else
            {
                Dino dino3 = new Dino("Z-Rex", 10);
                dinos.Add(dino3);
            }
        }
        public void Battle(List<Dino> dinos, List<Robot> robots)
        {
            //needs to continue until there are no survivors
            do
            {
                dinos[0].beingAttacked(dinos[0].health, robots, dinos);
                robots[0].beingAttacked(robots[0].roboHealth, dinos, robots);
            } while (dinos.Count > 0 && robots.Count > 0);
            if(dinos.Count() > 0)
            {
                Console.WriteLine("Dinos Win!!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Robots Win!!");
                Console.ReadLine();
            }
        }
    }
}
