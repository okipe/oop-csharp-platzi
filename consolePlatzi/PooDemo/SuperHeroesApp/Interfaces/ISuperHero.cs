using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Interfaces
{
    internal interface ISuperHero
    {
        int Id { get; set; }
        string Name { get; set; }
        string SecretIdentity { get; set; }
    }
}
