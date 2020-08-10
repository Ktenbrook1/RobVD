using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        List<Dino> dinos;

        Dino dino1;
        Dino dino2;
        Dino dino3;

        Random random = new Random();
        int atkPower;
        public Herd(List<Dino> dinos)
        {

        }
        public void ResultOfRobots()
        {
            Console.WriteLine("Which Robot would you like on your Battlefield? Please pick 3");

            atkPower = random.Next(1, 12);

            //dino1 = new Dino("T-Rex", 100, 50, atkPower);
            //dinos.Add(dino1);
            //dinos2 = new Robot("Eva", 100, 50, "lasers", 10);
            //robots.Add(robo2);
            //robo3 = new Robot("Drone", 100, 20, "drops bombs", 15);
            //robots.Add(robo3);

        }

    }
}
