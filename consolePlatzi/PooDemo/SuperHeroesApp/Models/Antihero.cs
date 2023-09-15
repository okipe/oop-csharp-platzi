using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class Antihero : SuperHero
    {
        public string ToDoAntiheroAction(string actionAH)
        {
            return $"El antiheroe {NameAndSecretIdentity} ha realizado {actionAH}";
        }
    }
}
