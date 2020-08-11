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
        //Console.WriteLine("Please pick from the 3 robots to be on your team!");

        public BattleField()
        {
            List<Robot> robots = new List<Robot>();
            //Robot robo1;
            //Robot robo2;
            //Robot robo3;
            
            ResultOfRobots(robots);
            fleet = new Fleet(robots);
        }
        public void ResultOfRobots(List<Robot> robots)
        {
            Console.WriteLine("Which Robot would you like on your Battlefield? Please pick 3");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Robo1");
                Console.WriteLine("Robo2");
                Console.WriteLine("Robo3");
                string userInput = Console.ReadLine().ToLower();
                UserInput(userInput, robots);
            }
            
        }
        public void UserInput(string userInput, List<Robot> robots)
        {
           
            if (userInput == "robo1")
            {
                Robot robo1 = new Robot("Wall-E", new Weapon("Extendo Arms"));
                robots.Add(robo1);
            }
            else if (userInput == "robo2")
            {
                Robot robo2 = new Robot("Eva", new Weapon("Sword"));
                robots.Add(robo2);
            }
            else
            {
                Robot robo3 = new Robot("Drone", new Weapon("Lasers"));
                robots.Add(robo3);
            }
        }
    }
}
