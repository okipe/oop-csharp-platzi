using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperPower
    {
        public string Name;
        public string Description;
        public LevelPower Level;

        public SuperPower()
        {
            Level = LevelPower.LevelOne;
        }
    }
}
