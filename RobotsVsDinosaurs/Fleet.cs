using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public List<Robot> robots;
        public Fleet(List<Robot> robots)
        {
            //needs robots to be picked by user
            this.robots = robots;
        }
    }
}

