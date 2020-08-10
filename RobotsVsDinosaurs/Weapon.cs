using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        Random random = new Random(87654);
        string type;
        public int attackPower;

        public Weapon(string type)
        {
            this.type = type;
            this.attackPower = random.Next(1, 12);            
        }
    }
}
