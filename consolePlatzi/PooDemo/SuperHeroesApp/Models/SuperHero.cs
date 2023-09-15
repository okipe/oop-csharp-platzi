using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHero
    {
        private string _Name;
        public int Id;
        // Encapsulamos el Name
        public string Name
        {   get { return _Name; } // retorn del nombre sin modificar.
            set { _Name = value.Trim(); }  // el Value es variable reservada. Permite evitar los errores de añadir espacios gracias a Trim
        }

        public string NameAndSecretIdentity
        {
            get { return $"{Name} ({SecretIdentity})"; }
        }

        public string SecretIdentity;
        public string City;
        public List<SuperPower> SuperPowers;
        public bool CanFly;

        // Constructor, alternativa a "Señalar valores por defecto". Es propia del paradigma POO.
        public SuperHero()
        {
            Id = 1;
            SuperPowers = new List<SuperPower>();
            CanFly = false;
        }

        public string ToUseSuperPower()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var powerItem in SuperPowers)
            {
                sb.AppendLine($"{NameAndSecretIdentity} está usando el superpoder {powerItem.Name}.");
            }

            return sb.ToString();
        }
    }
}
