﻿using System;
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
        public int attackPower;

        public Weapon()
        {
            List<string> type = new List<string>() {"Guns", "Lasers", "Extracto Arms", "Shocks" };
            this.attackPower = random.Next(1, 12);            
        }
    }
}
