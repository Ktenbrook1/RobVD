using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        //might want to move this up but will leave for now
        Random random = new Random();
        string type;
        public int attackPower;

        public Weapon(string type)
        {
            this.type = type;
            this.attackPower = random.Next(1, 12);            
        }
    }
}
