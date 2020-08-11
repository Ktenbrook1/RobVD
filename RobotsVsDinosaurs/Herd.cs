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
        public Herd(List<Dino> dinos)
        {
            this.dinos = dinos;
        }
        public void ResultOfRobots()
        {
            dino1 = new Dino("T-Rex", 10);
            dinos.Add(dino1);
            dino2 = new Dino("X-Rex", 10);
            dinos.Add(dino2);
            dino3 = new Dino("Z-Rex", 10);
            dinos.Add(dino3);
        }

    }
}
